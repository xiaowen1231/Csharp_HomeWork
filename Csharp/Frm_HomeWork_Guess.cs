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
    public partial class Frm_HomeWork_Guess : Form
    {
        public Frm_HomeWork_Guess()
        {
            InitializeComponent();
            lab = labHint;
        }
        public static int Ans;
        public static Label lab;
        private void btnStart_Click(object sender, EventArgs e)
        {
            labHint.Text = "請輸入數字 0 到 100 !";
            Random rnd = new Random();
            Ans = rnd.Next(1,100);
            Frm_Geuss_Report GR = new Frm_Geuss_Report();
            GR.ShowDialog();

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案 : {Ans}");
        }
    }
}
