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
    public partial class MyAccountControl : UserControl
    {
        public MyAccountControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void MyAccountControl_Load(object sender, EventArgs e)
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
            btnCancel.Visible = false;
            btnSave.Visible = false;

            btnEdit.Visible = true;

            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmailAddress.Enabled = false;
            txtMobileNumber.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            cboGender.Enabled = true;

            MyAccountControl_Load(sender, e);
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
                            btnCancel_Click(sender, e);

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;

            btnEdit.Visible = false;

            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtAddress.Enabled = true;
            txtEmailAddress.Enabled = true;
            txtMobileNumber.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
            cboGender.Enabled = true;
        }
    }
}
