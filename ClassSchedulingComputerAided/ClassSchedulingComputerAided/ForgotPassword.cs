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
    public partial class frmForgotPassword : MetroFramework.Forms.MetroForm
    {
        public frmForgotPassword()
        {
           InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            txtUsername1.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister r = new frmRegister();
            r.Show();
            this.Hide();
        }

        private void btnOtherWay_Click(object sender, EventArgs e)
        {
            frmTryInOtherWay t = new frmTryInOtherWay();
            t.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //test the username if exists
            if (md.UserExists(txtUsername1.Text) == true)
            {
                frmSecurityQuestions s = new frmSecurityQuestions();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The credentials doesn't match in our records.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername1.Text = "";
                txtUsername1.Focus();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            btnNext_Click(sender, e);
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername1.Focus();
        }

        private void txtUsername_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == Convert.ToChar(Keys.Enter))
                btnNext_Click(sender, e);
        }
    }
}
