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
    public partial class registerControl : UserControl
    {
        public registerControl()
        {
            InitializeComponent();
        }

        private void registerControl_Load(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.isPassword = true;
        }
    }
}
