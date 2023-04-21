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
    public partial class Frm_HomePage : Form
    {
        public Frm_HomePage()
        {
            InitializeComponent();
        }

        Form SaveForm = null;
        void CheckForm (Form form)
        {
            if(SaveForm != null)
            {
                SaveForm.Close();
                SaveForm = null;
            }
        }
        void AddForm(Form addform)
        {
            addform.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(addform);
            addform.Show();

            SaveForm = addform;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_Hello hello = new Frm_HomeWork_Hello();
            CheckForm(hello);
            AddForm(hello);
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_Loan loan = new Frm_HomeWork_Loan();
            CheckForm(loan);
            AddForm(loan);
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_Pos pos = new Frm_HomeWork_Pos();
            CheckForm(pos);
            AddForm(pos);
        }

        private void btnStudentStructForm_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_Student_StructForm SSF = new Frm_HomeWork_Student_StructForm();
            CheckForm(SSF);
            AddForm(SSF);
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_StudentGrade SG = new Frm_HomeWork_StudentGrade();
            CheckForm(SG);
            AddForm(SG);
        }

        private void btnStudentGradeList_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_StudentGrade_List SGL = new Frm_HomeWork_StudentGrade_List();
            CheckForm(SGL);
            AddForm(SGL);
        }

        private void btnClaculate_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_Claculate CLA = new Frm_HomeWork_Claculate();
            CheckForm(CLA);
            AddForm(CLA);
        }

        private void btnForDoWhlie_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_ForDoWhile FDW =new Frm_HomeWork_ForDoWhile();
            CheckForm(FDW);
            AddForm(FDW);
        }

        private void btnOXGame_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_OXGame OX = new Frm_HomeWork_OXGame();
            CheckForm(OX);
            AddForm(OX);
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_ScreenSaver SS = new Frm_HomeWork_ScreenSaver();
            SS.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_Notepad NP = new Frm_HomeWork_Notepad();
            CheckForm (NP);
            NP.Show();
        }

        private void btnDrawPaint_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_DrawPaint DP = new Frm_HomeWork_DrawPaint();
            CheckForm(DP);
            AddForm(DP);
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_PictureViewer PV = new Frm_HomeWork_PictureViewer();
            CheckForm(PV);
            AddForm (PV);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_Guess GS = new Frm_HomeWork_Guess();
            CheckForm(GS);
            AddForm(GS);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_Alarm AL = new Frm_HomeWork_Alarm();
            CheckForm(AL);
            AddForm(AL);
        }
    }
}
