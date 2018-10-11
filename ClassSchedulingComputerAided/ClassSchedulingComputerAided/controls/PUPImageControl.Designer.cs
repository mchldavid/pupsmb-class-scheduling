namespace ClassSchedulingComputerAided
{
    partial class PUPImageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PUPImageControl));
            this.pbPupImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPupImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPupImage
            // 
            this.pbPupImage.Image = ((System.Drawing.Image)(resources.GetObject("pbPupImage.Image")));
            this.pbPupImage.Location = new System.Drawing.Point(0, 0);
            this.pbPupImage.Name = "pbPupImage";
            this.pbPupImage.Size = new System.Drawing.Size(700, 473);
            this.pbPupImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPupImage.TabIndex = 0;
            this.pbPupImage.TabStop = false;
            // 
            // PUPImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPupImage);
            this.Name = "PUPImageControl";
            this.Size = new System.Drawing.Size(700, 473);
            ((System.ComponentModel.ISupportInitialize)(this.pbPupImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPupImage;
    }
}
