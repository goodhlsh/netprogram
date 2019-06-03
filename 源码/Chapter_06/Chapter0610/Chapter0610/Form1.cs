using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter0610
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();                   //创建OpenFileDialog对象
            ofdlg.Filter = "文本文件(*.txt)|*.TXT|Word文件(*.doc)|*.DOC"; //只选择TXT和DOC扩展名文件
            ofdlg.Title = "选择文本文件或Word文件";                      //设置对话框的标题
            if (ofdlg.ShowDialog() == DialogResult.OK)                       //显示对话框，并等待返回
            {
                this.txtOpenFileName.Text = ofdlg.FileName;      //如果用户选择了文件则显示到界面
            }
            else
            {
                this.txtOpenFileName.Text = "还没有选择要打开的文件";     //没有选择文件，则显示默认提示
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new SaveFileDialog();                   //创建SaveFileDialog对象
            sfdlg.Filter = "文本文件(*.txt)|*.TXT";                        //默认扩展名为*.TXT
            sfdlg.Title = "请选择或输入要保存的文本文件";
            if (sfdlg.ShowDialog() == DialogResult.OK)                       //显示对话框，并等待返回
            {
                this.txtSaveFileName.Text = sfdlg.FileName;                  //如果用户选择了文件则显示到界面
            }
            else
            {
                this.txtSaveFileName.Text = "还没有选择要保存的文件";     //没有选择文件，则显示默认提示
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fdlg = new FontDialog();                          //创建FontDialog对象
            fdlg.Font = this.button3.Font;                             //设置默认字体为button3当前字体
            if (fdlg.ShowDialog() == DialogResult.OK)              //显示对话框，并等待返回
            {
                this.button3.Font = fdlg.Font;         //选择了新的字体，则更新button3的字体
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是第一个消息框，只有确认按钮");                          //显示最简单的MessageBox
            MessageBox.Show("这是第二个消息框，有标题，只有确认按钮", "第二个消息框");   //显示有文本和标题的MessageBox
            //显示具有文本、标题、确定和取消按钮的MessageBox
            MessageBox.Show("这是第三个消息框，有标题，只有确认和取消按钮",
                            "第三个消息框", MessageBoxButtons.OKCancel);
            //显示具有文本、标题、确定和取消按钮、告警图标的MessageBox
            MessageBox.Show("这是第四个消息框，有标题，只有确认和取消按钮，告警图标",
                            "第四个消息框", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }
    }
}
