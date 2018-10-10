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
    public partial class EventLogControl : UserControl
    {
        public EventLogControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void EventLogControl_Load(object sender, EventArgs e)
        {
            eventlogBindingSource.DataSource = md.dgv_AuditTrail().DataSource;
        }
    }
}
