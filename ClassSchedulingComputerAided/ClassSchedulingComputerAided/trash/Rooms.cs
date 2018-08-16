using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    public partial class frmRooms : MetroFramework.Forms.MetroForm
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void Rooms_Load(object sender, EventArgs e)
        {
            for(int x = 0; x < md.R_ListRooms_Active().Length; x++)
                if(md.R_ListRooms_Active().GetValue(x).ToString() != "")
                    lstActiveRooms.Items.Add(md.R_ListRooms_Active().GetValue(x).ToString());
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            pnlSetRooms.Visible = false;
        }

        private void btnSetRooms_Click(object sender, EventArgs e)
        {
            pnlSetRooms.Visible = true;
            txtRoomName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form ahp = new frmAdminHomePage();
            ahp.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            md.R_AddRooms(txtRoomName.Text, txtRoomCode.Text, txtSlots.Text);
            lstActiveRooms.Items.Add(txtRoomCode.Text);
        }

        private void lstInActiveRooms_DragOver(object sender, DragEventArgs e)
        {
        }

        private void lstInActiveRooms_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void lstInActiveRooms_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstInActiveRooms_DragDrop_1(object sender, DragEventArgs e)
        {
            lstInActiveRooms.Items.Add(e.Data.GetData(DataFormats.Text));
        }

        private void lstActiveRooms_MouseDown_1(object sender, MouseEventArgs e)
        {
            lstActiveRooms.DoDragDrop(lstActiveRooms.SelectedItem,DragDropEffects.All);
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {

        }
    }
}
