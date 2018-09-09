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
    public partial class InformtionControl : UserControl
    {
        public InformtionControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void InformtionControl_Load(object sender, EventArgs e)
        {
            string[] userInfo = new string[11];

            cboCourseDepartment.Items.Add("NONE");
            for (int x = 0; x < md.Sections_ListCourse().Length; x++)
                if (md.Sections_ListCourse().GetValue(x).ToString() != "")
                    cboCourseDepartment.Items.Add(md.Sections_ListCourse().GetValue(x).ToString());

            for (int x = 0; x < userInfo.Length; x++)
                userInfo[x] = md.UsersInformation(usersData.p_id).GetValue(x).ToString();

            txtFirstName.Text = userInfo[2];
            txtMiddleName.Text = userInfo[3];
            txtLastName.Text = userInfo[4];
            txtEmailAddress.Text = userInfo[5];
            txtAddress.Text = userInfo[6];
            txtMobileNumber.Text = userInfo[7];
            cboCourseDepartment.Text = userInfo[9];
            txtUsername.Text = userInfo[0];
            txtPassword.Text = ms.decryptPassword(userInfo[1]);
            txtConfirmPassword.Text = ms.decryptPassword(userInfo[1]);

            if (userInfo[8] == "Male")
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;

            if (userInfo[10] == "Fulltimer")
                rdoFulltimer.Checked = true;
            else if (userInfo[10] == "Parttimer")
                rdoParttimer.Checked = true;
            else
                rdoRetiree.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                frmProfessorHomePage php = new frmProfessorHomePage();
                string gender = (rdoMale.Checked == true) ? "Male" : "Female";
                string teachStatus = "";
                if (rdoFulltimer.Checked == true)
                    teachStatus = "Fulltimer";
                if (rdoParttimer.Checked == true)
                    teachStatus = "Parttimer";
                if (rdoRetiree.Checked == true)
                    teachStatus = "Retiree";
                md.UpdateUsersAccount(usersData.p_id, txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, gender, teachStatus, cboCourseDepartment.Text, txtEmailAddress.Text, txtMobileNumber.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}
