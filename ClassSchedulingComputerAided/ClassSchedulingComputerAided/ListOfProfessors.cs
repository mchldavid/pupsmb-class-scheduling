﻿using System;
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
    public partial class frmListOfProfessors : MetroFramework.Forms.MetroForm
    {
        public frmListOfProfessors()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void ListOfProfessors_Load(object sender, EventArgs e)
        {
            dgvShow.DataSource = md.dgv_showListOfProfessors().DataSource;
            dgvShow.Columns[0].Visible = false;

            cboBy.Items.Add("Name");
            cboBy.Items.Add("Teaching Status");
            cboBy.Items.Add("Email");
            cboBy.SelectedIndex = 0;
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form ahp = new frmAdminHomePage();
            ahp.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfessorClose_Click(object sender, EventArgs e)
        {
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
        }

        private void btnEditProfessor_Click(object sender, EventArgs e)
        {
            frmEditProfessor p = new frmEditProfessor();
            p.Show();
        }

        private void btnEditProfessors_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvShow.SelectedRows)
            {
                ListOfProfessorsData.Selected_ID = dr.Cells[0].Value.ToString();
                ListOfProfessorsData.Selected_Prof = dr.Cells[1].Value.ToString();
                L_EditProfessorsControl l = new L_EditProfessorsControl();
                pnlShowUserControl.Controls.Clear();
                pnlShowUserControl.Controls.Add(l);
                pnlShowUserControl.Visible = true;
                pnlShowUserControl.BringToFront();
                btnCancel.Visible = true;
                btnCancel.BringToFront();
            }
        }

        private void btnDeleteProfessors_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvShow.SelectedRows)
            {
                ListOfProfessorsData.Selected_ID = dr.Cells[0].Value.ToString();
                string name = dr.Cells[1].Value.ToString();
                DialogResult result =  MessageBox.Show("Are you sure you want to delete '"+ name +"' on the list?", "Delete Professor", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    //audit
                    md.AuditTrail(AuditTrailData.username, "Delete", dr.Cells[1].Value.ToString() +" was remove.");

                    md.L_DeleteProfessor(ListOfProfessorsData.Selected_ID);
                    dgvShow.DataSource = md.dgv_showListOfProfessors().DataSource;
                    dgvShow.Columns[0].Visible = false;
                    MessageBox.Show("Account deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pnlShowUserControl.Controls.Clear();
                    pnlShowUserControl.Visible = false;
                    btnCancel.Visible = false;

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvShow.DataSource = md.dgv_showListOfProfessors().DataSource;
            dgvShow.Columns[0].Visible = false;
            pnlShowUserControl.Controls.Clear();
            pnlShowUserControl.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form ahp = new frmAdminHomePage();
            ahp.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnProfessorsInfo_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvShow.DataSource = md.dgv_SearchListProfessors(txtSearch.Text, cboBy.Text).DataSource;
            dgvShow.Columns[0].Visible = false;
        }
    }
}
