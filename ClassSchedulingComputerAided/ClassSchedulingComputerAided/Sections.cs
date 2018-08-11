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
    public partial class frmSections : MetroFramework.Forms.MetroForm
    {
        public frmSections()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void Sections_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminHomePage a = new frmAdminHomePage();
            a.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for(int x = 1; x <= Convert.ToInt32(txtNumberOfSection.Text); x++)
                md.S_AddSections(cboSelectCourse.SelectedItem.ToString(), cboSelectYear.SelectedItem.ToString(), x.ToString());
        }
    }
}
