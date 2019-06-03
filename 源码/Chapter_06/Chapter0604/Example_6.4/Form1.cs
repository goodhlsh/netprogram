using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //窗体装入事件
        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.LabelEdit = true;     //可编辑状态
            treeView1.ContextMenuStrip = contextMenuStrip1;      //设置树控件的上下文菜单              
        }
        //添加节点
        private void AddNodes()
        {
            TreeNode root = treeView1.Nodes.Add("许昌学院");   //建立顶层节点
            //建立4个基础节点
            TreeNode ParentNode1 = root.Nodes.Add("通信工程学院");
            TreeNode ParentNode2 = root.Nodes.Add("机电工程学院");
            TreeNode ParentNode3 = root.Nodes.Add("信息工程院");
            TreeNode ParentNode4 = root.Nodes.Add("机械工程学院");
            //向基础节点添加子节点
            ParentNode1.Nodes.Add("2015级通信工程班");
            ParentNode1.Nodes.Add("2014级通信工程班");
            ParentNode1.Nodes.Add("2013级通信工程班");

            ParentNode2.Nodes.Add("2015级电子信息班");
            ParentNode2.Nodes.Add("2014级电子信息班");
            ParentNode2.Nodes.Add("2013级电子信息班");

            ParentNode3.Nodes.Add("2015级计算机班");
            ParentNode3.Nodes.Add("2015级网络工程班");
            ParentNode3.Nodes.Add("2015级软件工程班");

            ParentNode4.Nodes.Add("2015级机械工程班");
            ParentNode4.Nodes.Add("2014级机械工程班");
            ParentNode4.Nodes.Add("2013级机械工程班");            
        }
        //添加节点
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNodes();
        }
        //删除节点
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Nodes.Count == 0)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            else
            {
                MessageBox.Show("请先删除此节点中的子节点！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //编辑节点
        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.BeginEdit();
        }
        //全部展开
        private void 全部展开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
        //全部折叠
        private void 全部折叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
