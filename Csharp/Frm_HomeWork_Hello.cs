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
    public partial class Frm_HomeWork_Hello : Form
    {
        public Frm_HomeWork_Hello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EnName = txtEnName.Text;
            string Gender = txtGender.Text;
            string Star = txtStar.Text;
            MessageBox.Show("Hello,我是"+Name+"\n英文名字是"+EnName+"\n性別是"+Gender+
                "\n星座是"+ Star+"\n很高興認識你。");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EnName = txtEnName.Text;
            string Gender = txtGender.Text;
            string Star = txtStar.Text;

            MessageBox.Show("Hi,我是" + Name + "\n英文名字是" + EnName + "\n性別是" + Gender +
                "\n星座是" + Star + "\n很高興認識你。");
        }
    }
}
