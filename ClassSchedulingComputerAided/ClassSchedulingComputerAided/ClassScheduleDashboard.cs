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
    public partial class frmClassScheduleDashboard : MetroFramework.Forms.MetroForm
    {
        public frmClassScheduleDashboard()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void ClassScheduleDashboard_Load(object sender, EventArgs e)
        {
            classSchedulingDashboard_UserControl studentDashboard = new classSchedulingDashboard_UserControl();
            pnlDashboard.Controls.Clear();
            pnlDashboard.Controls.Add(studentDashboard);    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminHomePage ahp = new frmAdminHomePage();
            ahp.Show();
            this.Hide();
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
