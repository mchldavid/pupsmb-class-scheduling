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
    public partial class frmPrefferedSubjects : MetroFramework.Forms.MetroForm
    {
        public frmPrefferedSubjects()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void PrefferedSubjects_Load(object sender, EventArgs e)
        {
            lbl_id.Text = usersData.p_id;
            dgvListSubject.DataSource = md.dgv_showPreferredSubjects().DataSource;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlAddSubject.Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            pnlAddSubject.Visible = true;
            cboSubjectBy.SelectedIndex = 0;
            dgvAddSubject.DataSource = md.dgv_showAddPreferredSubjects("Course Subject").DataSource;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmProfessorHomePage php = new frmProfessorHomePage();
            php.Show();
            php.lbl_id.Text = lbl_id.Text;
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAddSubject.SelectedRows)
            {
                md.Prof_AddSubjects(row.Cells[0].Value.ToString());
                dgvListSubject.DataSource = md.dgv_showPreferredSubjects().DataSource;
                MessageBox.Show("You added " +row.Cells[2].Value.ToString() + " into your preferred subjects", "Adding of Subject");
            }
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlAddSubject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void cboSubjectBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAddSubject.DataSource = md.dgv_showAddPreferredSubjects(cboSubjectBy.SelectedItem.ToString()).DataSource;
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }
    }
}
