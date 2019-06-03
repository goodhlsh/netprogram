using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exanple_6._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //打开按钮单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = @"c:\Documents and Settings\AllUsers\Documents\MyPictures";    //设置打开对话框显示的初始目录
            this.openFileDialog1.Filter = "bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif|jpeg文件(*.jpg)|*.jpg";       //设定筛选器字符串
            this.openFileDialog1.FilterIndex = 3;          //设置打开文件对话框中当前筛选器的索引
            this.openFileDialog1.RestoreDirectory = true;    //关闭对话框还原当前目录
            this.openFileDialog1.Title = "选择图片";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;     //图像伸缩
                string path = this.openFileDialog1.FileName;    //获取打开文件路径
                this.pictureBox1.Image = Image.FromFile(path);     //加载图片
                this.richTextBox1.Text="文件名："+this.openFileDialog1.FileName.Substring (path.LastIndexOf ("\\")+1);
            }
        }
        //保存按钮单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                this.saveFileDialog1.Filter = "JPEG图像(*.jpg)|*.jpg|Bitmap图像(*.bmp)|*.bmp|Gif图像(*.gif)|*.gif";
                this.saveFileDialog1.Title = "保存图片";
                this.saveFileDialog1.CreatePrompt = true;      //如果指定文件不存在，提示允许创建新文件
                this.saveFileDialog1.OverwritePrompt = true;  //如果用户指定文件存在，显示警告信息
                this.saveFileDialog1.ShowDialog();      //弹出保存文件对话框

                if (this.saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)this.saveFileDialog1.OpenFile();
                    switch (this.saveFileDialog1.FilterIndex)     //选择保存文件类型
                    {
                        case 1:
                            this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);   //保存为JPEG文件
                            break;
                        case 2:
                            this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);   //保存为BMP文件
                            break;
                        case 3:
                            this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);   //保存为GIF文件
                            break;
                    }
                    fs.Close();     //关闭文件流
                }
                else
                {
                    MessageBox.Show("请选择保存的图片", "图片浏览器");
                }
            }
        }
        //字体按钮单击事件
        private void button3_Click(object sender, EventArgs e)
        {
            this.fontDialog1.AllowVerticalFonts = true;  //显示垂直字体和水平字体
            this.fontDialog1.FixedPitchOnly = true;    //只允许选择固定间距字体
            this.fontDialog1.ShowApply = true;        //包含应用按钮
            this.fontDialog1.ShowEffects = true;     //允许删除线、下划线和文本选择颜色选项的控件
            this.richTextBox1.SelectAll();
            this.fontDialog1.AllowScriptChange = true;
            this.fontDialog1.ShowColor = true;

            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.Font = this.fontDialog1.Font;   //设置文本框中的字体为选定字体
            }
        }
        //颜色按钮单击事件
        private void button4_Click(object sender, EventArgs e)
        {
            this.colorDialog1.AllowFullOpen = true;   //可以自定义颜色
            this.colorDialog1.AnyColor = true;     //显示颜色集中所有可用颜色
            this.colorDialog1.FullOpen = true;    //创建自定义颜色的控件在对话框打开时可见
            this.colorDialog1.SolidColorOnly = true;     //不限制只选择纯色
            this.colorDialog1.ShowDialog();
            //设置文本框字体颜色为选定颜色
            this.richTextBox1.ForeColor = this.colorDialog1.Color;
        }
    }
}
