using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    public partial class preferredSubjectsControl : UserControl
    {
        public preferredSubjectsControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void preferredSubjectsControl_Load(object sender, EventArgs e)
        {
            dgvListSubject.DataSource = md.dgv_showPreferredSubjects().DataSource;
            dgvListSubject.Columns[0].Visible = false;

            lblTotalUnits.Text = md.getTotalUnits().ToString();
            lblTotalSubjects.Text = md.getTotalSubjects().ToString();
            lblUnitsAllowed.Text = usersData.p_uAllowed;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            pnlAddSubject.Visible = true;
            cboSubjectBy.SelectedIndex = 0;
            dgvAddSubject.DataSource = md.dgv_showAddPreferredSubjects("Course Subject").DataSource;
            dgvAddSubject.Columns[0].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlAddSubject.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAddSubject.SelectedRows)
            {
                md.Prof_AddSubjects(row.Cells[0].Value.ToString());
                dgvListSubject.DataSource = md.dgv_showPreferredSubjects().DataSource;
                dgvListSubject.Columns[0].Visible = false;
                lblTotalUnits.Text = md.getTotalUnits().ToString();
                lblTotalSubjects.Text = md.getTotalSubjects().ToString();
                MessageBox.Show("You added " + row.Cells[2].Value.ToString() + " into your preferred subjects", "Adding of Subject");
            }
        }

        private void cboSubjectBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAddSubject.DataSource = md.dgv_showAddPreferredSubjects(cboSubjectBy.SelectedItem.ToString()).DataSource;
            dgvAddSubject.Columns[0].Visible = false;
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListSubject.SelectedRows)
            {
                string ps_id = row.Cells[0].Value.ToString();
                string s_code = row.Cells[1].Value.ToString();
                string s_desc = row.Cells[2].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete ["+ s_code + "-" +s_desc+"] from your preferred subjects?", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    dgvListSubject.DataSource = md.dgv_showPreferredSubjects().DataSource;
                    lblTotalUnits.Text = md.getTotalUnits().ToString();
                    lblTotalSubjects.Text = md.getTotalSubjects().ToString();
                    md.Prof_DeleteSubjects(ps_id);
                    MessageBox.Show("["+s_code + "-" + s_desc +"] Deleted successfully!", "Delete Subject");
                }
            }
        }
    }
}
