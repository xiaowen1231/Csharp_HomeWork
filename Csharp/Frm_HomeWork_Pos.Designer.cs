namespace Csharp
{
    partial class Frm_HomeWork_Pos
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.gbPaymentMethod = new System.Windows.Forms.GroupBox();
            this.lab10Off = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.gbTotalPrice = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.gbPaymentMethod.SuspendLayout();
            this.gbTotalPrice.SuspendLayout();
            this.gbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnWine);
            this.gbMenu.Controls.Add(this.btnTequila);
            this.gbMenu.Controls.Add(this.btnWhisky);
            this.gbMenu.Controls.Add(this.btnBeer);
            this.gbMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbMenu.Location = new System.Drawing.Point(24, 47);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(226, 336);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "菜單 Menu";
            // 
            // btnWine
            // 
            this.btnWine.Location = new System.Drawing.Point(115, 196);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(89, 115);
            this.btnWine.TabIndex = 6;
            this.btnWine.Text = "紅酒 Wine NT$320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.Location = new System.Drawing.Point(20, 196);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(89, 115);
            this.btnTequila.TabIndex = 5;
            this.btnTequila.Text = "龍舌蘭 Tequila NT$180";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.Location = new System.Drawing.Point(115, 55);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(89, 115);
            this.btnWhisky.TabIndex = 4;
            this.btnWhisky.Text = "威士忌 Whisky NT$350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.Location = new System.Drawing.Point(20, 55);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(89, 115);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "啤酒 Beer NT$120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // gbPaymentMethod
            // 
            this.gbPaymentMethod.Controls.Add(this.lab10Off);
            this.gbPaymentMethod.Controls.Add(this.btnCreditCard);
            this.gbPaymentMethod.Controls.Add(this.btnCash);
            this.gbPaymentMethod.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPaymentMethod.Location = new System.Drawing.Point(274, 163);
            this.gbPaymentMethod.Name = "gbPaymentMethod";
            this.gbPaymentMethod.Size = new System.Drawing.Size(249, 109);
            this.gbPaymentMethod.TabIndex = 1;
            this.gbPaymentMethod.TabStop = false;
            this.gbPaymentMethod.Text = "付款方式";
            // 
            // lab10Off
            // 
            this.lab10Off.AutoSize = true;
            this.lab10Off.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab10Off.Location = new System.Drawing.Point(127, 80);
            this.lab10Off.Name = "lab10Off";
            this.lab10Off.Size = new System.Drawing.Size(116, 17);
            this.lab10Off.TabIndex = 2;
            this.lab10Off.Text = "信用卡享九折優惠!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(139, 32);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(87, 36);
            this.btnCreditCard.TabIndex = 1;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(18, 32);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(87, 36);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // gbTotalPrice
            // 
            this.gbTotalPrice.Controls.Add(this.txtTotalPrice);
            this.gbTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbTotalPrice.Location = new System.Drawing.Point(274, 47);
            this.gbTotalPrice.Name = "gbTotalPrice";
            this.gbTotalPrice.Size = new System.Drawing.Size(249, 86);
            this.gbTotalPrice.TabIndex = 2;
            this.gbTotalPrice.TabStop = false;
            this.gbTotalPrice.Text = "總金額 Total Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.Black;
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Transparent;
            this.txtTotalPrice.Location = new System.Drawing.Point(18, 38);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(207, 33);
            this.txtTotalPrice.TabIndex = 0;
            this.txtTotalPrice.Text = "NT$0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.txtList);
            this.gbList.Controls.Add(this.btnClear);
            this.gbList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbList.Location = new System.Drawing.Point(544, 47);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(229, 335);
            this.gbList.TabIndex = 3;
            this.gbList.TabStop = false;
            this.gbList.Text = "購物清單 List";
            // 
            // txtList
            // 
            this.txtList.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtList.Location = new System.Drawing.Point(16, 33);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(202, 248);
            this.txtList.TabIndex = 1;
            this.txtList.Text = "尚未點餐";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(132, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 32);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Frm_HomeWork_Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbTotalPrice);
            this.Controls.Add(this.gbPaymentMethod);
            this.Controls.Add(this.gbMenu);
            this.Name = "Frm_HomeWork_Pos";
            this.Text = "Frm_HomeWork_Pos";
            this.gbMenu.ResumeLayout(false);
            this.gbPaymentMethod.ResumeLayout(false);
            this.gbPaymentMethod.PerformLayout();
            this.gbTotalPrice.ResumeLayout(false);
            this.gbTotalPrice.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.GroupBox gbPaymentMethod;
        private System.Windows.Forms.GroupBox gbTotalPrice;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Label lab10Off;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnClear;
    }
}