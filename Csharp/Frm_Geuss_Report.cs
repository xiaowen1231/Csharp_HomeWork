using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp
{
    public partial class Frm_Geuss_Report : Form
    {
        public Frm_Geuss_Report()
        {
            InitializeComponent();
        }
        int top = 100;
        int low = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtEnter.Text, out int keyin)))
            {
                MessageBox.Show($"請輸入0到100之間的數字");
                return;
            }
            else
            {
                if (keyin < 0 || keyin > 100)
                {
                    MessageBox.Show($"請輸入0到100之間的數字");
                    return;
                }
            }
            int Answer = Frm_HomeWork_Guess.Ans;

            if (keyin > Answer)
            {
                top = keyin;
                Frm_HomeWork_Guess.lab.Text = $"太大了!!!\n請輸入  {low} 到 {top} 之間的數字";
            }
            if (keyin < Answer)
            {
                low = keyin;
                Frm_HomeWork_Guess.lab.Text = $"太小了!!!\n請輸入  {low} 到 {top} 之間的數字";
            }
            if (keyin == Answer)
            {
                Frm_HomeWork_Guess.lab.Text = $"恭喜你答對了!!! 答案是 : {keyin} \n請重新開始遊戲";
                MessageBox.Show($"恭喜你答對了!!! 答案是 : {keyin}");
            }
            txtEnter.SelectAll();
            txtEnter.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
