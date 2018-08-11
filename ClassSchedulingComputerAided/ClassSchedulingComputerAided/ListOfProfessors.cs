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
    public partial class frmListOfProfessors : MetroFramework.Forms.MetroForm
    {
        public frmListOfProfessors()
        {
            InitializeComponent();
        }

        private void ListOfProfessors_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form ahp = new frmAdminHomePage();
            ahp.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfessorClose_Click(object sender, EventArgs e)
        {
            pnlProfessorsInformation.Visible = false;
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            pnlProfessorsInformation.Visible = true;
        }

        private void btnEditProfessor_Click(object sender, EventArgs e)
        {
            frmEditProfessor p = new frmEditProfessor();
            p.Show();
        }
    }
}
