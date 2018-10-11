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

        MyDatabase md = new MyDatabase();

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
            if (md.TryInOtherWay(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, cleanMobileNumber(txtContactNumber.Text)) == true)
            {
                frmSecurityQuestions s = new frmSecurityQuestions();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credentials doesn't match in our records!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtMiddleName.Text = "";
                txtContactNumber.Text = "";
                txtFirstName.Focus();
            }
        }

        private void s(object sender, EventArgs e)
        {

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
