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
            if (md.S_sectionExisting(cboSelectCourse.Text, cboSelectYear.Text) == true)
            {
                DialogResult result = MessageBox.Show("The course:[" + cboSelectCourse.Text + "] year:[" + cboSelectYear.Text + "] is already on your list. Do you to delete to proceed?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    md.S_DeleteExistingSections(cboSelectCourse.Text, cboSelectYear.Text);
                    for (int x = 1; x <= Convert.ToInt32(txtNumberOfSection.Text); x++)
                        md.S_AddSections(cboSelectCourse.SelectedItem.ToString(), cboSelectYear.SelectedItem.ToString(), x.ToString());
                    txtNumberOfSection.Text = "";
                    dgvShowSections.DataSource = md.dgv_showSections().DataSource;
                    dgvShowSections.Columns[0].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Generate Section/s successful", "Add Section", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int x = 1; x <= Convert.ToInt32(txtNumberOfSection.Text); x++)
                    md.S_AddSections(cboSelectCourse.SelectedItem.ToString(), cboSelectYear.SelectedItem.ToString(), x.ToString());
                txtNumberOfSection.Text = "";
                dgvShowSections.DataSource = md.dgv_showSections().DataSource;
                dgvShowSections.Columns[0].Visible = false;
            }
        }

        private void sectionsControl_Load(object sender, EventArgs e)
        {
            dgvShowSections.DataSource = md.dgv_showSections().DataSource;
            dgvShowSections.Columns[0].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvShowSections.SelectedRows)
            {
                string section = dr.Cells[1].Value.ToString() 
                    + " " + dr.Cells[2].Value.ToString() 
                    + "-" + dr.Cells[3].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to delete: " + section + "?", "Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    md.S_DeleteSections(dr.Cells[0].Value.ToString());
                    dgvShowSections.DataSource = md.dgv_showSections().DataSource;
                    dgvShowSections.Columns[0].Visible = false;
                }
            }
        }

        private void cboSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumberOfSection.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvShowSections.DataSource = md.dgv_SearchSections(txtSearch.Text).DataSource;
            dgvShowSections.Columns[0].Visible = false;
        }
    }
}
