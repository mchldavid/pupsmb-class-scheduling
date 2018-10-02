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
    public partial class frmCurriculum : MetroFramework.Forms.MetroForm
    {
        public frmCurriculum()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void Curriculum_Load(object sender, EventArgs e)
        {
            dgvCurriculum.DataSource = md.C_dgv_showCurriculum().DataSource;
            dgvCurriculum.Columns[0].Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Form cc = new frmCreateCurriculum();
            //cc.Show();
            //this.Hide();
            frmCreateProgram cp = new frmCreateProgram();
            cp.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Form ahp = new frmAdminHomePage();
            ahp.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCurriculum.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                frmCreateProgram c = new frmCreateProgram();
                c.Show();
                c.txtProgramName.Text = md.C_dgv_Edit(id).GetValue(0).ToString();
                c.txtCurriculumYear.Text = md.C_dgv_Edit(id).GetValue(1).ToString();
                c.txtProgramAcronym.Text = md.C_dgv_Edit(id).GetValue(4).ToString();

                if (md.C_dgv_Edit(id).GetValue(2).ToString() == "active")
                    c.rdoActive.Checked = true;
                else
                    c.rdoActive.Checked = false;
                c.btnSave.Text = "EDIT";
                curriculumData.c_id = row.Cells[0].Value.ToString();

                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
