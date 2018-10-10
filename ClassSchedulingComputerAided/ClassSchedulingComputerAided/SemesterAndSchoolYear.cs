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
            cboSemester.Items.Add("SUMMER");
            cboSemester.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            curriculumData.c_semester = cboSemester.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curriculumData.c_semester = cboSemester.Text;

            frmSetCurriculum sc = new frmSetCurriculum();
            sc.Show();
            sc.lbl_control_id.Text = curriculumData.c_id;
            sc.lbl_title.Text = curriculumData.c_curriculumTitle + " ["+ curriculumData.c_semester +" Semester]" ;
            
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
