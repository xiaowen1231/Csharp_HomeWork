using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Csharp
{
    public partial class Frm_HomeWork_ForDoWhile : Form
    {
        public Frm_HomeWork_ForDoWhile()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum.Text, out int answer))
            {
                if (answer % 2 == 1)
                {
                    labAnswer.Text = "輸入的數 : " + answer + " 為奇數";
                }
                else
                {
                    labAnswer.Text = "輸入的數 : " + answer + " 為偶數";
                }
            }
            else
            {
                MessageBox.Show("正確請輸入數值");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labAnswer.Text = "結果 : ";
        }
      

        private void button6_Click(object sender, EventArgs e)
        {
            string[] FindLongest = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            string LongestStr = FindLongest.OrderByDescending(s => s.Length).First() ;
            labAnswer.Text= $"arr0711_str陣列: mother張 , emma , 迪克蕭 , J40 , Candy , Cindy , Coconut , Motherfacker " +
                $"\n陣列最長的名字為 : {LongestStr}";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] FindC = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int count = FindC.Count(s => s.Contains("C") || s.Contains("c"));
            labAnswer.Text = $"arr0711_str陣列: mother張 , emma , 迪克蕭 , J40 , Candy , Cindy , Coconut , Motherfacker \n有C及c的名字共有 : {count} 個";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10]
            {
                {1,1,1,1,1,1,1,1,1,1 },
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                {1,1,1,1,1,1,1,1,1,1 },
            };
            string result = "";

            for(int i = 0;i<arr.GetLength(0);i++)
            {
                for(int x = 0;x<arr.GetLength(0);x++)
                {
                    result += arr[i, x] + "  ";
                }
                result += "\n";
            }
            labAnswer.Text= result;
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10]
          {
                {0,0,0,0,0,0,0,0,0,0},
                {0,1,1,1,1,1,1,1,1,0 },
                {0,1,1,1,1,1,1,1,1,0 },
                {0,1,1,1,1,1,1,1,1,0 },
                {0,1,1,1,1,1,1,1,1,0 },
                {0,1,1,1,1,1,1,1,1,0 },
                {0,1,1,1,1,1,1,1,1,0 },
                {0,1,1,1,1,1,1,1,1,0 },
                {0,1,1,1,1,1,1,1,1,0 },
                {0,0,0,0,0,0,0,0,0,0},
          };
            string result = "";

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    result += arr[i, x] + "  ";
                }
                result += "\n";
            }
            labAnswer.Text = result;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10]
          {
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1 },
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1 },
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1 },
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1 },
                {1,0,1,0,1,0,1,0,1,0},
                {0,1,0,1,0,1,0,1,0,1 },
          };
            string result = "";

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    result += arr[i, x]+"  ";
                }
                result += "\n";
            }
            labAnswer.Text = result;
        }

        void Swap (ref int n1,ref int n2)
        {
            int n3 = n1;
            n1 = n2;
            n2 = n3;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int N1 = 100, N2 = 200;
            labAnswer.Text = $"換位前n1= {N1} , n2 = {N2} ";
            Swap(ref N1, ref N2);
            labAnswer.Text += $"\n換位前n1= {N1} , n2 = {N2} ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int result = 0 ;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            labAnswer.Text = $"int 陣列 arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n加總為 : {result}";
        }
        int max = int.MinValue;
        private void button12_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
            }
            labAnswer.Text = $"int陣列 arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最大值為 {max}";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int odd = 0;
            int even = 0;
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] % 2 == 1)
                {
                    odd++;
                }
                else if (arr[i] %2 == 0)
                {
                    even++;
                }
                labAnswer.Text = $"int陣列 arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n奇數共 {odd}\n偶數共 {even}";
              
            }
        }
        
        int min = int.MaxValue;

        private void button13_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
                min = Math.Min(min, arr[i]);
            }
            labAnswer.Text = $"int陣列 arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最小值為 {min}";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtRow.Text,out int Length))) 
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            string[] arr = new string[Length];
            
            for(int i = 0; i < Length; i++)
            {
                arr[i] = new string('*', i + 1);
            }
            labAnswer.Text = string.Join(Environment.NewLine, arr);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
                min=Math.Min(min, arr[i]);
            }
            labAnswer.Text = $"int陣列 arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最大值為 {max}\n最小值為 {min}";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int number = 100;
            int[] arr = new int[8];
            string result = "結果 : \n";
            int i = 1;
            while (number > 0)
            {
                arr[i]= number % 2;
                number /= 2;
                i++;
            }
            for(int x = arr.Length-1 ; x>=1; x--)
            {
                result += arr[x];
            }
            labAnswer.Text = result;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int[] arr = new int[6];
            string result = "樂透號碼 : \n";
            Random rd = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]= rd.Next(1,49);
                result +=  arr[i] + "   ";
            }
            labAnswer.Text = result;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //int[,] arr = new int[9, 9];
            //string result = "";

            //for (int a = 2; a <= 9; a++)
            //{
            //    for (int b = 1; b <= 9; b++)
            //    {
            //        result += a + "x" + b + "=" + a * b + "|\n";
            //    }
            //    result += "\t";
            //}
            //labAnswer.Text = result;

            int[,] arr = new int[9, 9];
            string result = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 2; b <= 9; b++)
                {
                    result += b + " x " + a + " = " + b * a + " || ";
                }
                result += "\n";
            }
            labAnswer.Text = result;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if(!(int.TryParse(txtFrom.Text,out int From)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(int.TryParse(txtTo.Text, out int To)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(int.TryParse(txtStep.Text, out int Step)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            int[] Num = new int[Math.Abs((To - From) / Step) + 1];

            for (int i = From, arrNum =0; i <= To; i += Step, arrNum++)
            {
                Num[arrNum] = i ;
            }
            int Total = Num.Sum();

            labAnswer.Text = From + " 到 " + To + " 相隔 " + ((Step) - 1) + " 加總為 " + Total;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtFrom.Text, out int From)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(int.TryParse(txtTo.Text, out int To)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(int.TryParse(txtStep.Text, out int Step)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            int[] Num = new int[Math.Abs((To - From) / Step) + 1];

            int arrNum = 0;
            int i = From;
            while (i <= To)
            {
                Num[arrNum] = i;
                arrNum++;
                i += Step;
            }
            int Total = Num.Sum();

            labAnswer.Text = From + " 到 " + To + " 相隔 " + ((Step) - 1) + " 加總為 " + Total;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtFrom.Text, out int From)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(int.TryParse(txtTo.Text, out int To)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            if (!(int.TryParse(txtStep.Text, out int Step)))
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            int[] Num = new int[Math.Abs((To - From) / Step) + 1];
            int arrNum = 0;
            int i = From;

            do
            {
                Num[arrNum] = i;
                arrNum++;
                i += Step;
            } while (i <= To);

            int Total = Num.Sum();
            labAnswer.Text = From + " 到 " + To + " 相隔 " + ((Step)-1) + " 加總為 " + Total;
        }
    }
}

