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
            //validation
            if (txtFirstName.Text != ""
                && txtLastName.Text != ""
                && txtAddress.Text != ""
                && txtEmailAddress.Text != ""
                && txtMobileNumber.Text != "(+63)   -    -"
                && txtUsername.Text != ""
                && txtPassword.Text != ""
                && txtConfirmPassword.Text != "")
            {
                EmailValidation email = new EmailValidation();
                if (email.IsValidEmail(txtEmailAddress.Text) == true)
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        DialogResult dr = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            md.UpdateUsersAdminAccount(usersData.a_id, txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, cboGender.Text, txtEmailAddress.Text, txtMobileNumber.Text);
                            frmAdminHomePage ahp = new frmAdminHomePage();
                            this.Hide();
                            ahp.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The specified password do not match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConfirmPassword.SelectionStart = 0;
                        txtConfirmPassword.SelectionLength = txtConfirmPassword.TextLength;
                        txtConfirmPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The specified email is invalid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailAddress.SelectionStart = 0;
                    txtEmailAddress.SelectionLength = txtEmailAddress.TextLength;
                    txtEmailAddress.Focus();
                }
            }
            else
            {
                MessageBox.Show("All fields are required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtConfirmPassword.Text == "") { txtConfirmPassword.Focus(); }
                if (txtPassword.Text == "") { txtPassword.Focus(); }
                if (txtUsername.Text == "") { txtUsername.Focus(); }
                if (txtMobileNumber.Text == "") { txtMobileNumber.Focus(); }
                if (txtEmailAddress.Text == "") { txtEmailAddress.Focus(); }
                if (txtAddress.Text == "") { txtAddress.Focus(); }
                if (txtLastName.Text == "") { txtLastName.Focus(); }
                if (txtFirstName.Text == "") { txtFirstName.Focus(); }
            }
        }
    }
}
