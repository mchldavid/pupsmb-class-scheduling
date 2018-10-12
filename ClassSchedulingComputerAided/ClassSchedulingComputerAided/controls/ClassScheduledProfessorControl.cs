using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassSchedulingComputerAided.Properties;

namespace ClassSchedulingComputerAided
{
    public partial class ClassScheduledProfessorControl : UserControl
    {
        public ClassScheduledProfessorControl()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        bool on_off = true;

        private void ClassScheduledProfessorControl_Load(object sender, EventArgs e)
        {
            pnlStart.BringToFront();

            string fname = md.UsersInformation(usersData.p_id).GetValue(2).ToString();
            string mname = md.UsersInformation(usersData.p_id).GetValue(3).ToString();
            string lname = md.UsersInformation(usersData.p_id).GetValue(4).ToString();

            //lblName.Text = fname + " " + mname + " " + lname + "(Class Scheduled)";

            cboSemester.Items.Add("1ST");
            cboSemester.Items.Add("2ND");
            cboSemester.Items.Add("SUMMER");

            //to fill the school year
            string startYear = Settings.Default["Year"].ToString();
            string sy = "";
            DateTime dt = new DateTime(Convert.ToInt32(startYear), DateTime.Now.Month, DateTime.Now.Day);
            bool flag = true;
            while (flag)
            {
                if (dt.Year != DateTime.Now.Year)
                {
                    sy += dt.Year.ToString();
                    dt = dt.AddYears(1);
                    sy += "-" + dt.Year.ToString();
                    cboSchoolYear.Items.Add(sy);
                    sy = "";
                }
                else
                {
                    sy += dt.Year.ToString();
                    dt = dt.AddYears(1);
                    sy += "-" + dt.Year.ToString();
                    cboSchoolYear.Items.Add(sy);
                    sy = "";
                    flag = false;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmProfessorHomePage prof = new frmProfessorHomePage();
            this.Hide();
            prof.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboSemester.Text != "" && cboSchoolYear.Text != "")
            {
                pnlStart.Visible = false;

                lblSemester.Text = "[" + cboSemester.Text + " Semester] [SY:" + cboSchoolYear.Text + "]";

                string fname = md.UsersInformation(usersData.p_id).GetValue(2).ToString();
                string mname = md.UsersInformation(usersData.p_id).GetValue(3).ToString();
                string lname = md.UsersInformation(usersData.p_id).GetValue(4).ToString();

                SummaryData.professor = fname + " " + mname + " " + lname;
                SummaryData.semester = cboSemester.Text;
                SummaryData.schoolYear = cboSchoolYear.Text;

                btnSettings.Visible = true;

                profScheduledControl psc = new profScheduledControl();
                pnlProfessor.Controls.Clear();
                pnlProfessor.Controls.Add(psc);

                btnButtonPrint.Visible = true;
                btnPrint.Visible = true;
            }
            else
            {
                MessageBox.Show("Fill all fields are required!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSettings_Click(object sender, EventArgs e)
        { 
            pnlStart.Visible = true; btnSettings.Visible = false; lblSemester.Text = "";
            btnPrint.Visible = false;
            btnButtonPrint.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrintFormDialog pfd = new frmPrintFormDialog();
            pfd.Show();
            pfd.cboTimeTable.Text = "PROFESSOR";
            pfd.cboOption.Text = usersData.p_fName +" "+ usersData.p_mName+" "+usersData.p_lName;
            pfd.cboOption.Enabled = false;
            pfd.cboTimeTable.Enabled = false;
        }

        private void btnButtonPrint_Click(object sender, EventArgs e)
        {
            btnPrint_Click(sender, e);
        }
    }
}
