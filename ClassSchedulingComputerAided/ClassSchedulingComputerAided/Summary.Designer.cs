namespace ClassSchedulingComputerAided
{
    partial class frmSummary
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCtrl_Students = new System.Windows.Forms.TabControl();
            this.Students = new System.Windows.Forms.TabPage();
            this.Professors = new System.Windows.Forms.TabPage();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.pnlRoomSummary = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tbCtrl_Students.SuspendLayout();
            this.Rooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 32);
            this.panel2.TabIndex = 159;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 23);
            this.label12.TabIndex = 138;
            this.label12.Text = "Summary Report!";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tbCtrl_Students
            // 
            this.tbCtrl_Students.Controls.Add(this.Students);
            this.tbCtrl_Students.Controls.Add(this.Professors);
            this.tbCtrl_Students.Controls.Add(this.Rooms);
            this.tbCtrl_Students.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCtrl_Students.Location = new System.Drawing.Point(7, 37);
            this.tbCtrl_Students.Name = "tbCtrl_Students";
            this.tbCtrl_Students.SelectedIndex = 0;
            this.tbCtrl_Students.Size = new System.Drawing.Size(904, 622);
            this.tbCtrl_Students.TabIndex = 160;
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.White;
            this.Students.Location = new System.Drawing.Point(4, 29);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(3);
            this.Students.Size = new System.Drawing.Size(896, 589);
            this.Students.TabIndex = 0;
            this.Students.Text = "Students";
            // 
            // Professors
            // 
            this.Professors.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Professors.Location = new System.Drawing.Point(4, 29);
            this.Professors.Name = "Professors";
            this.Professors.Padding = new System.Windows.Forms.Padding(3);
            this.Professors.Size = new System.Drawing.Size(896, 589);
            this.Professors.TabIndex = 1;
            this.Professors.Text = "Professors";
            this.Professors.UseVisualStyleBackColor = true;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.label1);
            this.Rooms.Controls.Add(this.cboRoom);
            this.Rooms.Controls.Add(this.pnlRoomSummary);
            this.Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Rooms.Location = new System.Drawing.Point(4, 29);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(896, 589);
            this.Rooms.TabIndex = 2;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 246;
            this.label1.Text = "Select Room:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(112, 4);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(169, 25);
            this.cboRoom.TabIndex = 10;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboCourseDepartment_SelectedIndexChanged);
            // 
            // pnlRoomSummary
            // 
            this.pnlRoomSummary.Location = new System.Drawing.Point(38, 29);
            this.pnlRoomSummary.Name = "pnlRoomSummary";
            this.pnlRoomSummary.Size = new System.Drawing.Size(820, 561);
            this.pnlRoomSummary.TabIndex = 248;
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 672);
            this.Controls.Add(this.tbCtrl_Students);
            this.Controls.Add(this.panel2);
            this.Name = "frmSummary";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Summary_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbCtrl_Students.ResumeLayout(false);
            this.Rooms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tbCtrl_Students;
        private System.Windows.Forms.TabPage Students;
        private System.Windows.Forms.TabPage Professors;
        private System.Windows.Forms.TabPage Rooms;
        public System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRoomSummary;
    }
}