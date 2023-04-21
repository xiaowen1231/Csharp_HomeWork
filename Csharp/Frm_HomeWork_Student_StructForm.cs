using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Csharp
{

    public partial class Frm_HomeWork_Student_StructForm : Form
    {

        
        public Frm_HomeWork_Student_StructForm()
        {
            InitializeComponent();
        }
        public struct student
        {
            public string Name;
            public int ChineseScore;
            public int EnglishScore;
            public int MathScore;
        }
         student ShowStudent;

        private void btnSave_Click(object sender, EventArgs e)
        {
            student sd;
            sd.Name = txtName.Text;
            sd.ChineseScore = int.Parse(txtChineseScore.Text);
            sd.EnglishScore = int.Parse(txtEnglishScore.Text);
            sd.MathScore = int.Parse(txtMathScore.Text);
            ShowStudent = sd;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtScoreList.Text = "姓名 : " + ShowStudent.Name
            + "\r\n國文 : " + ShowStudent.ChineseScore + "分"
            + "\r\n英文 : " + ShowStudent.EnglishScore + "分"
            + "\r\n數學 : " + ShowStudent.MathScore + "分";
        }

        private void btnHigherAndLowest_Click(object sender, EventArgs e)
        {
            FindHighestAndLowestScores();
        }
        private void FindHighestAndLowestScores()
        {
            int HighScore = Math.Max( ShowStudent.MathScore,Math.Max(ShowStudent.ChineseScore, ShowStudent.EnglishScore));
            int LowestScore = Math.Min(ShowStudent.EnglishScore, Math.Min( ShowStudent.MathScore,ShowStudent.ChineseScore));
            string HighSubject = "";
            string LowestSubject = "";
            if (HighScore == ShowStudent.ChineseScore)
            {
                HighSubject = "國文";
            }
             if(HighScore == ShowStudent.EnglishScore)
            {
                HighSubject = "英文";
            }
             if (HighScore == ShowStudent.MathScore)
            {
                HighSubject = "數學";
            }
             if(LowestScore==ShowStudent.ChineseScore )
            {
                LowestSubject = "國文";
            }
             if( LowestScore == ShowStudent.EnglishScore)
            {
                LowestSubject = "英文";
            }
             if (LowestScore == ShowStudent.MathScore)
            {
                LowestSubject = "數學";
            }
            txtHigherAndLowest.Text = "最高科目成績為 : " + HighSubject + HighScore + "分" +
               "\r\n最低科目成績為 : " + LowestSubject + LowestScore + "分";
        }
    }
}

