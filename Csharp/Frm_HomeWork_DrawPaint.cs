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
    public partial class Frm_HomeWork_DrawPaint : Form
    {
        public Frm_HomeWork_DrawPaint()
        {
            InitializeComponent();
        }

        private void Frm_HomeWork_DrawPaint_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }
        int x0 , y0 ;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtColor.BackColor = colorDialog1.Color;
            
        }
        int pensize ;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labSize.Text=trackBar1.Value.ToString();
            pensize = trackBar1.Value;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(colorDialog1.Color, pensize);
                g.DrawLine(p, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                pictureBox1.Refresh();
            }
        }
    }
}
