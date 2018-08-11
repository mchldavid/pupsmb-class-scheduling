namespace ClassSchedulingComputerAided
{
    partial class frmMyAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cboGender = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMiddleName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtMobileNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(334, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 180;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 179;
            this.btnSave.Text = "SAVE";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.ItemHeight = 23;
            this.cboGender.Location = new System.Drawing.Point(167, 173);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(169, 29);
            this.cboGender.TabIndex = 177;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Location = new System.Drawing.Point(28, 173);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(133, 25);
            this.metroLabel11.TabIndex = 176;
            this.metroLabel11.Text = "Gender:";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 50);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(401, 23);
            this.bunifuSeparator1.TabIndex = 174;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(167, 290);
            this.txtEmailAddress.Multiline = true;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(206, 25);
            this.txtEmailAddress.TabIndex = 160;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(49, 290);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 25);
            this.metroLabel8.TabIndex = 159;
            this.metroLabel8.Text = "Email Address:";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(167, 435);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(169, 25);
            this.txtConfirmPassword.TabIndex = 170;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(41, 435);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(120, 25);
            this.metroLabel7.TabIndex = 173;
            this.metroLabel7.Text = "Confirm Password:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 404);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(169, 25);
            this.txtPassword.TabIndex = 169;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(68, 404);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 25);
            this.metroLabel5.TabIndex = 172;
            this.metroLabel5.Text = "Password:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(167, 373);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(169, 25);
            this.txtUsername.TabIndex = 168;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(68, 371);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 25);
            this.metroLabel6.TabIndex = 171;
            this.metroLabel6.Text = "Username:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 226);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(206, 58);
            this.txtAddress.TabIndex = 158;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(68, 226);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 25);
            this.metroLabel4.TabIndex = 157;
            this.metroLabel4.Text = "Address:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(167, 142);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 25);
            this.txtLastName.TabIndex = 156;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(68, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 25);
            this.metroLabel3.TabIndex = 155;
            this.metroLabel3.Text = "Last Name:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(167, 111);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(169, 25);
            this.txtMiddleName.TabIndex = 154;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(68, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 25);
            this.metroLabel2.TabIndex = 153;
            this.metroLabel2.Text = "Middle Name:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(167, 80);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 25);
            this.txtFirstName.TabIndex = 152;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(68, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 25);
            this.metroLabel1.TabIndex = 151;
            this.metroLabel1.Text = "First Name:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(167, 321);
            this.txtMobileNumber.Multiline = true;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(179, 25);
            this.txtMobileNumber.TabIndex = 182;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Location = new System.Drawing.Point(38, 321);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(125, 25);
            this.metroLabel9.TabIndex = 181;
            this.metroLabel9.Text = "Mobile Number:";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(442, 523);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.metroLabel1);
            this.Movable = false;
            this.Name = "frmMyAccount";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cboGender;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroTextBox txtEmailAddress;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMiddleName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtMobileNumber;
        private MetroFramework.Controls.MetroLabel metroLabel9;

    }
}