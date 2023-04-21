namespace Csharp
{
    partial class Frm_HomeWork_StudentGrade
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
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddRandom20 = new System.Windows.Forms.Button();
            this.lvStudentData = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLowest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHighest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTotalShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labName.Location = new System.Drawing.Point(32, 34);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(43, 18);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名 :";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labChinese.Location = new System.Drawing.Point(32, 73);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(43, 18);
            this.labChinese.TabIndex = 1;
            this.labChinese.Text = "國文 :";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labEnglish.Location = new System.Drawing.Point(32, 112);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(43, 18);
            this.labEnglish.TabIndex = 2;
            this.labEnglish.Text = "英文 :";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labMath.Location = new System.Drawing.Point(32, 151);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(43, 18);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學 :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 26);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(72, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(81, 65);
            this.txtChinese.Multiline = true;
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(72, 26);
            this.txtChinese.TabIndex = 5;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(81, 104);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(72, 26);
            this.txtEnglish.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(81, 143);
            this.txtMath.Multiline = true;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(72, 26);
            this.txtMath.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(35, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 27);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRandom.Location = new System.Drawing.Point(35, 227);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(117, 27);
            this.btnAddRandom.TabIndex = 9;
            this.btnAddRandom.Text = "隨機儲存資料";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            this.btnAddRandom.Click += new System.EventHandler(this.btnAddRandom_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(35, 260);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(117, 29);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(35, 345);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 29);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddRandom20
            // 
            this.btnAddRandom20.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRandom20.Location = new System.Drawing.Point(35, 380);
            this.btnAddRandom20.Name = "btnAddRandom20";
            this.btnAddRandom20.Size = new System.Drawing.Size(117, 29);
            this.btnAddRandom20.TabIndex = 12;
            this.btnAddRandom20.Text = "隨機加入20筆";
            this.btnAddRandom20.UseVisualStyleBackColor = true;
            this.btnAddRandom20.Click += new System.EventHandler(this.btnAddRandom20_Click);
            // 
            // lvStudentData
            // 
            this.lvStudentData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chChinese,
            this.chEnglish,
            this.chMath,
            this.chTotal,
            this.chAverage,
            this.chLowest,
            this.chHighest});
            this.lvStudentData.HideSelection = false;
            this.lvStudentData.Location = new System.Drawing.Point(185, 26);
            this.lvStudentData.Name = "lvStudentData";
            this.lvStudentData.Size = new System.Drawing.Size(603, 228);
            this.lvStudentData.TabIndex = 13;
            this.lvStudentData.UseCompatibleStateImageBehavior = false;
            this.lvStudentData.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "姓名 :";
            // 
            // chChinese
            // 
            this.chChinese.Text = "國文 :";
            // 
            // chEnglish
            // 
            this.chEnglish.Text = "英文 :";
            // 
            // chMath
            // 
            this.chMath.Text = "數學 :";
            // 
            // chTotal
            // 
            this.chTotal.Text = "總分 :";
            // 
            // chAverage
            // 
            this.chAverage.Text = "平均 :";
            // 
            // chLowest
            // 
            this.chLowest.Text = "最低";
            // 
            // chHighest
            // 
            this.chHighest.Text = "最高 :";
            // 
            // lvTotalShow
            // 
            this.lvTotalShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.ColumnHeader3,
            this.columnHeader4});
            this.lvTotalShow.HideSelection = false;
            this.lvTotalShow.Location = new System.Drawing.Point(185, 277);
            this.lvTotalShow.Name = "lvTotalShow";
            this.lvTotalShow.Size = new System.Drawing.Size(603, 132);
            this.lvTotalShow.TabIndex = 14;
            this.lvTotalShow.UseCompatibleStateImageBehavior = false;
            this.lvTotalShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文:";
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "英文:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數學";
            // 
            // Frm_HomeWork_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvTotalShow);
            this.Controls.Add(this.lvStudentData);
            this.Controls.Add(this.btnAddRandom20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnAddRandom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HomeWork_StudentGrade";
            this.Text = "Frm_HomeWork_StudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddRandom20;
        private System.Windows.Forms.ListView lvStudentData;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chChinese;
        private System.Windows.Forms.ColumnHeader chEnglish;
        private System.Windows.Forms.ColumnHeader chMath;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.ColumnHeader chAverage;
        private System.Windows.Forms.ColumnHeader chLowest;
        private System.Windows.Forms.ColumnHeader chHighest;
        private System.Windows.Forms.ListView lvTotalShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader ColumnHeader3;
    }
}