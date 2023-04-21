namespace Csharp
{
    partial class Frm_PictureBox_Show
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
        public void InitializeComponent()
        {
            this.pbShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbShow
            // 
            this.pbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbShow.Location = new System.Drawing.Point(0, 0);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(484, 461);
            this.pbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShow.TabIndex = 0;
            this.pbShow.TabStop = false;
            // 
            // Frm_PictureBox_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pbShow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PictureBox_Show";
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbShow;
    }
}