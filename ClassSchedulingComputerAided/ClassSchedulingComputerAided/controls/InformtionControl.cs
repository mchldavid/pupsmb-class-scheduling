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
    public partial class InformtionControl : UserControl
    {
        public InformtionControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void InformtionControl_Load(object sender, EventArgs e)
        {
            string[] userInfo = new string[11];

            cboCourseDepartment.Items.Clear();
            cboCourseDepartment.Items.Add("NONE");
            for (int x = 0; x < md.Sections_ListCourse().Length; x++)
                if (md.Sections_ListCourse().GetValue(x).ToString() != "")
                    cboCourseDepartment.Items.Add(md.Sections_ListCourse().GetValue(x).ToString());

            for (int x = 0; x < userInfo.Length; x++)
                userInfo[x] = md.UsersInformation(usersData.p_id).GetValue(x).ToString();

            txtFirstName.Text = userInfo[2];
            txtMiddleName.Text = userInfo[3];
            txtLastName.Text = userInfo[4];
            txtEmailAddress.Text = userInfo[5];
            txtAddress.Text = userInfo[6];
            txtMobileNumber.Text = userInfo[7].Remove(0,1);
            cboCourseDepartment.Text = userInfo[9];
            txtUsername.Text = userInfo[0];
            txtPassword.Text = ms.decryptPassword(userInfo[1]);
            txtConfirmPassword.Text = ms.decryptPassword(userInfo[1]);

            if (userInfo[8] == "Male")
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;

            if (userInfo[10] == "Fulltimer")
                rdoFulltimer.Checked = true;
            else if (userInfo[10] == "Parttimer")
                rdoParttimer.Checked = true;
            else
                rdoRetiree.Checked = true;

            if (cboCourseDepartment.Text == "")
                cboCourseDepartment.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != ""
                && txtLastName.Text != ""
                && txtAddress.Text != ""
                && txtEmailAddress.Text != ""
                && txtMobileNumber.Text != "(+63)   -    -"
                && txtUsername.Text != ""
                && txtPassword.Text != "")
            {
                if (!(rdoFemale.Checked == false && rdoMale.Checked == false))
                {
                    if (!(rdoFulltimer.Checked == false && rdoParttimer.Checked == false && rdoRetiree.Checked == false))
                    {
                        if (cboCourseDepartment.SelectedIndex != -1)
                        {
                            EmailValidation email = new EmailValidation();
                            if (email.IsValidEmail(txtEmailAddress.Text) == true)
                            {
                                if (txtPassword.Text == txtConfirmPassword.Text)
                                {
                                    DialogResult dr = MessageBox.Show("Do you want to save?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (dr == DialogResult.Yes)
                                    {
                                        frmProfessorHomePage php = new frmProfessorHomePage();
                                        string gender = (rdoMale.Checked == true) ? "Male" : "Female";
                                        string teachStatus = "";
                                        if (rdoFulltimer.Checked == true)
                                            teachStatus = "Fulltimer";
                                        if (rdoParttimer.Checked == true)
                                            teachStatus = "Parttimer";
                                        if (rdoRetiree.Checked == true)
                                            teachStatus = "Retiree";
                                        md.UpdateUsersAccount_1(usersData.p_id, txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, gender, teachStatus, cboCourseDepartment.Text, txtEmailAddress.Text, cleanMobileNumber(txtMobileNumber.Text));

                                        btnCancel_Click_1(sender, e);

                                        //audit
                                        md.AuditTrail(AuditTrailData.username, "Updated", "User's information.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("The specified password do not match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtConfirmPassword.Text = "";
                                    txtConfirmPassword.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("The specified email is invalid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtEmailAddress.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select your program Department.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select your teaching status", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select gender", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("All Fields are required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (txtConfirmPassword.Text == "") { txtConfirmPassword.Focus(); }
                if (txtPassword.Text == "") { txtPassword.Focus(); }
                if (txtUsername.Text == "") { txtUsername.Focus(); }
                if (txtMobileNumber.Text == "(+63)   -    -") { txtMobileNumber.Focus(); }
                if (txtEmailAddress.Text == "") { txtEmailAddress.Focus(); }
                if (txtAddress.Text == "") { txtAddress.Focus(); }
                if (txtLastName.Text == "") { txtLastName.Focus(); }
                if (txtFirstName.Text == "") { txtFirstName.Focus(); }
            }
        }

        //to fix the number
        public string cleanMobileNumber(string s)
        {
            StringBuilder sb = new StringBuilder(s);

            sb.Replace("(+63)", "0");
            sb.Replace("-", "");

            return sb.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            cboCourseDepartment.Enabled = true;
            txtEmailAddress.Enabled = true;
            txtMobileNumber.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnSave.Visible = false;

            btnEdit.Visible = true;

            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            cboCourseDepartment.Enabled = false;
            txtEmailAddress.Enabled = false;
            txtMobileNumber.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;

            InformtionControl_Load(sender, e);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

    }
}
