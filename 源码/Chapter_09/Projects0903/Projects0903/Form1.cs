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

namespace Projects0903
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "请选择要分割的文件名称";
            DialogResult drTemp = openFileDialog1.ShowDialog();
            if (drTemp == DialogResult.OK && openFileDialog1.FileName != string.Empty)
            {
                textBox1.Text = openFileDialog1.FileName;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         //根据选择来设定分割的小文件的大小
         int iFileSize= Int32.Parse (textBox2.Text) *1024 ; 
　      //如果计算机存在存放分割文件的目录，则全部删除此目录所有文件
        //反之则在计算机创建目录
       　if (Directory.Exists (textBox4.Text) ) 
　     　   Directory.Delete (textBox4.Text ,true ) ; 
　     　Directory.CreateDirectory (textBox4.Text) ;
  
　　     //以文件的全路对应的字符串和文件打开模式来初始化FileStream文件流实例
         FileStream SplitFileStream=new FileStream (textBox1.Text , FileMode.Open ) ; 
　　   　BinaryReader SplitFileReader=new BinaryReader ( SplitFileStream ) ; 
　　      //以FileStream文件流来初始化BinaryReader文件阅读器
　　     byte [ ] TempBytes ; 
　　    //每次分割读取的最大数据
　     　int iFileCount = ( int ) (SplitFileStream.Length / iFileSize ) ; 
　    　//小文件总数
　　    progressBar1.Maximum = iFileCount ;
　　    if ( SplitFileStream.Length % iFileSize != 0 )
             iFileCount++ ;
　　    string [ ] TempExtra = textBox1.Text.Split ('.' ) ;
　　   
        /* 循环将大文件分割成多个小文件 */
　     　for ( int i = 1 ; i <= iFileCount ; i++ ) 
　    　{
          //小文件名
         string sTempFileName = textBox4.Text + "\\" + i.ToString().PadLeft(4, '0') + "." + TempExtra[TempExtra.Length - 1];

　　　 //确定小文件的文件名称
      FileStream TempStream = new FileStream(sTempFileName, FileMode.OpenOrCreate);
　　　 //根据文件名称和文件打开模式来初始化FileStream文件流实例
　　　 BinaryWriter TempWriter = new BinaryWriter (TempStream ) ; 
　　 　//以FileStream实例来创建、初始化BinaryWriter书写器实例 
　　 　TempBytes = SplitFileReader.ReadBytes ( iFileSize ) ; 
　　 　//从大文件中读取指定大小数据
　　 　TempWriter.Write ( TempBytes ) ; 
　　　 //把此数据写入小文件
　　　 TempWriter.Close ( ) ; 
　　　 //关闭书写器，形成小文件
　　　 TempStream.Close ( ) ; 
　　　//关闭文件流
　　　 progressBar1.Value = i - 1 ; 
　  　}
　  　SplitFileReader.Close ( ) ; 
　  　//关闭大文件阅读器
　　   SplitFileStream.Close ( ) ; 
　　   MessageBox.Show ( "分割成功!" ) ;
　　   progressBar1.Value = 0 ;
      }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("请输入文件分割块大小！");
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = folderBrowserDialog1.SelectedPath;              
            }
        }
    }
}
