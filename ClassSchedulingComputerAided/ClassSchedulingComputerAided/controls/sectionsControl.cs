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
            if (cboSelectCourse.Text != "" && cboSelectYear.Text != "" && txtNumberOfSection.Text != "")
            {
                if (md.S_sectionExisting(cboSelectCourse.Text, cboSelectYear.Text) == true)//if the year is existing
                {
                    MessageBox.Show(txtNumberOfSection.Text + " section(s) generated in course:[ " + cboSelectCourse.Text + " ] year:[ " + cboSelectYear.Text + " ]", "Generate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    md.S_DeleteExistingSections(cboSelectCourse.Text, cboSelectYear.Text);
                    for (int x = 1; x <= Convert.ToInt32(txtNumberOfSection.Text); x++)
                        md.S_AddSections(cboSelectCourse.SelectedItem.ToString(), cboSelectYear.SelectedItem.ToString(), x.ToString());

                    dgvShowSections.DataSource = md.dgv_showSections().DataSource;
                    dgvShowSections.Columns[0].Visible = false;

                    //audit
                    md.AuditTrail(AuditTrailData.username, "Add", cboSelectCourse.Text + " year "+cboSelectYear.Text+" generate "+txtNumberOfSection.Text+" section/s.");
                    txtNumberOfSection.Text = "";
                }
                else
                {
                    MessageBox.Show(txtNumberOfSection.Text + " section(s) generated in course:[ " + cboSelectCourse.Text + " ] year:[ " + cboSelectYear.Text + " ]", "Generate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int x = 1; x <= Convert.ToInt32(txtNumberOfSection.Text); x++)
                        md.S_AddSections(cboSelectCourse.SelectedItem.ToString(), cboSelectYear.SelectedItem.ToString(), x.ToString());
                    
                    dgvShowSections.DataSource = md.dgv_showSections().DataSource;
                    dgvShowSections.Columns[0].Visible = false;

                    //audit
                    md.AuditTrail(AuditTrailData.username, "Add", cboSelectCourse.Text + " year " + cboSelectYear.Text + " generate " + txtNumberOfSection.Text + " section/s.");
                    txtNumberOfSection.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fill all fields are required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    //audit
                    md.AuditTrail(AuditTrailData.username, "Delete", section + " was remove.");
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

        private void txtNumberOfSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
