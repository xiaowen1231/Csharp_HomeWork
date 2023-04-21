namespace Csharp
{
    partial class Frm_HomeWork_Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HomeWork_Hello));
            this.labName = new System.Windows.Forms.Label();
            this.labEnName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labStar = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(119, 37);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(45, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labEnName
            // 
            this.labEnName.AutoSize = true;
            this.labEnName.BackColor = System.Drawing.Color.Transparent;
            this.labEnName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnName.Location = new System.Drawing.Point(119, 82);
            this.labEnName.Name = "labEnName";
            this.labEnName.Size = new System.Drawing.Size(117, 20);
            this.labEnName.TabIndex = 1;
            this.labEnName.Text = "English Name:";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.Location = new System.Drawing.Point(119, 129);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(45, 20);
            this.labGender.TabIndex = 2;
            this.labGender.Text = "性別:";
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.BackColor = System.Drawing.Color.Transparent;
            this.labStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStar.Location = new System.Drawing.Point(119, 181);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(45, 20);
            this.labStar.TabIndex = 3;
            this.labStar.Text = "星座:";
            // 
            // btnHello
            // 
            this.btnHello.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHello.BackgroundImage")));
            this.btnHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(123, 230);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(114, 43);
            this.btnHello.TabIndex = 4;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHi.BackgroundImage")));
            this.btnHi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(265, 230);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(114, 43);
            this.btnHi.TabIndex = 5;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(279, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtEnName
            // 
            this.txtEnName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnName.Location = new System.Drawing.Point(279, 80);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(100, 27);
            this.txtEnName.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(279, 132);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 27);
            this.txtGender.TabIndex = 8;
            // 
            // txtStar
            // 
            this.txtStar.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStar.Location = new System.Drawing.Point(279, 179);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(100, 27);
            this.txtStar.TabIndex = 9;
            // 
            // Frm_HomeWork_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp.Properties.Resources.背景3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 319);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.labStar);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEnName);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HomeWork_Hello";
            this.Text = "Frm_HomeWork_Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labEnName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labStar;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtStar;
    }
}