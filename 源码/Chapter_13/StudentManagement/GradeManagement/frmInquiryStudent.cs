using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace edu.xcu.GradeManagement
{
    public partial class frmInquiryStudent : Form
    {
        public frmInquiryStudent()
        {
            InitializeComponent();
        }

        private void LoadTreeView()
        {
            TreeNode root = new TreeNode("许昌学院");
            root.Tag="";
            this.tvwCollege.Nodes.Add(root);

            //生成院系列表
            GradeBLL.CollegeBLL bllCollege = new GradeBLL.CollegeBLL();
            List<GradeModel.College> listCollege = bllCollege.CollegeList();           

            foreach(var col in listCollege )
            {
                //生成院系节点
                TreeNode collegeNodes =root.Nodes.Add(col.CollegeName);
                collegeNodes.Tag = col.CollegeID;
                //生成班级节点
                GradeBLL.ManageClass school = new GradeBLL.ManageClass();
                //获取班级列表
                List<GradeModel.School> schoolList = school.GetClassList(col.CollegeID);
                foreach(var sh in schoolList)
                {
                    //生成班级节点
                    TreeNode classNode = collegeNodes.Nodes.Add(sh.ClassName);
                    classNode.Tag = sh.ClassID;                    
                }
            }

        }

        private void frmInquiryStudent_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            LoadTreeView();
            this.tvwCollege.ExpandAll();
        }

        private void tvwCollege_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodes=e.Node.Parent as TreeNode;
            string name = e.Node.Text.ToString();
            string id = e.Node.Tag.ToString();
           
            if (name.Equals("许昌学院") || nodes.Text.Equals("许昌学院"))
            {
                MessageBox.Show("请选择一个班级！", "提示");
            }
            else
            {
                GradeBLL.StudentBLL bllStudent = new GradeBLL.StudentBLL();
                
                this.dataGridView1.DataSource = bllStudent.StudentList(id);
            }

        }
    }
}
