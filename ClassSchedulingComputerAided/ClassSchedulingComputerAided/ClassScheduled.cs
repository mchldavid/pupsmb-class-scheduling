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
    public partial class frmClassScheduled : MetroFramework.Forms.MetroForm
    {
        public frmClassScheduled()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void ClassScheduled_Load(object sender, EventArgs e)
        {
            ClassScheduledProfessorControl cspc = new ClassScheduledProfessorControl();
            pnl.Controls.Add(cspc);

            btnHome.BringToFront();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmProfessorHomePage php = new frmProfessorHomePage();
            this.Hide();
            php.Show();
        }
    }
}
