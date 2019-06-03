using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_6._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;    //设置显示视图为Detail
            //添加列标题
            this.listView1.Columns.Add("姓名", 90, HorizontalAlignment.Center);
            this.listView1.Columns.Add("性别", 60, HorizontalAlignment.Center);
            this.listView1.Columns.Add("专业", 120, HorizontalAlignment.Center );
            this.listView1.Columns.Add("毕业学校", 220, HorizontalAlignment.Center);  
            //初始化列表项数据
			string[] subItem0={"王斌","男","计算机科学与技术","武汉大学"};
			this.listView1.Items.Add (new ListViewItem(subItem0));			
			string[] subItem1={"汪兰","女","财会电算化","西南财经大学"};
			this.listView1.Items.Add(new ListViewItem(subItem1));
		    string[] subItem2={"汤波","男","软件工程","上海交通大学"};
			this.listView1.Items.Add(new ListViewItem(subItem2));
            string[] subItem3 = { "张倩", "女", "经济管理", "中央财经大学" };
            this.listView1.Items.Add(new ListViewItem(subItem3));
            //添加控件图标索引
			this.listView1.Items[0].ImageIndex=0;
            this.listView1.Items[1].ImageIndex = 1;
            this.listView1.Items[2].ImageIndex = 2;
            this.listView1.Items[3].ImageIndex = 3;	
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //以大图标方式显示列表项数据
            this.listView1.View = View.LargeIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //以小图标方式显示列表项数据
            this.listView1.View = View.SmallIcon;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //以详细资料方式显示列表项数据
            this.listView1.View = View.Details;
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            //增加化列表项数据
            string[] subItem = { "罗成", "男","工业与民用建筑", "重庆大学" };
            this.listView1.Items.Add(new ListViewItem(subItem));
            this.listView1.Items[4].ImageIndex = 4;	
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //删除已经选择的列表项数据
            for (int i = this.listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = this.listView1.SelectedItems[i];
                this.listView1.Items.Remove(item);
            }
        }
    }
}
