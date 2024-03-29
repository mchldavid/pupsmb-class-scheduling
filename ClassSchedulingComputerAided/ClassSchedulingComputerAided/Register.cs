﻿using System;
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
    public partial class frmRegister : MetroFramework.Forms.MetroForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();
        /*
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= 0x200;
                return myCp;
            }
        }*/

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
            cboCourseDepartment.Items.Add("NONE");
            for (int x = 0; x < md.Sections_ListCourse().Length; x++)
                if (md.Sections_ListCourse().GetValue(x).ToString() != "")
                    cboCourseDepartment.Items.Add(md.Sections_ListCourse().GetValue(x).ToString());
            cboCourseDepartment.SelectedIndex = 0;

            cboQuestion1.SelectedIndex = 0;
            cboQuestion2.SelectedIndex = 0;
            cboQuestion3.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string teachStatus = "";
            string gender = "";

            if (txtFirstName.Text != "" 
                && txtLastName.Text != "" 
                && txtAddress.Text != "" 
                && txtEmailAddress.Text != ""
                && txtMobileNumber.Text != "(+63)   -    -" 
                && txtUsername.Text != "" 
                && txtPassword.Text != "" 
                && txtAnswer1.Text != "" 
                && txtAnswer2.Text != "" 
                && txtAnswer3.Text != "")
            {
                if (!(rdoFemale.Checked == false && rdoMale.Checked == false))
                {
                    gender = (rdoMale.Checked == true) ? "Male" : "Female";
                    if (!(rdoFulltimer.Checked == false && rdoParttimer.Checked == false && rdoRetiree.Checked == false))
                    {
                        if (cboCourseDepartment.SelectedIndex != -1)
                        {
                            EmailValidation email = new EmailValidation();
                            if (email.IsValidEmail(txtEmailAddress.Text) == true)
                            {
                                if (txtPassword.Text == txtConfirmPassword.Text)
                                {
                                    if (cboQuestion1.SelectedIndex != 0 && cboQuestion2.SelectedIndex != 0 && cboQuestion3.SelectedIndex != 0)
                                    {
                                        DialogResult dr = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (dr == DialogResult.Yes)
                                        {
                                            //check if the new username is existing
                                            if (md.existUsername(txtUsername.Text) == false)
                                            {
                                                if (rdoFulltimer.Checked == true)
                                                    teachStatus = "Fulltimer";
                                                if (rdoParttimer.Checked == true)
                                                    teachStatus = "Parttimer";
                                                if (rdoRetiree.Checked == true)
                                                    teachStatus = "Retiree";
                                                md.RegisterUser(txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, gender, teachStatus, cboCourseDepartment.Text, txtEmailAddress.Text, cleanMobileNumber(txtMobileNumber.Text));

                                                //get set security questions
                                                string[] answer = new string[3];
                                                string[] question = new string[3];

                                                answer[0] = txtAnswer1.Text;
                                                answer[1] = txtAnswer2.Text;
                                                answer[2] = txtAnswer3.Text;

                                                question[0] = cboQuestion1.Text;
                                                question[1] = cboQuestion2.Text;
                                                question[2] = cboQuestion3.Text;

                                                md.RegisterSecurityQuestion(txtUsername.Text, ms.encryptPassword(txtPassword.Text), answer, question);
                                                frmLogin l = new frmLogin();
                                                l.Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                MessageBox.Show("The username is already exist!", "Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtUsername.Focus();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please select questions.", "Questions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("The specified password do not match!", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtConfirmPassword.Text = "";
                                    txtConfirmPassword.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("The specified email is invalid!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtEmailAddress.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select your teaching status", "Teaching Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select gender", "Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All Fields are required", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (txtAnswer3.Text == "") { txtAnswer3.Focus(); }
                if (txtAnswer2.Text == "") { txtAnswer2.Focus(); }
                if (txtAnswer1.Text == "") { txtAnswer1.Focus(); }
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

        //to fix the number
        public string cleanMobileNumber(string s)
        {
            StringBuilder sb = new StringBuilder(s);

            sb.Replace("(+63)", "0");
            sb.Replace("-", "");

            return sb.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void rdoFulltimer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoParttimer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoRetiree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.Show();
            this.Hide();
        }

        private void registerControl1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.isPassword = true;
        }

        private void txtMobileNumber_Enter(object sender, EventArgs e)
        {
            lineShape1.BorderColor = Color.FromArgb(67, 0, 17); 
        }

        private void txtMobileNumber_Leave(object sender, EventArgs e)
        {
            lineShape1.BorderColor = Color.DimGray;
        }

        private void txtMobileNumber_MouseHover(object sender, EventArgs e)
        {
            lineShape1.BorderColor = Color.FromArgb(138, 4, 0);
        }

        private void txtMobileNumber_MouseLeave(object sender, EventArgs e)
        {
            if(txtMobileNumber.Focus() == false)
                lineShape1.BorderColor = Color.DimGray;
        }

        private void txtFirstName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
