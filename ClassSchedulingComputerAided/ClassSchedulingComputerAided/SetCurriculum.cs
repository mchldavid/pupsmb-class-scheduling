using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClassSchedulingComputerAided
{
    public partial class frmSetCurriculum : MetroFramework.Forms.MetroForm
    {
        public frmSetCurriculum()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void SetCurriculum_Load(object sender, EventArgs e)
        {
            cboUnits.SelectedIndex = 0;
            cboLectureHours.SelectedIndex = 0;
            cboLabHours.SelectedIndex = 0;
            cboYearLevel.SelectedIndex = 0;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmCurriculum c = new frmCurriculum();
            c.Show();
            this.Hide();
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmSetCourses sc = new frmSetCourses();
            sc.Show();
            sc.lbl_control_id.Text = curriculumData.c_id;
            sc.lbl_title.Text = lbl_title.Text;
            this.Hide();
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            frmViewList v = new frmViewList();
            v.Show();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            frmAddSubject a = new frmAddSubject();
            a.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added Successfully", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
            md.C_AddSubjects(curriculumData.c_id, lbl_course_id.Text, cboCourse.SelectedItem.ToString(), txtSubjectCode.Text, txtSubjectDescription.Text, cboLectureHours.SelectedItem.ToString(), cboLabHours.SelectedItem.ToString(), cboUnits.SelectedItem.ToString(), cboYearLevel.SelectedItem.ToString());
            
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbl_course_id.Text = md.GetCourseID(cboCourse.SelectedItem.ToString(), curriculumData.c_id);
        }
    }
}
