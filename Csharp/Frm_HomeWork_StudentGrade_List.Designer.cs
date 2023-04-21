namespace Csharp
{
    partial class Frm_HomeWork_StudentGrade_List
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
            this.lvTotalShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvStudentData = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLowest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHighest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSerch = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labSerch = new System.Windows.Forms.Label();
            this.txtChLow = new System.Windows.Forms.TextBox();
            this.txtChHigh = new System.Windows.Forms.TextBox();
            this.labLink = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lvChShow = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvTotalShow
            // 
            this.lvTotalShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.ColumnHeader3,
            this.columnHeader4});
            this.lvTotalShow.HideSelection = false;
            this.lvTotalShow.Location = new System.Drawing.Point(175, 268);
            this.lvTotalShow.Name = "lvTotalShow";
            this.lvTotalShow.Size = new System.Drawing.Size(613, 135);
            this.lvTotalShow.TabIndex = 29;
            this.lvTotalShow.UseCompatibleStateImageBehavior = false;
            this.lvTotalShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文:";
            this.columnHeader2.Width = 65;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "英文:";
            this.ColumnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數學";
            this.columnHeader4.Width = 65;
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
            this.lvStudentData.Location = new System.Drawing.Point(175, 34);
            this.lvStudentData.Name = "lvStudentData";
            this.lvStudentData.Size = new System.Drawing.Size(613, 228);
            this.lvStudentData.TabIndex = 28;
            this.lvStudentData.UseCompatibleStateImageBehavior = false;
            this.lvStudentData.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "姓名 :";
            this.chName.Width = 65;
            // 
            // chChinese
            // 
            this.chChinese.Text = "國文 :";
            this.chChinese.Width = 65;
            // 
            // chEnglish
            // 
            this.chEnglish.Text = "英文 :";
            this.chEnglish.Width = 65;
            // 
            // chMath
            // 
            this.chMath.Text = "數學 :";
            this.chMath.Width = 65;
            // 
            // chTotal
            // 
            this.chTotal.Text = "總分 :";
            this.chTotal.Width = 65;
            // 
            // chAverage
            // 
            this.chAverage.Text = "平均 :";
            this.chAverage.Width = 65;
            // 
            // chLowest
            // 
            this.chLowest.Text = "最低";
            this.chLowest.Width = 65;
            // 
            // chHighest
            // 
            this.chHighest.Text = "最高 :";
            this.chHighest.Width = 65;
            // 
            // btnSerch
            // 
            this.btnSerch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSerch.Location = new System.Drawing.Point(26, 409);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(117, 29);
            this.btnSerch.TabIndex = 27;
            this.btnSerch.Text = "Serch";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(661, 409);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(117, 29);
            this.btnStatistics.TabIndex = 26;
            this.btnStatistics.Text = "統計各科";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveAt.Location = new System.Drawing.Point(25, 268);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(117, 29);
            this.btnRemoveAt.TabIndex = 25;
            this.btnRemoveAt.Text = "移除資料";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(25, 235);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 27);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "插入學生資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(25, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 27);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(71, 151);
            this.txtMath.Multiline = true;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(72, 26);
            this.txtMath.TabIndex = 22;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(71, 112);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(72, 26);
            this.txtEnglish.TabIndex = 21;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(71, 73);
            this.txtChinese.Multiline = true;
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(72, 26);
            this.txtChinese.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 34);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(72, 26);
            this.txtName.TabIndex = 19;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labMath.Location = new System.Drawing.Point(22, 159);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(43, 18);
            this.labMath.TabIndex = 18;
            this.labMath.Text = "數學 :";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labEnglish.Location = new System.Drawing.Point(22, 120);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(43, 18);
            this.labEnglish.TabIndex = 17;
            this.labEnglish.Text = "英文 :";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labChinese.Location = new System.Drawing.Point(22, 81);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(43, 18);
            this.labChinese.TabIndex = 16;
            this.labChinese.Text = "國文 :";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labName.Location = new System.Drawing.Point(22, 42);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(43, 18);
            this.labName.TabIndex = 15;
            this.labName.Text = "姓名 :";
            // 
            // labSerch
            // 
            this.labSerch.AutoSize = true;
            this.labSerch.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.labSerch.Location = new System.Drawing.Point(22, 337);
            this.labSerch.Name = "labSerch";
            this.labSerch.Size = new System.Drawing.Size(127, 18);
            this.labSerch.TabIndex = 30;
            this.labSerch.Text = "搜尋國文成績範圍 :";
            // 
            // txtChLow
            // 
            this.txtChLow.Location = new System.Drawing.Point(22, 372);
            this.txtChLow.Multiline = true;
            this.txtChLow.Name = "txtChLow";
            this.txtChLow.Size = new System.Drawing.Size(47, 31);
            this.txtChLow.TabIndex = 31;
            // 
            // txtChHigh
            // 
            this.txtChHigh.Location = new System.Drawing.Point(96, 372);
            this.txtChHigh.Multiline = true;
            this.txtChHigh.Name = "txtChHigh";
            this.txtChHigh.Size = new System.Drawing.Size(47, 31);
            this.txtChHigh.TabIndex = 32;
            // 
            // labLink
            // 
            this.labLink.AutoSize = true;
            this.labLink.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLink.Location = new System.Drawing.Point(75, 384);
            this.labLink.Name = "labLink";
            this.labLink.Size = new System.Drawing.Size(15, 19);
            this.labLink.TabIndex = 33;
            this.labLink.Text = "-";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(26, 303);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 29);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "清除所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lvChShow
            // 
            this.lvChShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvChShow.HideSelection = false;
            this.lvChShow.Location = new System.Drawing.Point(175, 34);
            this.lvChShow.Name = "lvChShow";
            this.lvChShow.Size = new System.Drawing.Size(613, 228);
            this.lvChShow.TabIndex = 35;
            this.lvChShow.UseCompatibleStateImageBehavior = false;
            this.lvChShow.View = System.Windows.Forms.View.Details;
            this.lvChShow.Visible = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "姓名 :";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "國文 :";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "英文 :";
            this.columnHeader7.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "數學 :";
            this.columnHeader8.Width = 65;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "總分 :";
            this.columnHeader9.Width = 65;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "平均 :";
            this.columnHeader10.Width = 65;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "最低";
            this.columnHeader11.Width = 65;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "最高 :";
            this.columnHeader12.Width = 65;
            // 
            // Frm_HomeWork_StudentGrade_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvChShow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labLink);
            this.Controls.Add(this.txtChHigh);
            this.Controls.Add(this.txtChLow);
            this.Controls.Add(this.labSerch);
            this.Controls.Add(this.lvTotalShow);
            this.Controls.Add(this.lvStudentData);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HomeWork_StudentGrade_List";
            this.Text = "Frm_HomeWork_StudentGrade_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTotalShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvStudentData;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chChinese;
        private System.Windows.Forms.ColumnHeader chEnglish;
        private System.Windows.Forms.ColumnHeader chMath;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.ColumnHeader chAverage;
        private System.Windows.Forms.ColumnHeader chLowest;
        private System.Windows.Forms.ColumnHeader chHighest;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labSerch;
        private System.Windows.Forms.TextBox txtChLow;
        private System.Windows.Forms.TextBox txtChHigh;
        private System.Windows.Forms.Label labLink;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView lvChShow;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}