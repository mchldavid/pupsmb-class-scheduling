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
    public partial class frmCreateProgram : MetroFramework.Forms.MetroForm
    {
        public frmCreateProgram()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void CreateProgram_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "SAVE")
            {
                string dt = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                DialogResult dr = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    
                    //create program into a curriculum
                    curriculumData.c_id = md.CreateCurriculum(txtProgramName.Text, usersData.a_id, dt, txtCurriculumYear.Text);
                    //create course into a curriculum
                    md.C_AddCourses(curriculumData.c_id, txtProgramName.Text, txtProgramAcronym.Text);

                    frmSemesterAndSchoolYear sas = new frmSemesterAndSchoolYear();
                    sas.Show();
                    this.Hide();
                }
            }
            else
            {
                string dt = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                DialogResult dr = MessageBox.Show("Do you want to save the edit?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    frmSemesterAndSchoolYear sc = new frmSemesterAndSchoolYear();
                    sc.Show();
                    curriculumData.c_curriculumTitle = txtProgramName.Text;
                    //sc.lbl_control_id.Text = md.CreateCurriculum(txtCurriculumTitle.Text, txtPublishedBy.Text, dt);
                    string isActive = "inactive";
                    string used = "NO";
                    if (rdoActive.Checked == true)
                        isActive = "active";
                    //if (rdoUsed.Checked == true)
                    //    used = "YES";
                    md.C_editCurriculum(txtProgramName.Text, txtProgramAcronym.Text, txtCurriculumYear.Text, usersData.a_id, dt, isActive);
                    this.Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCurriculum ahp = new frmCurriculum();
            ahp.Show();
            this.Hide();
        }
    }
}
