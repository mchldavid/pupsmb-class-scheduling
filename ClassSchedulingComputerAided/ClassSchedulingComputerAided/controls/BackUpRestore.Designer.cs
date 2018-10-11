namespace ClassSchedulingComputerAided
{
    partial class BackUpRestore
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBackup = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseBackup = new MetroFramework.Controls.MetroButton();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
            this.btnRestore = new MetroFramework.Controls.MetroButton();
            this.btnBrowseRestore = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlConfirmation = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlConfirmation.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.BackColor = System.Drawing.Color.White;
            this.txtBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupPath.Enabled = false;
            this.txtBackupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupPath.Location = new System.Drawing.Point(160, 55);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(387, 26);
            this.txtBackupPath.TabIndex = 243;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(460, 83);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(87, 29);
            this.btnBackup.TabIndex = 244;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(157, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 18);
            this.label6.TabIndex = 245;
            this.label6.Text = "Browse the location for backup database.";
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Location = new System.Drawing.Point(67, 55);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(87, 26);
            this.btnBrowseBackup.TabIndex = 244;
            this.btnBrowseBackup.Text = "BROWSE";
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.BackColor = System.Drawing.Color.White;
            this.txtRestorePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestorePath.Enabled = false;
            this.txtRestorePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestorePath.Location = new System.Drawing.Point(160, 65);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.Size = new System.Drawing.Size(387, 26);
            this.txtRestorePath.TabIndex = 243;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(460, 93);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(87, 29);
            this.btnRestore.TabIndex = 244;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.Location = new System.Drawing.Point(67, 65);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.Size = new System.Drawing.Size(87, 26);
            this.btnBrowseRestore.TabIndex = 244;
            this.btnBrowseRestore.Text = "BROWSE";
            this.btnBrowseRestore.Click += new System.EventHandler(this.btnBrowseRestore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 18);
            this.label1.TabIndex = 245;
            this.label1.Text = "Open the location to restore database.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 31);
            this.panel1.TabIndex = 252;
            // 
            // metroLabel2
            // 
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.Location = new System.Drawing.Point(10, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 21);
            this.metroLabel2.TabIndex = 135;
            this.metroLabel2.Text = "Back up and Restore database";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseBackup);
            this.groupBox1.Controls.Add(this.txtBackupPath);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 142);
            this.groupBox1.TabIndex = 253;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Backup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRestorePath);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.btnBrowseRestore);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 151);
            this.groupBox2.TabIndex = 254;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Restore";
            // 
            // pnlConfirmation
            // 
            this.pnlConfirmation.BackColor = System.Drawing.Color.DimGray;
            this.pnlConfirmation.Controls.Add(this.panel3);
            this.pnlConfirmation.Controls.Add(this.panel4);
            this.pnlConfirmation.Location = new System.Drawing.Point(181, 135);
            this.pnlConfirmation.Name = "pnlConfirmation";
            this.pnlConfirmation.Size = new System.Drawing.Size(315, 198);
            this.pnlConfirmation.TabIndex = 255;
            this.pnlConfirmation.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 31);
            this.panel3.TabIndex = 253;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.Location = new System.Drawing.Point(10, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(198, 21);
            this.metroLabel1.TabIndex = 135;
            this.metroLabel1.Text = "Confirmation";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnOk);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Location = new System.Drawing.Point(3, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 166);
            this.panel4.TabIndex = 254;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 245;
            this.label2.Text = "Enter your password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(32, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(248, 26);
            this.txtPassword.TabIndex = 243;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(100, 113);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 29);
            this.btnOk.TabIndex = 244;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 29);
            this.btnCancel.TabIndex = 244;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BackUpRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlConfirmation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "BackUpRestore";
            this.Size = new System.Drawing.Size(700, 473);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlConfirmation.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackupPath;
        public MetroFramework.Controls.MetroButton btnBackup;
        public System.Windows.Forms.Label label6;
        public MetroFramework.Controls.MetroButton btnBrowseBackup;
        private System.Windows.Forms.TextBox txtRestorePath;
        public MetroFramework.Controls.MetroButton btnRestore;
        public MetroFramework.Controls.MetroButton btnBrowseRestore;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlConfirmation;
        private System.Windows.Forms.Panel panel3;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnOk;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
