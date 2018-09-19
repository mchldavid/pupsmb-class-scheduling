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
    public partial class frmSecurityQuestions : MetroFramework.Forms.MetroForm
    {
        public frmSecurityQuestions()
        {
            InitializeComponent();
        }

        private void SecurityQuestions_Load(object sender, EventArgs e)
        {

        }

        public void randomQuestionPicker()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 5);
            if (num == 1)
            {
                lblQuestion1.Text = "";
                lblQuestion2.Text = "";
                lblQuestion3.Text = "";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmForgotPassword fp = new frmForgotPassword();
            fp.Show();
            this.Hide();
        }
    }
}
