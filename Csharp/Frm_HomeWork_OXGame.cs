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
    public partial class Frm_HomeWork_OXGame : Form
    {
        public Frm_HomeWork_OXGame()
        {
            InitializeComponent();
        }

        bool BtnClick = true;

        void BtnShow(Button btn)
        {
            if (BtnClick)
            {
                btn.Text = "O";
                BtnClick = false;
            }
            else
            {
                btn.Text = "X";
                BtnClick = true;
            }
            btn.Enabled = false;
        }

        void judge()
        {
            string[] win = 
                {
                btn1.Text + btn2.Text + btn3.Text,
                btn4.Text + btn5.Text + btn6.Text,
                btn7.Text + btn8.Text + btn9.Text,
                btn1.Text + btn4.Text + btn7.Text,
                btn2.Text + btn5.Text + btn8.Text,
                btn3.Text + btn6.Text + btn9.Text,
                btn1.Text + btn5.Text + btn9.Text,
                btn3.Text + btn5.Text + btn7.Text 
            };
            for(int i = 0; i<win.Length;i++)
            {
                if (win[i] == "OOO")
                {
                    MessageBox.Show("O勝利!");
                    reset();
                    return;
                }
                else if (win[i] == "XXX")
                {
                    MessageBox.Show("X勝利!");
                    reset();
                    return;
                }
            }

            if (!btn1.Enabled && !btn2.Enabled && !btn3.Enabled &&
                !btn4.Enabled && !btn5.Enabled && !btn6.Enabled &&
                !btn7.Enabled && !btn8.Enabled && !btn9.Enabled)
            {
                MessageBox.Show("平手!");
                reset();
                return;
            }
        }
        void reset()
        {
            btn1.Text = null;
            btn2.Text = null;
            btn3.Text = null;
            btn4.Text = null;
            btn5.Text = null;
            btn6.Text = null;
            btn7.Text = null;
            btn8.Text = null;
            btn9.Text = null;

            BtnClick = true;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BtnShow(btn1);
            judge();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BtnShow(btn2);
            judge();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            BtnShow(btn3);
            judge();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            BtnShow(btn4);
            judge();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            BtnShow(btn5);
            judge();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            BtnShow(btn6);
            judge();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            BtnShow(btn7);
            judge();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            BtnShow(btn8);
            judge();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            BtnShow(btn9);
            judge();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
