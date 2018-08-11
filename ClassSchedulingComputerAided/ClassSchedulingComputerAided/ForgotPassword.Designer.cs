namespace ClassSchedulingComputerAided
{
    partial class frmForgotPassword
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
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroLink();
            this.btnRegister = new MetroFramework.Controls.MetroLink();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnOtherWay = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(24, 64);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(277, 10);
            this.bunifuSeparator4.TabIndex = 145;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(50, 102);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 25);
            this.txtUsername.TabIndex = 147;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(11, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 25);
            this.metroLabel1.TabIndex = 146;
            this.metroLabel1.Text = "Enter username:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Location = new System.Drawing.Point(50, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 23);
            this.btnLogin.TabIndex = 148;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Want to login?";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRegister.Location = new System.Drawing.Point(50, 224);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(135, 23);
            this.btnRegister.TabIndex = 149;
            this.btnRegister.TabStop = false;
            this.btnRegister.Text = "Register?";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(50, 140);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(218, 40);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Red;
            this.btnNext.TabIndex = 150;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNext.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnOtherWay
            // 
            this.btnOtherWay.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btnOtherWay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnOtherWay.Location = new System.Drawing.Point(50, 184);
            this.btnOtherWay.Name = "btnOtherWay";
            this.btnOtherWay.Size = new System.Drawing.Size(135, 23);
            this.btnOtherWay.TabIndex = 151;
            this.btnOtherWay.TabStop = false;
            this.btnOtherWay.Text = "Try in other way?";
            this.btnOtherWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtherWay.Click += new System.EventHandler(this.btnOtherWay_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(321, 264);
            this.Controls.Add(this.btnOtherWay);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bunifuSeparator4);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmForgotPassword";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroLink btnLogin;
        public MetroFramework.Controls.MetroLink btnRegister;
        public MetroFramework.Controls.MetroTile btnNext;
        public MetroFramework.Controls.MetroLink btnOtherWay;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        public MetroFramework.Controls.MetroTextBox txtUsername;
        public MetroFramework.Controls.MetroLabel metroLabel1;
    }
}