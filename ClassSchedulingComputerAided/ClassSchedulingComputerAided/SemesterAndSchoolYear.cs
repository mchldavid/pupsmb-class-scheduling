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
    public partial class frmSemesterAndSchoolYear : MetroFramework.Forms.MetroForm
    {
        public frmSemesterAndSchoolYear()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void SemesterAndSchoolYear_Load(object sender, EventArgs e)
        {
            cboSemester.Items.Add("1ST");
            cboSemester.Items.Add("2ND");
            cboSemester.Items.Add("3RD");

            //to fill the school year
            string sy = "";
            DateTime dt = new DateTime(2015, DateTime.Now.Month, DateTime.Now.Day);
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            curriculumData.c_semester = cboSemester.Text;
            curriculumData.c_schoolYear = cboSchoolYear.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curriculumData.c_semester = cboSemester.Text;
            curriculumData.c_schoolYear = cboSchoolYear.Text;

            frmSetCurriculum sc = new frmSetCurriculum();
            sc.Show();
            sc.lbl_control_id.Text = curriculumData.c_id;
            sc.lbl_title.Text = curriculumData.c_curriculumTitle + " ["+ curriculumData.c_semester +" Semester] [SY:"+curriculumData.c_schoolYear+"]" ;
            for (int x = 0; x < md.ListCourse(curriculumData.c_id).Length; x++)
            {
                if (md.ListCourse(curriculumData.c_id).GetValue(x).ToString() != "")
                    sc.cboCourse.Items.Add(md.ListCourse(curriculumData.c_id).GetValue(x).ToString());
            }
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSetCourses sc = new frmSetCourses();
            sc.Show();
            sc.lbl_control_id.Text = curriculumData.c_id;
            sc.lbl_title.Text = curriculumData.c_curriculumTitle;
            this.Hide();
        }
    }
}
