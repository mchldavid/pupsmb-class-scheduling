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
    public partial class sectionsControl : UserControl
    {
        public sectionsControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int x = 1; x <= Convert.ToInt32(txtNumberOfSection.Text); x++)
                md.S_AddSections(cboSelectCourse.SelectedItem.ToString(), cboSelectYear.SelectedItem.ToString(), x.ToString());
            txtNumberOfSection.Text = "";
            dgvShowSections.DataSource = md.dgv_showSections().DataSource;
        }

        private void sectionsControl_Load(object sender, EventArgs e)
        {
            dgvShowSections.DataSource = md.dgv_showSections().DataSource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvShowSections.SelectedRows)
            {
                md.S_DeleteSections(dr.Cells[0].Value.ToString());
                dgvShowSections.DataSource = md.dgv_showSections().DataSource;
            }
        }
    }
}
