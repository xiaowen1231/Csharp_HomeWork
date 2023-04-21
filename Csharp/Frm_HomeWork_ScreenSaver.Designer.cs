namespace Csharp
{
    partial class Frm_HomeWork_ScreenSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HomeWork_ScreenSaver));
            this.pbScreenImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScreenImage
            // 
            this.pbScreenImage.BackColor = System.Drawing.SystemColors.Window;
            this.pbScreenImage.Image = ((System.Drawing.Image)(resources.GetObject("pbScreenImage.Image")));
            this.pbScreenImage.Location = new System.Drawing.Point(12, 0);
            this.pbScreenImage.Name = "pbScreenImage";
            this.pbScreenImage.Size = new System.Drawing.Size(500, 281);
            this.pbScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbScreenImage.TabIndex = 0;
            this.pbScreenImage.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_HomeWork_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbScreenImage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_HomeWork_ScreenSaver";
            this.Text = "Frm_HomeWork_ScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_HomeWork_ScreenSaver_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_HomeWork_ScreenSaver_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_HomeWork_ScreenSaver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScreenImage;
        private System.Windows.Forms.Timer timer1;
    }
}