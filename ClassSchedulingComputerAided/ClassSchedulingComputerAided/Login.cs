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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void Form1_Load(object sender, EventArgs e)
        {
            md.ConnectSql();
            txtUsername.Focus();
            txtPassword.isPassword = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form r = new frmRegister();
            r.Show();
            this.Hide();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword fp = new frmForgotPassword();
            fp.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                //test the login request
                if (md.LoginTest(txtUsername.Text, ms.encryptPassword(txtPassword.Text)).GetValue(0).ToString() == "PASSED")
                {
                    if (md.LoginTest(txtUsername.Text, ms.encryptPassword(txtPassword.Text)).GetValue(2).ToString() == "administrator")
                    {
                        frmAdminHomePage admin = new frmAdminHomePage();
                        admin.Show();
                        usersData.a_id = md.LoginTest(txtUsername.Text, ms.encryptPassword(txtPassword.Text)).GetValue(1).ToString();
                        this.Hide();
                    }
                    else if (md.LoginTest(txtUsername.Text, ms.encryptPassword(txtPassword.Text)).GetValue(2).ToString() == "professor")
                    {
                        frmProfessorHomePage ph = new frmProfessorHomePage();
                        ph.Show();
                        usersData.p_id = md.LoginTest(txtUsername.Text, ms.encryptPassword(txtPassword.Text)).GetValue(1).ToString();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Account Doesn't Exists!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    txtUsername.Focus();
                }
            }
            else
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Username is required!", "Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Password is required!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
                btnLogin_Click(sender, e);
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmConnectionWizard fcw = new frmConnectionWizard();
            fcw.Show();
            fcw.btnCancel.Text = "CANCEL ";
            this.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
