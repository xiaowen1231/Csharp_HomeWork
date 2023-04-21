namespace Csharp
{
    partial class Frm_HomeWork_Loan
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
            this.labTheAmount = new System.Windows.Forms.Label();
            this.labLoanTerm = new System.Windows.Forms.Label();
            this.labInsterestRate = new System.Windows.Forms.Label();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.txtTheAmount = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtInsterestRate = new System.Windows.Forms.TextBox();
            this.txtDonwPayment = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTheAmount
            // 
            this.labTheAmount.AutoSize = true;
            this.labTheAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTheAmount.Location = new System.Drawing.Point(30, 34);
            this.labTheAmount.Name = "labTheAmount";
            this.labTheAmount.Size = new System.Drawing.Size(73, 20);
            this.labTheAmount.TabIndex = 0;
            this.labTheAmount.Text = "貸款金額";
            // 
            // labLoanTerm
            // 
            this.labLoanTerm.AutoSize = true;
            this.labLoanTerm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanTerm.Location = new System.Drawing.Point(30, 81);
            this.labLoanTerm.Name = "labLoanTerm";
            this.labLoanTerm.Size = new System.Drawing.Size(67, 20);
            this.labLoanTerm.TabIndex = 1;
            this.labLoanTerm.Text = "期限(年)";
            // 
            // labInsterestRate
            // 
            this.labInsterestRate.AutoSize = true;
            this.labInsterestRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInsterestRate.Location = new System.Drawing.Point(30, 122);
            this.labInsterestRate.Name = "labInsterestRate";
            this.labInsterestRate.Size = new System.Drawing.Size(41, 20);
            this.labInsterestRate.TabIndex = 2;
            this.labInsterestRate.Text = "利率";
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.Location = new System.Drawing.Point(30, 168);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(57, 20);
            this.labDownPayment.TabIndex = 3;
            this.labDownPayment.Text = "頭期款";
            // 
            // txtTheAmount
            // 
            this.txtTheAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTheAmount.Location = new System.Drawing.Point(138, 25);
            this.txtTheAmount.Name = "txtTheAmount";
            this.txtTheAmount.Size = new System.Drawing.Size(100, 29);
            this.txtTheAmount.TabIndex = 4;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanTerm.Location = new System.Drawing.Point(138, 72);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(100, 29);
            this.txtLoanTerm.TabIndex = 5;
            // 
            // txtInsterestRate
            // 
            this.txtInsterestRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInsterestRate.Location = new System.Drawing.Point(138, 113);
            this.txtInsterestRate.Name = "txtInsterestRate";
            this.txtInsterestRate.Size = new System.Drawing.Size(100, 29);
            this.txtInsterestRate.TabIndex = 6;
            // 
            // txtDonwPayment
            // 
            this.txtDonwPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDonwPayment.Location = new System.Drawing.Point(138, 159);
            this.txtDonwPayment.Name = "txtDonwPayment";
            this.txtDonwPayment.Size = new System.Drawing.Size(100, 29);
            this.txtDonwPayment.TabIndex = 7;
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(34, 236);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(103, 56);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT(月付)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(143, 236);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(103, 56);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(312, 236);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(103, 56);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Frm_HomeWork_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 315);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDonwPayment);
            this.Controls.Add(this.txtInsterestRate);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.txtTheAmount);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labInsterestRate);
            this.Controls.Add(this.labLoanTerm);
            this.Controls.Add(this.labTheAmount);
            this.Name = "Frm_HomeWork_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTheAmount;
        private System.Windows.Forms.Label labLoanTerm;
        private System.Windows.Forms.Label labInsterestRate;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.TextBox txtTheAmount;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtInsterestRate;
        private System.Windows.Forms.TextBox txtDonwPayment;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}