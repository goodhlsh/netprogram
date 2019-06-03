using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.BorderStyle = BorderStyle.Fixed3D;    //设置边框样式
            this.richTextBox1.DetectUrls = true;                               //设置自动识别超链接
            this.richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;      //设置滚动条
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();   //实例化打开文件对话框
            openFile.Filter = "rtf文件（*.rtf) |*.rtf";     //设置文件筛选器
            if (openFile.ShowDialog() == DialogResult.OK)     //判断是否选中文件  
            {
                this.richTextBox1.Clear();    //清空文本框
                //加载文件
                this.richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = new Font("楷体", 12, FontStyle.Bold);    //设置文本字体
            this.richTextBox1.SelectionColor = System.Drawing.Color.Red;        //设置文本字体为红色
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();   //实例化打开文件对话框
            openFile.Filter = "bmp文件（*.bmp) |*.bmp|jpg文件（*.jpg) |*.jpg";     //设置文件筛选器
            openFile.Title = "打开图片";
            if (openFile.ShowDialog() == DialogResult.OK)     //判断是否选中文件  
            {
                Bitmap bmp = new Bitmap(openFile.FileName);  //使用选择图片实例化Bitmap
                Clipboard.SetDataObject(bmp, false);      //将图像放于系统剪贴板
                //判断控件是否可以粘贴图片信息
                if (this.richTextBox1.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                    this.richTextBox1.Paste();    //粘贴图片
            }
        }
    }
}
