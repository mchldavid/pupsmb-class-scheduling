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
    public partial class frmReport : MetroFramework.Forms.MetroForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            SummaryControl sc = new SummaryControl();
            pnlReport.Controls.Add(sc);
            btnClose.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmAdminHomePage ahp = new frmAdminHomePage();
            ahp.Show();
            this.Hide();
        }
    }
}
