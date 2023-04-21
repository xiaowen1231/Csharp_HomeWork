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
    public partial class Frm_HomeWork_Claculate : Form
    {
        public Frm_HomeWork_Claculate()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtNumber1.Text, out double num1)))
            {
                MessageBox.Show("請輸入正確數值");
                return;
            }
            if (!(double.TryParse(txtNumber2.Text, out double num2)))
            {
                MessageBox.Show("請輸入正確數值");
                return;
            }
            txtAnswer.Text = (num1 + num2).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtNumber1.Text, out double num1)))
            {
                MessageBox.Show("請輸入正確數值");
                return;
            }
            if (!(double.TryParse(txtNumber2.Text, out double num2)))
            {
                MessageBox.Show("請輸入正確數值");
                return;
            }
            txtAnswer.Text = (num1 - num2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtNumber1.Text, out double num1)))
            {
                MessageBox.Show("請輸入正確數值");
                return;
            }
            if (!(double.TryParse(txtNumber2.Text, out double num2)))
            {
                MessageBox.Show("請輸入正確數值");
                return;
            }
            txtAnswer.Text = (num1 * num2).ToString();
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtNumber1.Text, out double num1)))
            {
                MessageBox.Show("請輸入正確數值");
                return;
            }
            if (!(double.TryParse(txtNumber2.Text, out double num2)))
            {
                MessageBox.Show("請輸入正確數值");
                return;
            }
            if(num2==0)
            {
                txtAnswer.Text = "∞";
                return;
            }
            txtAnswer.Text = (num1 / num2).ToString();
        }
    }
}
