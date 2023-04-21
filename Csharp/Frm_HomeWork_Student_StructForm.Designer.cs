namespace Csharp
{
    partial class Frm_HomeWork_Student_StructForm
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
            this.labName = new System.Windows.Forms.Label();
            this.labChineseScore = new System.Windows.Forms.Label();
            this.labEnglishScore = new System.Windows.Forms.Label();
            this.labMathScore = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChineseScore = new System.Windows.Forms.TextBox();
            this.txtEnglishScore = new System.Windows.Forms.TextBox();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHigherAndLowest = new System.Windows.Forms.Button();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.txtHigherAndLowest = new System.Windows.Forms.TextBox();
            this.txtScoreList = new System.Windows.Forms.TextBox();
            this.gbScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(59, 97);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(53, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名 : ";
            // 
            // labChineseScore
            // 
            this.labChineseScore.AutoSize = true;
            this.labChineseScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChineseScore.Location = new System.Drawing.Point(59, 146);
            this.labChineseScore.Name = "labChineseScore";
            this.labChineseScore.Size = new System.Drawing.Size(53, 20);
            this.labChineseScore.TabIndex = 1;
            this.labChineseScore.Text = "國文 : ";
            // 
            // labEnglishScore
            // 
            this.labEnglishScore.AutoSize = true;
            this.labEnglishScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglishScore.Location = new System.Drawing.Point(59, 198);
            this.labEnglishScore.Name = "labEnglishScore";
            this.labEnglishScore.Size = new System.Drawing.Size(53, 20);
            this.labEnglishScore.TabIndex = 2;
            this.labEnglishScore.Text = "英文 : ";
            // 
            // labMathScore
            // 
            this.labMathScore.AutoSize = true;
            this.labMathScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMathScore.Location = new System.Drawing.Point(59, 251);
            this.labMathScore.Name = "labMathScore";
            this.labMathScore.Size = new System.Drawing.Size(53, 20);
            this.labMathScore.TabIndex = 3;
            this.labMathScore.Text = "數學 : ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(129, 97);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(86, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtChineseScore
            // 
            this.txtChineseScore.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChineseScore.Location = new System.Drawing.Point(129, 146);
            this.txtChineseScore.Multiline = true;
            this.txtChineseScore.Name = "txtChineseScore";
            this.txtChineseScore.Size = new System.Drawing.Size(86, 20);
            this.txtChineseScore.TabIndex = 5;
            // 
            // txtEnglishScore
            // 
            this.txtEnglishScore.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglishScore.Location = new System.Drawing.Point(129, 198);
            this.txtEnglishScore.Multiline = true;
            this.txtEnglishScore.Name = "txtEnglishScore";
            this.txtEnglishScore.Size = new System.Drawing.Size(86, 20);
            this.txtEnglishScore.TabIndex = 6;
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(129, 251);
            this.txtMathScore.Multiline = true;
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(86, 20);
            this.txtMathScore.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(63, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(198, 324);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(119, 45);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHigherAndLowest
            // 
            this.btnHigherAndLowest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHigherAndLowest.Location = new System.Drawing.Point(592, 324);
            this.btnHigherAndLowest.Name = "btnHigherAndLowest";
            this.btnHigherAndLowest.Size = new System.Drawing.Size(157, 45);
            this.btnHigherAndLowest.TabIndex = 10;
            this.btnHigherAndLowest.Text = "最高分/最低分科目";
            this.btnHigherAndLowest.UseVisualStyleBackColor = true;
            this.btnHigherAndLowest.Click += new System.EventHandler(this.btnHigherAndLowest_Click);
            // 
            // gbScore
            // 
            this.gbScore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbScore.Controls.Add(this.txtHigherAndLowest);
            this.gbScore.Controls.Add(this.txtScoreList);
            this.gbScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbScore.Location = new System.Drawing.Point(440, 59);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(309, 265);
            this.gbScore.TabIndex = 11;
            this.gbScore.TabStop = false;
            this.gbScore.Text = "成績";
            // 
            // txtHigherAndLowest
            // 
            this.txtHigherAndLowest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHigherAndLowest.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHigherAndLowest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHigherAndLowest.Location = new System.Drawing.Point(6, 156);
            this.txtHigherAndLowest.Multiline = true;
            this.txtHigherAndLowest.Name = "txtHigherAndLowest";
            this.txtHigherAndLowest.Size = new System.Drawing.Size(297, 95);
            this.txtHigherAndLowest.TabIndex = 1;
            // 
            // txtScoreList
            // 
            this.txtScoreList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtScoreList.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScoreList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScoreList.Location = new System.Drawing.Point(6, 27);
            this.txtScoreList.Multiline = true;
            this.txtScoreList.Name = "txtScoreList";
            this.txtScoreList.Size = new System.Drawing.Size(297, 123);
            this.txtScoreList.TabIndex = 0;
            // 
            // Frm_HomeWork_Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.btnHigherAndLowest);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.txtEnglishScore);
            this.Controls.Add(this.txtChineseScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMathScore);
            this.Controls.Add(this.labEnglishScore);
            this.Controls.Add(this.labChineseScore);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HomeWork_Student_StructForm";
            this.Text = "Frm_HomeWork_Student_StrucForm";
            this.gbScore.ResumeLayout(false);
            this.gbScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChineseScore;
        private System.Windows.Forms.Label labEnglishScore;
        private System.Windows.Forms.Label labMathScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChineseScore;
        private System.Windows.Forms.TextBox txtEnglishScore;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHigherAndLowest;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.TextBox txtHigherAndLowest;
        private System.Windows.Forms.TextBox txtScoreList;
    }
}