namespace Csharp
{
    partial class Frm_HomeWork_Alarm
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
            this.labTime = new System.Windows.Forms.Label();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.cbSet = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labAlarm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTime.Location = new System.Drawing.Point(39, 40);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(54, 26);
            this.labTime.TabIndex = 0;
            this.labTime.Text = "時間";
            // 
            // timerNow
            // 
            this.timerNow.Enabled = true;
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // gbTitle
            // 
            this.gbTitle.AutoSize = true;
            this.gbTitle.Controls.Add(this.textBox3);
            this.gbTitle.Controls.Add(this.textBox2);
            this.gbTitle.Controls.Add(this.textBox1);
            this.gbTitle.Controls.Add(this.txtS);
            this.gbTitle.Controls.Add(this.txtM);
            this.gbTitle.Controls.Add(this.txtH);
            this.gbTitle.Controls.Add(this.cbSet);
            this.gbTitle.Controls.Add(this.label1);
            this.gbTitle.Controls.Add(this.labAlarm);
            this.gbTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbTitle.Location = new System.Drawing.Point(84, 82);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(373, 170);
            this.gbTitle.TabIndex = 1;
            this.gbTitle.TabStop = false;
            this.gbTitle.Text = "Select Time";
            // 
            // txtS
            // 
            this.txtS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtS.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtS.Location = new System.Drawing.Point(272, 75);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(25, 22);
            this.txtS.TabIndex = 6;
            this.txtS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtM
            // 
            this.txtM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtM.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtM.Location = new System.Drawing.Point(224, 75);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(25, 22);
            this.txtM.TabIndex = 5;
            this.txtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtH
            // 
            this.txtH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtH.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtH.Location = new System.Drawing.Point(174, 75);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(25, 22);
            this.txtH.TabIndex = 4;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSet
            // 
            this.cbSet.AutoSize = true;
            this.cbSet.Location = new System.Drawing.Point(174, 117);
            this.cbSet.Name = "cbSet";
            this.cbSet.Size = new System.Drawing.Size(103, 25);
            this.cbSet.TabIndex = 3;
            this.cbSet.Text = "Set Alarm";
            this.cbSet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alarm Time";
            // 
            // labAlarm
            // 
            this.labAlarm.AutoSize = true;
            this.labAlarm.Location = new System.Drawing.Point(64, 74);
            this.labAlarm.Name = "labAlarm";
            this.labAlarm.Size = new System.Drawing.Size(101, 21);
            this.labAlarm.TabIndex = 0;
            this.labAlarm.Text = "Alarm Time:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(199, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "時";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(249, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "分";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(297, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(25, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "秒";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_HomeWork_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 300);
            this.Controls.Add(this.gbTitle);
            this.Controls.Add(this.labTime);
            this.Name = "Frm_HomeWork_Alarm";
            this.Text = "Frm_HomeWork_Alarm";
            this.Load += new System.EventHandler(this.Frm_HomeWork_Alarm_Load);
            this.gbTitle.ResumeLayout(false);
            this.gbTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSet;
        private System.Windows.Forms.Label labAlarm;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}