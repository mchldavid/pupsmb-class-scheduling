namespace ClassSchedulingComputerAided
{
    partial class frmCurriculum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCurriculum = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 347);
            this.panel1.TabIndex = 144;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(-7, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 55);
            this.panel2.TabIndex = 158;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(14, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 28);
            this.label12.TabIndex = 138;
            this.label12.Text = "Curriculums";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCurriculum);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 265);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Curriculum";
            // 
            // dgvCurriculum
            // 
            this.dgvCurriculum.AllowUserToAddRows = false;
            this.dgvCurriculum.AllowUserToDeleteRows = false;
            this.dgvCurriculum.AllowUserToResizeColumns = false;
            this.dgvCurriculum.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvCurriculum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurriculum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurriculum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCurriculum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCurriculum.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurriculum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCurriculum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurriculum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurriculum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurriculum.DoubleBuffered = true;
            this.dgvCurriculum.EnableHeadersVisualStyles = false;
            this.dgvCurriculum.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCurriculum.HeaderBgColor = System.Drawing.Color.Brown;
            this.dgvCurriculum.HeaderForeColor = System.Drawing.Color.Gold;
            this.dgvCurriculum.Location = new System.Drawing.Point(6, 19);
            this.dgvCurriculum.Name = "dgvCurriculum";
            this.dgvCurriculum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCurriculum.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCurriculum.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurriculum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurriculum.Size = new System.Drawing.Size(428, 240);
            this.dgvCurriculum.TabIndex = 156;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(473, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex = 155;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(473, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 155;
            this.btnDelete.Text = "DELETE";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(473, 74);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 32);
            this.btnCreate.TabIndex = 152;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(473, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 151;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(581, 345);
            this.Controls.Add(this.panel1);
            this.Movable = false;
            this.Name = "frmCurriculum";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Curriculum_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton btnCreate;
        public MetroFramework.Controls.MetroButton btnEdit;
        public MetroFramework.Controls.MetroButton btnDelete;
        public MetroFramework.Controls.MetroButton btnCancel;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCurriculum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;

    }
}