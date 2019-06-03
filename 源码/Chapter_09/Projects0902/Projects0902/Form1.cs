using System;
using System.IO;
using System.Windows.Forms;

namespace Projects0902
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FilterIndex = 1;
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter = "所有文件(*.*)|*.*";

            if(openFileDialog1.ShowDialog ()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName.ToString();
                textBox1.ReadOnly = true;
            }
            string filePath = textBox1.Text.Trim();

            FileInfo finfo = new FileInfo(filePath);   //新建文件对象

            string strCtime, strAtime, strLWtime, strName, strFName, strDName, strISRead;
            long lgLength;
            //获取文件信息
            strCtime = finfo.CreationTime.ToShortDateString();//获取文件创建时间
            strAtime = finfo.LastAccessTime.ToShortDateString();//获取上次访问该文件时间
            strLWtime = finfo.LastWriteTime.ToShortDateString();//获取上次写入文件时间
            strName = finfo.Name;//获取文件名称
            strFName = finfo.FullName;//获取文件的完整目录
            strDName = finfo.DirectoryName;//获取该文件的完整路径
            strISRead = finfo.IsReadOnly.ToString();//获取文件是否只读
            lgLength = finfo.Length;//获取文件长度
            //显示文件信息
            label2.Text = "文件路径：" + strName;
            label3.Text = "创建时间：" + strCtime;
            label4.Text = "上次访问时间：" + strAtime;
            label5.Text = "文件大小：" + Convert.ToString(lgLength);
        }
    }
}
