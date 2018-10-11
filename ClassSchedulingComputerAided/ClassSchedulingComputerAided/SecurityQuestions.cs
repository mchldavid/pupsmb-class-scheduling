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

        MyDatabase md = new MyDatabase();

        private void SecurityQuestions_Load(object sender, EventArgs e)
        {
            randomQuestionPicker();
        }

        public void randomQuestionPicker()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 6);
            if (num == 1)
            {
                lblQuestion1.Text = md.ShowMyQuestions(usersData.p_id).GetValue(0).ToString();
                lblQuestion2.Text = md.ShowMyQuestions(usersData.p_id).GetValue(1).ToString();
                lblQuestion3.Text = md.ShowMyQuestions(usersData.p_id).GetValue(2).ToString();
            }
            if (num == 2)
            {
                lblQuestion1.Text = md.ShowMyQuestions(usersData.p_id).GetValue(2).ToString();
                lblQuestion2.Text = md.ShowMyQuestions(usersData.p_id).GetValue(1).ToString();
                lblQuestion3.Text = md.ShowMyQuestions(usersData.p_id).GetValue(0).ToString();
            }
            if (num == 3)
            {
                lblQuestion1.Text = md.ShowMyQuestions(usersData.p_id).GetValue(1).ToString();
                lblQuestion2.Text = md.ShowMyQuestions(usersData.p_id).GetValue(2).ToString();
                lblQuestion3.Text = md.ShowMyQuestions(usersData.p_id).GetValue(0).ToString();
            }
            if (num == 4)
            {
                lblQuestion1.Text = md.ShowMyQuestions(usersData.p_id).GetValue(2).ToString();
                lblQuestion2.Text = md.ShowMyQuestions(usersData.p_id).GetValue(0).ToString();
                lblQuestion3.Text = md.ShowMyQuestions(usersData.p_id).GetValue(1).ToString();
            }
            if (num == 5)
            {
                lblQuestion1.Text = md.ShowMyQuestions(usersData.p_id).GetValue(1).ToString();
                lblQuestion2.Text = md.ShowMyQuestions(usersData.p_id).GetValue(0).ToString();
                lblQuestion3.Text = md.ShowMyQuestions(usersData.p_id).GetValue(2).ToString();
            }
            if (num == 6)
            {
                lblQuestion1.Text = md.ShowMyQuestions(usersData.p_id).GetValue(1).ToString();
                lblQuestion2.Text = md.ShowMyQuestions(usersData.p_id).GetValue(2).ToString();
                lblQuestion3.Text = md.ShowMyQuestions(usersData.p_id).GetValue(0).ToString();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmForgotPassword fp = new frmForgotPassword();
            fp.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //to check all answer if it is valid
            int correctAnswer = 0;
            if (md.ValidSecurityQuestion(usersData.p_id, txtAnswer1.Text, lblQuestion1.Text) == true)
                correctAnswer++;
            if (md.ValidSecurityQuestion(usersData.p_id, txtAnswer2.Text, lblQuestion2.Text) == true)
                correctAnswer++;
            if (md.ValidSecurityQuestion(usersData.p_id, txtAnswer3.Text, lblQuestion3.Text) == true)
                correctAnswer++;

            if (correctAnswer == 3)//to create a new password
            {
                NewPassword np = new NewPassword();
                this.Hide();
                np.Show();
            }
            else
            {
                MessageBox.Show("Invalid Answer/s. Please enter your valid security answer!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnswer1.Text = "";
                txtAnswer2.Text = "";
                txtAnswer3.Text = "";
                txtAnswer1.Focus();
            }
        }
    }
}
