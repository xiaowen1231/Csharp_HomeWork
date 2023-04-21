namespace Csharp
{
    partial class Frm_HomeWork_Claculate
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivided = new System.Windows.Forms.Button();
            this.labNumber1 = new System.Windows.Forms.Label();
            this.labNumber2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.labSeparate = new System.Windows.Forms.Label();
            this.labAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(395, 61);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(82, 49);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubtract.Location = new System.Drawing.Point(395, 126);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(82, 49);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultiply.Location = new System.Drawing.Point(395, 196);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(82, 49);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivided
            // 
            this.btnDivided.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivided.Location = new System.Drawing.Point(395, 269);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(82, 49);
            this.btnDivided.TabIndex = 3;
            this.btnDivided.Text = "/";
            this.btnDivided.UseVisualStyleBackColor = true;
            this.btnDivided.Click += new System.EventHandler(this.btnDivided_Click);
            // 
            // labNumber1
            // 
            this.labNumber1.AutoSize = true;
            this.labNumber1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber1.Location = new System.Drawing.Point(101, 90);
            this.labNumber1.Name = "labNumber1";
            this.labNumber1.Size = new System.Drawing.Size(93, 20);
            this.labNumber1.TabIndex = 4;
            this.labNumber1.Text = "Number1 : ";
            // 
            // labNumber2
            // 
            this.labNumber2.AutoSize = true;
            this.labNumber2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber2.Location = new System.Drawing.Point(100, 155);
            this.labNumber2.Name = "labNumber2";
            this.labNumber2.Size = new System.Drawing.Size(93, 20);
            this.labNumber2.TabIndex = 5;
            this.labNumber2.Text = "Number2 : ";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(233, 88);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 22);
            this.txtNumber1.TabIndex = 6;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(233, 153);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 22);
            this.txtNumber2.TabIndex = 7;
            // 
            // labSeparate
            // 
            this.labSeparate.AutoSize = true;
            this.labSeparate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSeparate.Location = new System.Drawing.Point(100, 225);
            this.labSeparate.Name = "labSeparate";
            this.labSeparate.Size = new System.Drawing.Size(249, 20);
            this.labSeparate.TabIndex = 8;
            this.labSeparate.Text = "====================";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(100, 298);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(76, 20);
            this.labAnswer.TabIndex = 9;
            this.labAnswer.Text = "Answer : ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(233, 296);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(100, 22);
            this.txtAnswer.TabIndex = 10;
            // 
            // Frm_HomeWork_Claculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 404);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labSeparate);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.labNumber2);
            this.Controls.Add(this.labNumber1);
            this.Controls.Add(this.btnDivided);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnPlus);
            this.Name = "Frm_HomeWork_Claculate";
            this.Text = "Frm_HomeWork_Claculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivided;
        private System.Windows.Forms.Label labNumber1;
        private System.Windows.Forms.Label labNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label labSeparate;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}