using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstLeft.HorizontalScrollbar = true;   //显示水平滚动条
            this.lstLeft.ScrollAlwaysVisible = true;    //使垂直滚动条可见
            this.lstLeft.SelectionMode = SelectionMode.MultiExtended;  //可以在控件中选择多项
            this.lstRight.HorizontalScrollbar = true;   //显示水平滚动条
            this.lstRight.ScrollAlwaysVisible = true;    //使垂直滚动条可见
            this.lstRight.SelectionMode = SelectionMode.MultiExtended;  //可以在控件中选择多项
            //向列表控件中添加选项
            this.lstLeft.Items.Clear();
            this.lstLeft.Items.Add("高级语言程序设计");
            this.lstLeft.Items.Add("数据结构与算法");
            this.lstLeft.Items.Add("操作系统原理与实践");
            this.lstLeft.Items.Add("计算机网络");
            this.lstLeft.Items.Add("计算机系统结构");
            this.lstLeft.Items.Add("数据库原理与应用");
        }

        private void btnAllSelction_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstLeft.Items.Count; i++)  //循环遍历左边列表
            {
                this.lstRight.Items.Add(lstLeft.Items[i]);     //将列表添加到右边列表
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.lstRight.Items.Clear();
        }

        private void btnAddSelcted_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLeft.SelectedItems.Count; i++)
            {
                this.lstRight.Items.Add(lstLeft.SelectedItems[i]);     //将列表添加到右边列表
            }
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            for (int i = this.lstRight.SelectedItems.Count - 1; i >= 0; i--)
            {
                this.lstRight.Items.Remove(this.lstRight.SelectedItems[i]);
            }
        }
    }
}