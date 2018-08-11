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
            lblTotalUnits.Text = md.getTotalUnits().ToString();
            lblUnitsAllowed.Text = usersData.p_uAllowed;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            pnlAddSubject.Visible = true;
            cboSubjectBy.SelectedIndex = 0;
            dgvAddSubject.DataSource = md.dgv_showAddPreferredSubjects("Course Subject").DataSource;
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
                lblTotalUnits.Text = md.getTotalUnits().ToString();
                MessageBox.Show("You added " + row.Cells[2].Value.ToString() + " into your preferred subjects", "Adding of Subject");
            }
        }

        private void cboSubjectBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAddSubject.DataSource = md.dgv_showAddPreferredSubjects(cboSubjectBy.SelectedItem.ToString()).DataSource;
        }
    }
}
