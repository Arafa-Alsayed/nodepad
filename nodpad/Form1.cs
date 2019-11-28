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

namespace nodpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "";
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                path = op.FileName;
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
               
            }
            string namef = Path.GetFileName(op.FileName);
            this.Text = namef;
        }
     
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sav = new SaveFileDialog();
            sav.Filter = "files.txt|.*txt";
            if(sav.ShowDialog()==DialogResult.OK)
            {
                path = sav.FileName;
               
                if(sav.FileName!=null)
                {

                    richTextBox1.SaveFile(sav.FileName, RichTextBoxStreamType.PlainText);
                }

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fo = new FontDialog();
            fo.Font = richTextBox1.SelectionFont;
            if (fo.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fo.Font;
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorback = new ColorDialog();
            if (colorback.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = colorback.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("version 1.0.3 ,notpad");
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
