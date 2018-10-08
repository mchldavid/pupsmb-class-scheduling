using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClassSchedulingComputerAided
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void Print_Load(object sender, EventArgs e)
        {
            
            dgvPrint.DataSource = md.dgv_showSubjectCurriculum().DataSource;
        }

        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < dgvPrint.Rows.Count - 1; i++)
            {
                string subjectCode = dgvPrint.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
