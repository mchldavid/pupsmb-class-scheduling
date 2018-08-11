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
    public partial class frmSetCourses : MetroFramework.Forms.MetroForm
    {
        public frmSetCourses()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void SetCourses_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnMyInformation_Click(object sender, EventArgs e)
        {
            pnlEditCourse.Visible = false;
            pnlAddCourse.Visible = true;
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            pnlAddCourse.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form sc = new frmSetCurriculum();
            sc.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form sc = new frmCurriculum();
            sc.Show();
            this.Hide();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            pnlAddCourse.Visible = false;
            pnlEditCourse.Visible = true;

        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            pnlEditCourse.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmSetCurriculum sc = new frmSetCurriculum();
            sc.Show();
            sc.lbl_control_id.Text = curriculumData.c_id;
            sc.lbl_title.Text = lbl_title.Text;
            for (int x = 0; x < md.ListCourse(lbl_control_id.Text).Length; x++)
            {
                if (md.ListCourse(curriculumData.c_id).GetValue(x).ToString() != "")
                    sc.cboCourse.Items.Add(md.ListCourse(curriculumData.c_id).GetValue(x).ToString());
            }
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Course saved!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            md.C_AddCourses(curriculumData.c_id, txtAddCourseName.Text, txtAddCourseAcronym.Text);
            pnlAddCourse.Visible = false;
        }
    }
}
