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
    public partial class frmTryInOtherWay : MetroFramework.Forms.MetroForm
    {
        public frmTryInOtherWay()
        {
            InitializeComponent();
        }

        private void TryInOtherWay_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmForgotPassword fp = new frmForgotPassword();
            fp.Show();
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
