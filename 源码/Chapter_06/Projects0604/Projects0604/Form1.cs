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
    public partial class Form1 : Form
    {
        private static int formCount = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            childForm.Text = "新建文档"+formCount.ToString ();   
            childForm.MdiParent = this;
            childForm.Show();
            formCount++;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";

            if (openFileDialog1.ShowDialog ()==DialogResult.OK)
            {
                Form2 childForm = new Form2(openFileDialog1.FileName);
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void 水平布局ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 全部最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form childForm in MdiChildren)
            {
                childForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void 全部最大化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.WindowState = FormWindowState.Maximized ;
            }
        }
    }
}
