namespace ClassSchedulingComputerAided
{
    partial class frmCreateProgram
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoActive = new MetroFramework.Controls.MetroCheckBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.txtProgramAcronym = new System.Windows.Forms.TextBox();
            this.txtCurriculumYear = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 38);
            this.panel1.TabIndex = 251;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(13, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 23);
            this.label7.TabIndex = 241;
            this.label7.Text = "Create Program";
            // 
            // rdoActive
            // 
            this.rdoActive.Checked = true;
            this.rdoActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdoActive.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.rdoActive.Location = new System.Drawing.Point(158, 164);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(104, 24);
            this.rdoActive.Style = MetroFramework.MetroColorStyle.Red;
            this.rdoActive.TabIndex = 6;
            this.rdoActive.Text = "Active";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(360, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(270, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(16, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(136, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Curriculum Year:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(16, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(136, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Program Acronym:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(16, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Program Name:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProgramName
            // 
            this.txtProgramName.BackColor = System.Drawing.Color.White;
            this.txtProgramName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramName.Location = new System.Drawing.Point(158, 64);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(286, 22);
            this.txtProgramName.TabIndex = 1;
            // 
            // txtProgramAcronym
            // 
            this.txtProgramAcronym.BackColor = System.Drawing.Color.White;
            this.txtProgramAcronym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProgramAcronym.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramAcronym.Location = new System.Drawing.Point(158, 100);
            this.txtProgramAcronym.Name = "txtProgramAcronym";
            this.txtProgramAcronym.Size = new System.Drawing.Size(286, 22);
            this.txtProgramAcronym.TabIndex = 3;
            this.txtProgramAcronym.TextChanged += new System.EventHandler(this.txtProgramAcronym_TextChanged);
            // 
            // txtCurriculumYear
            // 
            this.txtCurriculumYear.BackColor = System.Drawing.Color.White;
            this.txtCurriculumYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurriculumYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurriculumYear.Location = new System.Drawing.Point(158, 136);
            this.txtCurriculumYear.Name = "txtCurriculumYear";
            this.txtCurriculumYear.Size = new System.Drawing.Size(286, 22);
            this.txtCurriculumYear.TabIndex = 5;
            this.txtCurriculumYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurriculumYear_KeyPress);
            // 
            // frmCreateProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 258);
            this.Controls.Add(this.txtCurriculumYear);
            this.Controls.Add(this.txtProgramAcronym);
            this.Controls.Add(this.txtProgramName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoActive);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmCreateProgram";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.CreateProgram_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label7;
        public MetroFramework.Controls.MetroCheckBox rdoActive;
        public MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSave;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.TextBox txtProgramName;
        public System.Windows.Forms.TextBox txtProgramAcronym;
        public System.Windows.Forms.TextBox txtCurriculumYear;
    }
}