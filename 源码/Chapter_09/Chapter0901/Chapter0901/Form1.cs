using System;
using System.IO;
using System.Windows.Forms;

namespace Chapter0901
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
               MessageBox.Show("文件名不能为空！", "信息提示");
             }
           else
           {
             if (File.Exists(textBox1.Text))
                MessageBox.Show("该文件已经存在", "信息提示");
             else
               File.Create(textBox1.Text);
            }
        }  
    }
}
