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
    public partial class NewPassword : MetroFramework.Forms.MetroForm
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void frmNewPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmNewPassword.Text)
            {
                md.UpdateNewPassword(usersData.p_id, ms.encryptPassword(txtNewPassword.Text));
                MessageBox.Show("The new password has been set!. You can now login with the new password!", "New Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (md.LoginTest(usersData.p_usr, ms.encryptPassword(txtNewPassword.Text)).GetValue(2).ToString() == "professor")
                {
                    frmProfessorHomePage ph = new frmProfessorHomePage();
                    ph.Show();
                    ph.btnMyInformation_Click(sender, e);
                    usersData.p_id = md.LoginTest(usersData.p_usr, ms.encryptPassword(txtNewPassword.Text)).GetValue(1).ToString();
                    this.Hide();
                }
                if (md.LoginTest(usersData.p_usr, ms.encryptPassword(txtNewPassword.Text)).GetValue(2).ToString() == "administrator")
                {
                    usersData.a_id = md.LoginTest(usersData.p_usr, ms.encryptPassword(txtNewPassword.Text)).GetValue(1).ToString();
                    md.AccountInfo();
                    frmAdminHomePage admin = new frmAdminHomePage();
                    admin.Show();
                    admin.btnMyAccount_Click(sender, e);

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("The specified password do not match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmNewPassword.Text = "";
                txtConfirmNewPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmForgotPassword fp = new frmForgotPassword();
            this.Hide();
            fp.Show();
        }
    }
}
