using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp
{
    public partial class Frm_HomeWork_StudentGrade_List : Form
    {
        public Frm_HomeWork_StudentGrade_List()
        {
            InitializeComponent();
        }
        public struct Student
        {
            public string Name;
            public int ChineseScore;
            public int EnglishScore;
            public int MathScore;
            public int Total;
            public int Average;
            public int HighestSubject;
            public int LowestSubject;
        }
        int id = 0;
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (id >= 100)
            {
                MessageBox.Show("超出資料上限");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("請輸入學生姓名");
                return;
            }

            Student sd;
            sd.ChineseScore = sd.EnglishScore = sd.MathScore = 0;
            int ChineseScore, EnglishScore, MathScore;

            if (int.TryParse(txtChinese.Text, out ChineseScore))
            {
                sd.ChineseScore = ChineseScore;
            }
            else
            {
                MessageBox.Show("國文成績輸入錯誤，請重新輸入");
                return;
            }

            if (int.TryParse(txtEnglish.Text, out EnglishScore))
            {
                sd.EnglishScore = EnglishScore;
            }
            else
            {
                MessageBox.Show("英文成績輸入錯誤，請重新輸入");
                return;
            }

            if (int.TryParse(txtMath.Text, out MathScore))
            {
                sd.MathScore = MathScore;
            }
            else
            {
                MessageBox.Show("數學成績輸入錯誤，請重新輸入");
                return;
            }
            id++;

            string highestSubject = "";
            string lowestSubject = "";

            int HighestScore = Math.Max(MathScore, Math.Max(ChineseScore, EnglishScore));
            int LowestScore = Math.Min(MathScore, Math.Min(ChineseScore, EnglishScore));

            if (HighestScore == ChineseScore)
            {
                highestSubject = "國文" + HighestScore;
            }
            if (HighestScore == EnglishScore)
            {
                highestSubject = "英文" + HighestScore;
            }
            if (HighestScore == MathScore)
            {
                highestSubject = "數學" + HighestScore;
            }
            if (LowestScore == ChineseScore)
            {
                lowestSubject = "國文" + LowestScore;
            }
            if (LowestScore == EnglishScore)
            {
                lowestSubject = "英文" + LowestScore;
            }
            if (LowestScore == MathScore)
            {
                lowestSubject = "數學" + LowestScore;
            }
            sd.HighestSubject = HighestScore;
            sd.LowestSubject = LowestScore;
            
            ListViewItem lv = new ListViewItem(txtName.Text);
            sd.Total = int.Parse(txtChinese.Text) + int.Parse(txtEnglish.Text) + int.Parse(txtMath.Text);
            int average = sd.Total / 3;
            lv.SubItems.Add(txtChinese.Text);
            lv.SubItems.Add(txtEnglish.Text);
            lv.SubItems.Add(txtMath.Text);
            lv.SubItems.Add(sd.Total.ToString());
            lv.SubItems.Add(average.ToString());
            lv.SubItems.Add(lowestSubject.ToString());
            lv.SubItems.Add(highestSubject.ToString());


            lvStudentData.Items.Add(lv);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (id >= 100)
            {
                MessageBox.Show("超出資料上限");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("請輸入學生姓名");
                return;
            }

            Student sd;
            sd.ChineseScore = sd.EnglishScore = sd.MathScore = 0;
            int ChineseScore, EnglishScore, MathScore;

            if (int.TryParse(txtChinese.Text, out ChineseScore))
            {
                sd.ChineseScore = ChineseScore;
            }
            else
            {
                MessageBox.Show("國文成績輸入錯誤，請重新輸入");
                return;
            }

            if (int.TryParse(txtEnglish.Text, out EnglishScore))
            {
                sd.EnglishScore = EnglishScore;
            }
            else
            {
                MessageBox.Show("英文成績輸入錯誤，請重新輸入");
                return;
            }

            if (int.TryParse(txtMath.Text, out MathScore))
            {
                sd.MathScore = MathScore;
            }
            else
            {
                MessageBox.Show("數學成績輸入錯誤，請重新輸入");
                return;
            }
            id++;

            string highestSubject = "";
            string lowestSubject = "";

            int HighestScore = Math.Max(MathScore, Math.Max(ChineseScore, EnglishScore));
            int LowestScore = Math.Min(MathScore, Math.Min(ChineseScore, EnglishScore));

            if (HighestScore == ChineseScore)
            {
                highestSubject = "國文" + HighestScore;
            }
            if (HighestScore == EnglishScore)
            {
                highestSubject = "英文" + HighestScore;
            }
            if (HighestScore == MathScore)
            {
                highestSubject = "數學" + HighestScore;
            }
            if (LowestScore == ChineseScore)
            {
                lowestSubject = "國文" + LowestScore;
            }
            if (LowestScore == EnglishScore)
            {
                lowestSubject = "英文" + LowestScore;
            }
            if (LowestScore == MathScore)
            {
                lowestSubject = "數學" + LowestScore;
            }
            sd.HighestSubject = HighestScore;
            sd.LowestSubject = LowestScore;

            ListViewItem lv = new ListViewItem(txtName.Text);
            sd.Total = int.Parse(txtChinese.Text) + int.Parse(txtEnglish.Text) + int.Parse(txtMath.Text);
            int average = sd.Total / 3;
            lv.SubItems.Add(txtChinese.Text);
            lv.SubItems.Add(txtEnglish.Text);
            lv.SubItems.Add(txtMath.Text);
            lv.SubItems.Add(sd.Total.ToString());
            lv.SubItems.Add(average.ToString());
            lv.SubItems.Add(lowestSubject.ToString());
            lv.SubItems.Add(highestSubject.ToString());


            lvStudentData.Items.Insert(0, lv);
        }
        
        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("請加入資料");
                return;
            }
            id--;
            lvStudentData.Items.RemoveAt(id);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("請加入資料");
                return;
            }
            id = 0;
             ChScore = 0;
             EnScore = 0;
             MaScore = 0;
             ChMax = 0;
             ChMin = 0;
             EnMax = 0;
             EnMin = 100;
             MaMax = 100;
             MaMin = 100;
             avgCh = 0;
             avgEn = 0;
             avgMa = 0;
            lvStudentData.Items.Clear();
            lvTotalShow.Items.Clear();
            lvChShow.Items.Clear();

            btnAdd.Enabled = true;
            btnInsert.Enabled = true;
            btnRemoveAt.Enabled = true;
            btnSerch.Enabled = true;
            btnStatistics.Enabled = true;
            lvChShow.Visible = false;

        }
        int ChScore = 0;
        int EnScore = 0;
        int MaScore = 0;
        int ChMax = 0;
        int ChMin = 0;
        int EnMax = 0;
        int EnMin = 100;
        int MaMax = 100;
        int MaMin = 100;
        int avgCh = 0;
        int avgEn = 0;
        int avgMa = 0;
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("請加入資料");
                return;
            }

            for (int i = 0; i < lvStudentData.Items.Count; i++)
            {

                ChScore += int.Parse(lvStudentData.Items[i].SubItems[1].Text);
                EnScore += int.Parse(lvStudentData.Items[i].SubItems[2].Text);
                MaScore += int.Parse(lvStudentData.Items[i].SubItems[3].Text);
                ChMax = Math.Max(ChMax, int.Parse(lvStudentData.Items[i].SubItems[1].Text));
                EnMax = Math.Max(EnMax, int.Parse(lvStudentData.Items[i].SubItems[2].Text));
                MaMax = Math.Max(MaMax, int.Parse(lvStudentData.Items[i].SubItems[3].Text));
                ChMin = Math.Min(ChMin, int.Parse(lvStudentData.Items[i].SubItems[1].Text));
                EnMin = Math.Min(EnMin, int.Parse(lvStudentData.Items[i].SubItems[2].Text));
                MaMin = Math.Min(MaMin, int.Parse(lvStudentData.Items[i].SubItems[3].Text));
            }

            avgCh = ChScore / lvStudentData.Items.Count;
            avgEn = EnScore / lvStudentData.Items.Count;
            avgMa = MaScore / lvStudentData.Items.Count;

            ListViewItem TotalShow = new ListViewItem("總分:");
            TotalShow.SubItems.Add((ChScore).ToString());
            TotalShow.SubItems.Add((EnScore).ToString());
            TotalShow.SubItems.Add((MaScore).ToString());

            ListViewItem avgShow = new ListViewItem("平均:");
            avgShow.SubItems.Add((avgCh).ToString());
            avgShow.SubItems.Add((avgEn).ToString());
            avgShow.SubItems.Add((avgMa).ToString());

            ListViewItem HighShow = new ListViewItem("最高分:");
            HighShow.SubItems.Add((ChMax).ToString());
            HighShow.SubItems.Add((EnMax).ToString());
            HighShow.SubItems.Add((MaMax).ToString());

            ListViewItem LowShow = new ListViewItem("最低分:");
            LowShow.SubItems.Add((ChMin).ToString());
            LowShow.SubItems.Add((EnMin).ToString());
            LowShow.SubItems.Add((MaMin).ToString());

            lvTotalShow.Items.Add(TotalShow);
            lvTotalShow.Items.Add(avgShow);
            lvTotalShow.Items.Add(HighShow);
            lvTotalShow.Items.Add(LowShow);
            btnStatistics.Enabled = false;
            btnAdd.Enabled= false;
            btnInsert.Enabled= false;
            btnRemoveAt.Enabled= false;
        }
        string SerchName;
        int SerchCh;
        int SerchEn;
        int SerchMa;
        int SerchTotal;
        int SerchAvg;
        string SerchMax;
        string SerchMin;
        

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("請加入資料");
                return;
            }
            int SerchHigh, SerchLow;
            if (!(int.TryParse(txtChHigh.Text, out SerchHigh)))
            {
                MessageBox.Show("請輸入最高值");
                return;
            }
            if (!(int.TryParse(txtChLow.Text, out SerchLow)))
            {
                MessageBox.Show("請輸入最低值");
                return;
            }
            if (SerchHigh < SerchLow)
            {
                MessageBox.Show("左邊文字框為較小數值資料");
                return;
            }

            lvChShow.Visible = true;
            for (int i = 0;i<lvStudentData.Items.Count;i++)
            {
                SerchName = lvStudentData.Items[i].SubItems[0].Text;
                SerchCh = int.Parse(lvStudentData.Items[i].SubItems[1].Text);
                SerchEn = int.Parse(lvStudentData.Items[i].SubItems[2].Text);
                SerchMa= int.Parse(lvStudentData.Items[i].SubItems[3].Text);
                SerchTotal= int.Parse(lvStudentData.Items[i].SubItems[4].Text);
                SerchAvg = int.Parse(lvStudentData.Items[i].SubItems[5].Text);
                SerchMax = lvStudentData.Items[i].SubItems[6].Text;
                SerchMin = lvStudentData.Items[i].SubItems[7].Text;

                if (int.Parse(txtChLow.Text) <= SerchCh &&SerchCh <= int.Parse(txtChHigh.Text))
                {
                    ListViewItem list = new ListViewItem(SerchName);
                    list.SubItems.Add(SerchCh.ToString());
                    list.SubItems.Add(SerchEn.ToString());
                    list.SubItems.Add(SerchMa.ToString());
                    list.SubItems.Add(SerchTotal.ToString());
                    list.SubItems.Add(SerchAvg.ToString());
                    list.SubItems.Add(SerchMax.ToString());
                    list.SubItems.Add(SerchMin.ToString());

                    lvChShow.Items.Add(list);
                    
                    btnSerch.Enabled = false;
                    btnStatistics.Enabled = false;

                }
            }
        }
    }
}
