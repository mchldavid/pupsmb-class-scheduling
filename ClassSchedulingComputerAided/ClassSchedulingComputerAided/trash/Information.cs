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
    public partial class frmInformations : MetroFramework.Forms.MetroForm
    {
        public frmInformations()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void Information_Load(object sender, EventArgs e)
        {
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmProfessorHomePage php = new frmProfessorHomePage();
            php.Show();
            php.lbl_id.Text = lbl_id.Text;
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //DialogResult dr = MessageBox.Show("Do you want to save?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (dr == DialogResult.Yes)
            //{
            //    frmProfessorHomePage php = new frmProfessorHomePage();
            //    string gender = (rdoMale.Checked == true) ? "Male" : "Female";
            //    string teachStatus = "";
            //    if (rdoFulltimer.Checked == true)
            //        teachStatus = "Fulltimer";
            //    if (rdoParttimer.Checked == true)
            //        teachStatus = "Parttimer";
            //    if (rdoRetiree.Checked == true)
            //        teachStatus = "Retiree";
            //    md.UpdateUsersAccount(usersData.p_id, txtUsername.Text, txtPassword.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, gender, teachStatus,"",txtEmailAddress.Text, txtMobileNumber.Text);
            //    php.Show();
            //    php.lbl_id.Text = lbl_id.Text;
            //    this.Hide();
            //}
        }
    }
}
