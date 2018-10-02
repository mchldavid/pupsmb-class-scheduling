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
            dgvShow.DataSource = md.dgv_showCourse().DataSource;
            dgvShow.Columns[0].Visible = false;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

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
            foreach (DataGridViewRow dr in dgvShow.SelectedRows)
            {
                lblRowId.Text = dr.Cells[0].Value.ToString();
                txtEditCourseAcronym.Text = dr.Cells[1].Value.ToString();
                txtEditCourseName.Text = dr.Cells[2].Value.ToString();
            }

        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            pnlEditCourse.Visible = false;
            txtEditCourseName.Text = "";
            txtEditCourseAcronym.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmSemesterAndSchoolYear sas = new frmSemesterAndSchoolYear();
            sas.Show();
            this.Hide();
            //frmSetCurriculum sc = new frmSetCurriculum();
            //sc.Show();
            //sc.lbl_control_id.Text = curriculumData.c_id;
            //curriculumData.c_curriculumTitle = lbl_title.Text;
            //for (int x = 0; x < md.ListCourse(curriculumData.c_id).Length; x++)
            //{
            //    if (md.ListCourse(curriculumData.c_id).GetValue(x).ToString() != "")
            //        sc.cboCourse.Items.Add(md.ListCourse(curriculumData.c_id).GetValue(x).ToString());
            //}
            //this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Course saved!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            md.C_AddCourses(curriculumData.c_id, txtAddCourseName.Text, txtAddCourseAcronym.Text);
            dgvShow.DataSource = md.dgv_showCourse().DataSource;
            txtAddCourseAcronym.Text = "";
            txtAddCourseName.Text = "";
            pnlAddCourse.Visible = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            dgvShow.DataSource = md.dgv_showCourse().DataSource;
            md.C_EditCourses(lblRowId.Text , txtEditCourseName.Text, txtEditCourseAcronym.Text);
            pnlEditCourse.Visible = false;
            txtEditCourseAcronym.Text = "";
            txtEditCourseName.Text = "";
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            dgvShow.DataSource = md.dgv_showCourse().DataSource;
            pnlAddCourse.Visible = false;
            txtAddCourseAcronym.Text = "";
            txtAddCourseName.Text = "";
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            pnlEditCourse.Visible = false;
            pnlAddCourse.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dgv in dgvShow.SelectedRows)
            {
                string name = dgv.Cells[2].Value.ToString();
                string acronym = dgv.Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("Do you want to delete " + name + "-"+ acronym +"? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == dr)
                {
                    md.C_DeleteCourse(dgv.Cells[0].Value.ToString());
                    dgvShow.DataSource = md.dgv_showCourse().DataSource;
                }
            }
        }
    }
}
