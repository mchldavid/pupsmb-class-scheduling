namespace ClassSchedulingComputerAided
{
    partial class frmSecurityQuestions
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
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtAnswer1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAnswer2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtAnswer3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.btnSubmit = new MetroFramework.Controls.MetroTile();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 64);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(358, 10);
            this.bunifuSeparator1.TabIndex = 102;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(23, 99);
            this.txtAnswer1.Multiline = true;
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.PasswordChar = '*';
            this.txtAnswer1.Size = new System.Drawing.Size(343, 25);
            this.txtAnswer1.TabIndex = 104;
            // 
            // metroLabel9
            // 
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(16, 76);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(229, 25);
            this.metroLabel9.TabIndex = 103;
            this.metroLabel9.Text = "1. What is your favorite number?";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(23, 147);
            this.txtAnswer2.Multiline = true;
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.PasswordChar = '*';
            this.txtAnswer2.Size = new System.Drawing.Size(343, 25);
            this.txtAnswer2.TabIndex = 106;
            // 
            // metroLabel10
            // 
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(15, 124);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(186, 25);
            this.metroLabel10.TabIndex = 105;
            this.metroLabel10.Text = "2. What is your pet name?";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(23, 193);
            this.txtAnswer3.Multiline = true;
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.PasswordChar = '*';
            this.txtAnswer3.Size = new System.Drawing.Size(343, 25);
            this.txtAnswer3.TabIndex = 108;
            // 
            // metroLabel18
            // 
            this.metroLabel18.CustomBackground = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.Location = new System.Drawing.Point(15, 170);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(215, 25);
            this.metroLabel18.TabIndex = 107;
            this.metroLabel18.Text = "3. What is your favorite color?";
            this.metroLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(23, 229);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(343, 40);
            this.btnSubmit.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSubmit.TabIndex = 157;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSubmit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 158;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(391, 348);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.bunifuSeparator1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmSecurityQuestions";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Security Questions";
            this.Load += new System.EventHandler(this.SecurityQuestions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroTextBox txtAnswer1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtAnswer2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtAnswer3;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        public MetroFramework.Controls.MetroTile btnSubmit;
        private MetroFramework.Controls.MetroButton btnCancel;
    }
}