using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp
{
    public partial class Frm_HomeWork_Notepad : Form
    {
        public Frm_HomeWork_Notepad()
        {
            InitializeComponent();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNotepad.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,  txtNotepad.Text,  Encoding.UTF8);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName=="") 
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK) 
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtNotepad.Text, Encoding.UTF8);
                }
            } 
            else 
            {
                File.WriteAllText(openFileDialog1.FileName, txtNotepad.Text, Encoding.UTF8);
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            txtNotepad.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectAll();
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtNotepad.ForeColor = colorDialog1.Color;
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtNotepad.Font = fontDialog1.Font;
        }

        bool flag = true;
        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flag) 
            {
                txtNotepad.WordWrap = false;
                flag = !flag;
            }
            else 
            {
                txtNotepad.WordWrap = true;
                flag = !flag;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.ForeColor= Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.ForeColor = Color.Black;
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            txtNotepad.Clear();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK) 
            {
                txtNotepad.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);
            }
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtNotepad.Text, Encoding.UTF8);
                }
            }
            else 
            {
                File.WriteAllText(openFileDialog1.FileName, txtNotepad.Text, Encoding.UTF8);
            }
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            txtNotepad.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            txtNotepad.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            txtNotepad.Paste();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stsTime.Text = DateTime.Now.ToString("tt:hh:mm:ss") ;
        }
    }
}
