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
    public partial class frmCreateCurriculum : MetroFramework.Forms.MetroForm
    {
        public frmCreateCurriculum()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void CreateCurriculum_Load(object sender, EventArgs e)
        {
            dtpDatePublished.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "SAVE")
            {
                string dt = dtpDatePublished.Value.ToString("dddd, dd MMMM yyyy");
                DialogResult dr = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    frmSetCourses sc = new frmSetCourses();
                    curriculumData.c_id = md.CreateCurriculum(txtCurriculumTitle.Text, txtPublishedBy.Text, dt);
                    sc.Show();
                    sc.lbl_title.Text = "Curriculum Title: " + txtCurriculumTitle.Text;
                    curriculumData.c_curriculumTitle = txtCurriculumTitle.Text;
                    //sc.lbl_control_id.Text = md.CreateCurriculum(txtCurriculumTitle.Text, txtPublishedBy.Text, dt);
                    sc.lbl_control_id.Text = curriculumData.c_id;
                    
                    this.Hide();
                }
            }
            else
            {
                string dt = dtpDatePublished.Value.ToString("dddd, dd MMMM yyyy");
                DialogResult dr = MessageBox.Show("Do you want to save the edit?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    frmSetCourses sc = new frmSetCourses();
                    sc.Show();
                    sc.lbl_title.Text = "Curriculum Title: " + txtCurriculumTitle.Text;
                    curriculumData.c_curriculumTitle = txtCurriculumTitle.Text;
                    //sc.lbl_control_id.Text = md.CreateCurriculum(txtCurriculumTitle.Text, txtPublishedBy.Text, dt);
                    string active = "inactive";
                    string used = "NO";
                    if (rdoActive.Checked == true)
                        active = "active";
                    if (rdoUsed.Checked == true)
                        used = "YES";
                    md.C_editCurriculum(used, txtCurriculumTitle.Text, txtPublishedBy.Text, dt, active);
                    this.Hide();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form ahp = new frmCurriculum();
            ahp.Show();
            this.Hide();
        }
    }
}
