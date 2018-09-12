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
    public partial class frmMyAccount : MetroFramework.Forms.MetroForm
    {
        public frmMyAccount()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void MyAccount_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

            md.AccountInfo();
            txtFirstName.Text = usersData.a_fName;
            txtMiddleName.Text = usersData.a_mName;
            txtLastName.Text = usersData.a_lName;
            cboGender.Text = usersData.a_gender;
            txtEmailAddress.Text = usersData.a_emailAddress;
            txtAddress.Text = usersData.a_address;
            txtMobileNumber.Text = usersData.a_mobileNubmer;
            txtUsername.Text = usersData.a_username;
            txtPassword.Text = ms.decryptPassword(usersData.a_password);
            txtConfirmPassword.Text = ms.decryptPassword(usersData.a_password);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form ahp = new frmAdminHomePage();
            ahp.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                md.UpdateUsersAccount(usersData.a_id, txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, cboGender.Text, txtEmailAddress.Text, txtMobileNumber.Text);
                frmAdminHomePage ahp = new frmAdminHomePage();
                this.Hide();
                ahp.Show();
            }
        }
    }
}
