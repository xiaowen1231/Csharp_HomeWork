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
    public partial class Frm_HomeWork_ScreenSaver : Form
    {
        public Frm_HomeWork_ScreenSaver()
        {
            InitializeComponent();
        }

        private void Frm_HomeWork_ScreenSaver_Load(object sender, EventArgs e)
        {
            Original = Cursor.Position;
        }

        private void Frm_HomeWork_ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        Point Original;

        private void Frm_HomeWork_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            Point Current = Cursor.Position;
            if (Original != Current)
            {
                Close();
            }
        }
        int ImageX = 20 , ImageY=20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbScreenImage.Location.X + pbScreenImage.Width > ClientSize.Width ||
        pbScreenImage.Location.X < 0)
            {
                ImageX = -ImageX;
            }
            if (pbScreenImage.Location.Y + pbScreenImage.Height > ClientSize.Height ||
                pbScreenImage.Location.Y < 0)

            {
                ImageY = -ImageY;
            }

            pbScreenImage.Location = new Point(pbScreenImage.Location.X + ImageX,
                pbScreenImage.Location.Y + ImageY);
        }
    }
}
