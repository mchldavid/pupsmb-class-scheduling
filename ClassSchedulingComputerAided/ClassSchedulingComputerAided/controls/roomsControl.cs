using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    public partial class roomsControl : UserControl
    {
        public roomsControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        string id = "";

        private void roomsControl_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < md.R_ListRooms_Active().Length; x++)
                if (md.R_ListRooms_Active().GetValue(x).ToString() != "")
                    lstActiveRooms.Items.Add(md.R_ListRooms_Active().GetValue(x).ToString());

            for (int x = 0; x < md.R_ListRooms_InActive().Length; x++)
                if (md.R_ListRooms_InActive().GetValue(x).ToString() != "")
                    lstInActiveRooms.Items.Add(md.R_ListRooms_InActive().GetValue(x).ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text != "" && txtRoomCode.Text != "" && txtSlots.Text != "")
            {
                //audit
                md.AuditTrail(AuditTrailData.username, "Add", txtRoomCode.Text + " was added to the rooms.");

                md.R_AddRooms(txtRoomName.Text, txtRoomCode.Text, txtSlots.Text);
                lstActiveRooms.Items.Add(txtRoomCode.Text);
                dgvShowRooms.DataSource = md.dgv_showRooms().DataSource;
                dgvShowRooms.Columns[0].Visible = false;

                txtRoomName.Text = "";
                txtRoomCode.Text = "";
                txtSlots.Text = "";
                txtRoomName.Focus();
            }
            else
            {
                MessageBox.Show("Fill all fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomName.Focus();
            }
        }

        private void btnSetRooms_Click(object sender, EventArgs e)
        {
            pnlSetRooms.Visible = true;
            dgvShowRooms.DataSource = md.dgv_showRooms().DataSource;
            dgvShowRooms.Columns[0].Visible = false;
            txtRoomName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSetRooms.Visible = false;
            txtRoomName.Text = "";
            txtRoomCode.Text = "";
            txtSlots.Text = "";

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }

        //drag active to inactive
        private void lstActiveRooms_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstInActiveRooms.SelectedIndex == -1)
            {
                if (lstActiveRooms.SelectedIndex != (-1))
                    lstActiveRooms.DoDragDrop(lstActiveRooms.SelectedItem, DragDropEffects.All);
            }
            else
            {
                lstActiveRooms.SelectedIndex = -1;
                lstInActiveRooms.SelectedIndex = -1;
            }
        }

        private void lstInActiveRooms_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstInActiveRooms_DragDrop(object sender, DragEventArgs e)
        {
            if (lstActiveRooms.SelectedIndex != (-1))
            {
                //audit
                md.AuditTrail(AuditTrailData.username, "Update", lstActiveRooms.SelectedItem.ToString() + " was updated to Inactive room.");

                md.R_UpdateRooms(lstActiveRooms.SelectedItem.ToString(), "INACTIVE");
                lstActiveRooms.Items.RemoveAt(lstActiveRooms.SelectedIndex);
                lstInActiveRooms.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }

        //drag inactive to active
        private void lstInActiveRooms_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstActiveRooms.SelectedIndex == -1)
            {
                if (lstInActiveRooms.SelectedIndex != (-1))
                    lstInActiveRooms.DoDragDrop(lstInActiveRooms.SelectedItem, DragDropEffects.All);
            }
            else
            {
                lstInActiveRooms.SelectedIndex = -1;
                lstActiveRooms.SelectedIndex = -1;
            }
        }

        private void lstActiveRooms_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstActiveRooms_DragDrop(object sender, DragEventArgs e)
        {
            if (lstInActiveRooms.SelectedIndex != (-1))
            {
                //audit
                md.AuditTrail(AuditTrailData.username, "Update", lstInActiveRooms.SelectedItem.ToString() + " was updated to Active room.");

                md.R_UpdateRooms(lstInActiveRooms.SelectedItem.ToString(), "ACTIVE");
                lstInActiveRooms.Items.RemoveAt(lstInActiveRooms.SelectedIndex);
                lstActiveRooms.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }

        private void lstActiveRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {

        }

        private void btnActive_Click(object sender, EventArgs e)
        {

        }

        private void dgvShowRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dr in dgvShowRooms.SelectedRows)
            {
                txtRoomName.Text = dr.Cells[2].Value.ToString();
                txtRoomCode.Text = dr.Cells[1].Value.ToString();
                txtSlots.Text = dr.Cells[3].Value.ToString();
                id = dr.Cells[0].Value.ToString();
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            md.R_SetUpdateRooms(id, txtRoomName.Text, txtRoomCode.Text, txtSlots.Text);
            MessageBox.Show("Edit successful", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //audit
            md.AuditTrail(AuditTrailData.username, "Update", txtRoomCode.Text + " was updated to the rooms.");

            id = "";
            txtRoomCode.Text = "";
            txtRoomName.Text = "";
            txtSlots.Text = "";

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;

            dgvShowRooms.DataSource = md.dgv_showRooms().DataSource;
            dgvShowRooms.Columns[0].Visible = false;
            txtRoomName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            md.R_DeleteRoom(id);
            MessageBox.Show("Delete successful", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //audit
            md.AuditTrail(AuditTrailData.username, "Delete", txtRoomCode.Text + " was deleted to the rooms.");

            id = "";
            txtRoomCode.Text = "";
            txtRoomName.Text = "";
            txtSlots.Text = "";

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;

            dgvShowRooms.DataSource = md.dgv_showRooms().DataSource;
            dgvShowRooms.Columns[0].Visible = false;
            txtRoomName.Focus();
        }
    }
}
