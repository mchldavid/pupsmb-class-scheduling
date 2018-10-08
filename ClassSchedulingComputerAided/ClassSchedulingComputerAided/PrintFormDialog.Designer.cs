namespace ClassSchedulingComputerAided
{
    partial class frmPrintFormDialog
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintFormDialog));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewPrint = new MetroFramework.Controls.MetroButton();
            this.cboSelectProgram = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewPrintTimeTable = new MetroFramework.Controls.MetroButton();
            this.cboOption = new System.Windows.Forms.ComboBox();
            this.cboTimeTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.PrintDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PrintDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ClassSchedulingComputerAided.rptSubjects.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1001, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 40);
            this.panel2.TabIndex = 159;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMaximize.ImageActive")));
            this.btnMaximize.Location = new System.Drawing.Point(913, 8);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(42, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 229;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Visible = false;
            this.btnMaximize.Zoom = 10;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(950, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 229;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(14, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 28);
            this.label12.TabIndex = 138;
            this.label12.Text = "Print";
            // 
            // pnlStart
            // 
            this.pnlStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStart.BackColor = System.Drawing.Color.White;
            this.pnlStart.Controls.Add(this.groupBox1);
            this.pnlStart.Location = new System.Drawing.Point(0, 38);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(1001, 432);
            this.pnlStart.TabIndex = 160;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 440;
            this.lineShape1.X2 = 440;
            this.lineShape1.Y1 = 2;
            this.lineShape1.Y2 = 353;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 252);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(470, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 252);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewPrint
            // 
            this.btnViewPrint.Location = new System.Drawing.Point(320, 317);
            this.btnViewPrint.Name = "btnViewPrint";
            this.btnViewPrint.Size = new System.Drawing.Size(84, 24);
            this.btnViewPrint.TabIndex = 180;
            this.btnViewPrint.Text = "VIEW PRINT";
            this.btnViewPrint.Click += new System.EventHandler(this.btnViewPrint_Click);
            // 
            // cboSelectProgram
            // 
            this.cboSelectProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectProgram.FormattingEnabled = true;
            this.cboSelectProgram.Location = new System.Drawing.Point(156, 317);
            this.cboSelectProgram.Name = "cboSelectProgram";
            this.cboSelectProgram.Size = new System.Drawing.Size(158, 24);
            this.cboSelectProgram.TabIndex = 247;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 248;
            this.label1.Text = "Select Program:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnViewPrintTimeTable
            // 
            this.btnViewPrintTimeTable.Location = new System.Drawing.Point(783, 317);
            this.btnViewPrintTimeTable.Name = "btnViewPrintTimeTable";
            this.btnViewPrintTimeTable.Size = new System.Drawing.Size(84, 24);
            this.btnViewPrintTimeTable.TabIndex = 180;
            this.btnViewPrintTimeTable.Text = "VIEW PRINT";
            // 
            // cboOption
            // 
            this.cboOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOption.Enabled = false;
            this.cboOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Location = new System.Drawing.Point(619, 317);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(158, 24);
            this.cboOption.TabIndex = 247;
            this.cboOption.SelectedIndexChanged += new System.EventHandler(this.cboOption_SelectedIndexChanged);
            // 
            // cboTimeTable
            // 
            this.cboTimeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimeTable.FormattingEnabled = true;
            this.cboTimeTable.Location = new System.Drawing.Point(619, 287);
            this.cboTimeTable.Name = "cboTimeTable";
            this.cboTimeTable.Size = new System.Drawing.Size(158, 24);
            this.cboTimeTable.TabIndex = 247;
            this.cboTimeTable.SelectedIndexChanged += new System.EventHandler(this.cboTimeTable_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(467, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 248;
            this.label3.Text = "Select Time Table:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboOption);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnViewPrint);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.cboSelectProgram);
            this.groupBox1.Controls.Add(this.btnViewPrintTimeTable);
            this.groupBox1.Controls.Add(this.cboTimeTable);
            this.groupBox1.Controls.Add(this.shapeContainer2);
            this.groupBox1.Location = new System.Drawing.Point(58, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 383);
            this.groupBox1.TabIndex = 249;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview Setup";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(891, 364);
            this.shapeContainer2.TabIndex = 249;
            this.shapeContainer2.TabStop = false;
            // 
            // PrintDataBindingSource
            // 
            this.PrintDataBindingSource.DataSource = typeof(ClassSchedulingComputerAided.PrintData);
            // 
            // frmPrintFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 469);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPrintFormDialog";
            this.Load += new System.EventHandler(this.PrintFormDialog_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrintDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PrintDataBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public MetroFramework.Controls.MetroButton btnViewPrint;
        private System.Windows.Forms.ComboBox cboSelectProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTimeTable;
        private System.Windows.Forms.ComboBox cboOption;
        public MetroFramework.Controls.MetroButton btnViewPrintTimeTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}