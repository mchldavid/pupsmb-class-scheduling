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
    public partial class L_EditProfessorsControl : UserControl
    {
        public L_EditProfessorsControl()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void L_EditProfessorsControl_Load(object sender, EventArgs e)
        {
            cboCourseDepartment.Items.Add("NONE");
            for (int x = 0; x < md.Sections_ListCourse().Length; x++)
                if (md.Sections_ListCourse().GetValue(x).ToString() != "")
                    cboCourseDepartment.Items.Add(md.Sections_ListCourse().GetValue(x).ToString());

            string[] userInfo = new string[12];

            for (int x = 0; x < userInfo.Length; x++)
                userInfo[x] = md.UsersInformation(ListOfProfessorsData.Selected_ID).GetValue(x).ToString();

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

            if (userInfo[11] == "active")
                rdoActive.Checked = true;
            else
                rdoInactive.Checked = true;

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
                                        string status = (rdoActive.Checked == true) ? "active": "inactive";
                                            teachStatus = "Fulltimer";
                                        if (rdoParttimer.Checked == true)
                                            teachStatus = "Parttimer";
                                        if (rdoRetiree.Checked == true)
                                            teachStatus = "Retiree";
                                        md.UpdateUsersAccount(ListOfProfessorsData.Selected_ID, txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, gender, teachStatus, cboCourseDepartment.Text, txtEmailAddress.Text, cleanMobileNumber(txtMobileNumber.Text),status);
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
                    }
                    else
                    {
                        MessageBox.Show("Please select your teaching status", "Teaching Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select gender", "Gender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("All Fields are required", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
