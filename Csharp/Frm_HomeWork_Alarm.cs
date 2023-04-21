using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Csharp
{
    public partial class Frm_HomeWork_Alarm : Form
    {
        public Frm_HomeWork_Alarm()
        {
            InitializeComponent();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("hh:mm:ss");

            if (cbSet.Checked &&
                txtH.Text == DateTime.Now.ToString("hh") &&
                txtM.Text == DateTime.Now.ToString("mm") &&
                txtS.Text == DateTime.Now.ToString("ss"))
            {
                SoundPlayer sd = new SoundPlayer();
                sd.SoundLocation = "C:\\Users\\shiao\\Desktop\\Xiao\\Frm_HomeWork\\Csharp\\Resources\\ring.wav";
                sd.Play();
            }
        }

        private void Frm_HomeWork_Alarm_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            textBox3.ForeColor = Color.Black;
        }
    }
}
