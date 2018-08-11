namespace ClassSchedulingComputerAided
{
    partial class frmCreateCurriculum
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
            this.txtCurriculumTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPublishedBy = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.rdoActive = new MetroFramework.Controls.MetroCheckBox();
            this.dtpDatePublished = new Bunifu.Framework.UI.BunifuDatepicker();
            this.rdoUsed = new MetroFramework.Controls.MetroCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurriculumTitle
            // 
            this.txtCurriculumTitle.Location = new System.Drawing.Point(157, 63);
            this.txtCurriculumTitle.Name = "txtCurriculumTitle";
            this.txtCurriculumTitle.Size = new System.Drawing.Size(286, 25);
            this.txtCurriculumTitle.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(15, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Curriculum Title:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(15, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(136, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Date Published:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(15, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(136, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Published by:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPublishedBy
            // 
            this.txtPublishedBy.Location = new System.Drawing.Point(157, 99);
            this.txtPublishedBy.Name = "txtPublishedBy";
            this.txtPublishedBy.Size = new System.Drawing.Size(251, 25);
            this.txtPublishedBy.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 153;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(359, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 156;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rdoActive
            // 
            this.rdoActive.Checked = true;
            this.rdoActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdoActive.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.rdoActive.Location = new System.Drawing.Point(157, 166);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(104, 24);
            this.rdoActive.Style = MetroFramework.MetroColorStyle.Red;
            this.rdoActive.TabIndex = 157;
            this.rdoActive.Text = "Acitve";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.BackColor = System.Drawing.SystemColors.Control;
            this.dtpDatePublished.BorderRadius = 0;
            this.dtpDatePublished.ForeColor = System.Drawing.Color.Black;
            this.dtpDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDatePublished.FormatCustom = null;
            this.dtpDatePublished.Location = new System.Drawing.Point(156, 135);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(252, 25);
            this.dtpDatePublished.TabIndex = 158;
            this.dtpDatePublished.Value = new System.DateTime(2018, 7, 24, 16, 9, 36, 981);
            // 
            // rdoUsed
            // 
            this.rdoUsed.Checked = true;
            this.rdoUsed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdoUsed.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.rdoUsed.Location = new System.Drawing.Point(253, 166);
            this.rdoUsed.Name = "rdoUsed";
            this.rdoUsed.Size = new System.Drawing.Size(210, 24);
            this.rdoUsed.Style = MetroFramework.MetroColorStyle.Red;
            this.rdoUsed.TabIndex = 159;
            this.rdoUsed.Text = "Set as default curriculum";
            this.rdoUsed.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 46);
            this.panel1.TabIndex = 240;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(22, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 241;
            this.label7.Text = "Create Curriculum";
            // 
            // frmCreateCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(476, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoUsed);
            this.Controls.Add(this.dtpDatePublished);
            this.Controls.Add(this.rdoActive);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPublishedBy);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCurriculumTitle);
            this.Controls.Add(this.metroLabel1);
            this.Movable = false;
            this.Name = "frmCreateCurriculum";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.CreateCurriculum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton btnSave;
        public MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroTextBox txtCurriculumTitle;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox txtPublishedBy;
        public MetroFramework.Controls.MetroCheckBox rdoActive;
        public Bunifu.Framework.UI.BunifuDatepicker dtpDatePublished;
        public MetroFramework.Controls.MetroCheckBox rdoUsed;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label7;
    }
}