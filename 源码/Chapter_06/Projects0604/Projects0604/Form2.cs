using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects0604
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string filePath):this()  
        {
            richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            this.Text = filePath;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text.Substring (0,4)=="新建文档")
            {
                另存为ToolStripMenuItem_Click(this, e);
            }
            else 
            {
                string fileName = Application.StartupPath + "\\" + this.Text.Trim() + ".txt";
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
            }
                 
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "文本文件（*.txt）|*.txt";

            if (saveFileDialog1.ShowDialog ()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            if (fontDlg.ShowDialog() == DialogResult.OK)
                this.richTextBox1.SelectionFont = fontDlg.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
                this.richTextBox1.SelectionColor = color.Color;
        }

    }
}
