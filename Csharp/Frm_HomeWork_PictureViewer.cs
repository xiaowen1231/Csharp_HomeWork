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
    public partial class Frm_HomeWork_PictureViewer : Form
    {
        public Frm_HomeWork_PictureViewer()
        {
            InitializeComponent();
        }

        void ShowImage (PictureBox pb)
        {
            Frm_PictureBox_Show PBS = new Frm_PictureBox_Show();
            PBS.pbShow.Image = pb.Image;
            PBS.Show();
        } 
        private void pbSave1_Click(object sender, EventArgs e)
        {
            Frm_PictureBox_Show PBS = new Frm_PictureBox_Show();
            //PBS.pbShow.Image = pbSave1.Image;
            PBS.pbShow.Image = new Bitmap(pbSave1.Image);
            PBS.Show();
        }

        private void pbSave2_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave2);
        }

        private void pbSave3_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave3);
        }
        private void pbSave4_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave4);
        }
        private void pbSave5_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave5);
        }

        private void pbSave6_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave6);
        }

        private void pbSave7_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave7);

        }

        private void pbSave8_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave8);

        }

        private void pbSave9_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave9);

        }

        private void pbSave10_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave10);

        }

        private void pbSave11_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave11);

        }

        private void pbSave12_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave12);

        }

        private void pbSave13_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave13);

        }

        private void pbSave14_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave14);

        }

        private void pbSave15_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave15);

        }

        private void pbSave16_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave16);

        }

        private void pbSave17_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave17);

        }

        private void pbSave18_Click(object sender, EventArgs e)
        {
            ShowImage(pbSave18);

        }
    }
}
