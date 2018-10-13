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
                if (txtProgramName.Text != "" && txtProgramAcronym.Text != "" && txtCurriculumYear.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        if (md.existProgram(txtProgramName.Text, txtCurriculumYear.Text) == false)
                        {
                            curriculumData.c_curriculumTitle = txtProgramName.Text;
                            //create program into a curriculum
                            curriculumData.c_id = md.CreateCurriculum(txtProgramName.Text, usersData.a_id, dt, txtCurriculumYear.Text);
                            //create course into a curriculum
                            md.C_AddCourses(curriculumData.c_id, txtProgramName.Text, txtProgramAcronym.Text);

                            frmSemesterAndSchoolYear sas = new frmSemesterAndSchoolYear();
                            sas.Show();
                            this.Hide();

                            //audit
                            md.AuditTrail(AuditTrailData.username, "Add", txtProgramName.Text + " program.");
                        }
                        else
                        {
                            MessageBox.Show("The Program is already on the list.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fill all fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (txtCurriculumYear.Text == "") txtCurriculumYear.Focus();
                    if (txtProgramAcronym.Text == "") txtProgramAcronym.Focus();
                    if (txtProgramName.Text == "") txtProgramName.Focus();
                }
            }
            else
            {
                if (txtProgramName.Text != "" && txtProgramAcronym.Text != "" && txtCurriculumYear.Text != "")
                {
                    string dt = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                    DialogResult dr = MessageBox.Show("Save changes?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Fill all fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (txtCurriculumYear.Text == "") txtCurriculumYear.Focus();
                    if (txtProgramAcronym.Text == "") txtProgramAcronym.Focus();
                    if (txtProgramName.Text == "") txtProgramName.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCurriculum ahp = new frmCurriculum();
            ahp.Show();
            this.Hide();
        }

        private void txtProgramAcronym_TextChanged(object sender, EventArgs e)
        {
            txtProgramAcronym.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCurriculumYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
