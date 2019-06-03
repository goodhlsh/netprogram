using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter0902
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("文件夹名称不能为空！", "信息提示");
            }
            else
            {
                if (Directory.Exists(textBox1.Text))
                {
                    MessageBox.Show("该文件夹已经存在", "信息提示");
                }
                else
                {
                    Directory.CreateDirectory(textBox1.Text);
                }
                //返回指定目录中文件的名称
                string[] fileName = new string[] { };
                fileName = Directory.GetFiles("E:\\软件工程");
                //编列该目录下的文件
                foreach (string strV in fileName)
                    MessageBox.Show(strV, "文件信息显示");
            }
        }
    }
}
