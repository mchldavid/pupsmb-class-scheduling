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
            md.R_AddRooms(txtRoomName.Text, txtRoomCode.Text, txtSlots.Text);
            lstActiveRooms.Items.Add(txtRoomCode.Text);
            dgvShowRooms.DataSource = md.dgv_showRooms().DataSource;
        }

        private void btnSetRooms_Click(object sender, EventArgs e)
        {
            pnlSetRooms.Visible = true;
            dgvShowRooms.DataSource = md.dgv_showRooms().DataSource;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSetRooms.Visible = false;
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
                md.R_UpdateRooms(lstInActiveRooms.SelectedItem.ToString(), "ACTIVE");
                lstInActiveRooms.Items.RemoveAt(lstInActiveRooms.SelectedIndex);
                lstActiveRooms.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }

        private void lstActiveRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
