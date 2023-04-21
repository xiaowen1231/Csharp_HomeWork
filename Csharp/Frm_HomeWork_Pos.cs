using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp
{
    public partial class Frm_HomeWork_Pos : Form
    {

        public Frm_HomeWork_Pos()
        {
            InitializeComponent();
        }
        int BeerPirce = 120;
        int WhiskyPirce = 350;
        int TequilaPrice = 180;
        int WinePrice = 320;

        int BeerCount = 0;
        int WhiskyCount = 0;
        int TequilaCount = 0;
        int WineCount = 0;

        int Payway =0;

       public void TotalPrice()
        {
            int TotalPrice = (BeerCount*BeerPirce) + (WhiskyCount*WhiskyPirce) +(TequilaCount*TequilaPrice) +
                (WineCount*WinePrice);
            txtTotalPrice.Text = "NT$" + TotalPrice;
        }

        public void ListText()
        {
            string list ="";
            Payway = BeerCount + WhiskyCount + TequilaCount + WineCount;

            if (BeerCount > 0)
            {
                list += "啤酒Beer x" + BeerCount + ",共NT$" + (BeerCount * BeerPirce) + "元\r\n"; 
            }
            if (WhiskyCount > 0)
            {
                list += "威士忌Whisky x" + WhiskyCount + ",共NT$" + (WhiskyCount * WhiskyPirce) + "元\r\n";
            }
            if(TequilaCount > 0)
            {
                list += "龍舌蘭Tequila x" + TequilaCount + ",共NT$" + (TequilaCount * TequilaPrice) + "元\r\n";
            }
            if (WineCount > 0)
            {
                list += "紅酒Wine x" + WineCount + ",共NT$" + (WineCount * WinePrice) + "元\r\n";
            }
            if(Payway==0)
            {
                list = "尚未點餐";
            }
            txtList.Text = list;
        }
        public void Pay()
        {
            Payway = BeerCount + WhiskyCount + TequilaCount+WineCount;
            if (Payway>0)
            {
                MessageBox.Show("總金額:" + txtTotalPrice.Text, "確認付款", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("尚未點餐","確認付款", MessageBoxButtons.OKCancel);

            }
        }
        void PayByCreditCard()
        {
            Payway = BeerCount + WhiskyCount + TequilaCount + WineCount;

            double off10 = ((BeerCount * BeerPirce) + (WhiskyCount * WhiskyPirce) + (TequilaCount * TequilaPrice) +
                (WineCount * WinePrice)) * 0.9;
            if (Payway > 0)
            {
                MessageBox.Show("總金額:" + txtTotalPrice.Text+"\r\n折扣後金額 : NT$" + off10, "確認付款", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OKCancel);

            }
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            BeerCount++;
            TotalPrice();
            ListText();

        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            WhiskyCount++;
            TotalPrice();
            ListText();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            TequilaCount++;
            TotalPrice();
            ListText();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            WineCount++;
            TotalPrice();
            ListText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BeerCount = 0;
            WhiskyCount = 0;
            TequilaCount = 0;
            WineCount = 0;

            ListText();
            TotalPrice();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Pay();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            PayByCreditCard();
        }
    }
}
