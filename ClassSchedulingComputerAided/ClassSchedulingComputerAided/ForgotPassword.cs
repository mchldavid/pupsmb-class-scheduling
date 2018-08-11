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

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

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
            frmSecurityQuestions s = new frmSecurityQuestions();
            s.Show();
            this.Hide();
        }
    }
}
