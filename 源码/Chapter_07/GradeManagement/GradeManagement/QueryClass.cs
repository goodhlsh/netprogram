using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace edu.xcu.GradeManagement
{
    public partial class QueryClass : Form
    {
        //从App.Config中读取连接字符串
        private string source = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();

        public QueryClass()
        {
            InitializeComponent();
        }

        private void CreateTreeView()
        {
            TreeNode RootNode=new TreeNode("河南理工学院");
            this.tvwCollege.Nodes.Add(RootNode);

            string college = "select CollegeID,CollegeName from [tb_College]";
            DataSet ds;            
            SqlDataAdapter sqlad;
            DataTable dtCollege;
            DataTable dtClass=null;

            using (SqlConnection sqlcon = new SqlConnection(source))
            {
                 sqlad = new SqlDataAdapter(college,sqlcon);
                 ds = new DataSet();
                 sqlad.Fill(ds, "College");
                 dtCollege = ds.Tables["College"];

                 for (int i = 0; i < dtCollege.Rows.Count; i++)
                 {
                   TreeNode collegeNode = new TreeNode(dtCollege.Rows[i]["CollegeName"].ToString());
                   collegeNode.Tag = dtCollege.Rows[i]["CollegeID"].ToString();
                   RootNode.Nodes.Add(collegeNode);

                   string strClass = string.Format("select ClassID,ClassName from [tb_Class] where CollegeID='{0}'", dtCollege.Rows[i]["CollegeID"].ToString().Trim());
                    //根据院系，取出班级
                    sqlad = new SqlDataAdapter(strClass,sqlcon);
                    sqlad.Fill(ds, "tb_Class");
                    dtClass = ds.Tables["tb_Class"];

                    for (int j = 0; j < dtClass.Rows.Count; j++)
                    {
                        TreeNode classNodes =new TreeNode ( dtClass.Rows[j]["ClassName"].ToString());
                        classNodes.Tag = dtClass.Rows[j]["ClassID"].ToString().Trim();
                        collegeNode.Nodes.Add(classNodes);
                    }

                    ds.Tables["tb_Class"].Clear();  //清除班级表中的数据
                }
             }            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClass_Load(object sender, EventArgs e)
        {
            CreateTreeView();
            this.tvwCollege.ExpandAll();
        }
        /// <summary>
        /// 选择树形控件的节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwCollege_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvwCollege.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (e.Node.Nodes.Count!=0)
            {
                MessageBox.Show("请选择班级！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                string id = (string)(this.tvwCollege.SelectedNode.Tag);  //获取选择节点的Tag
                this.dgvStudent.DataSource = GetStudentInfomation(id);  
            }                    
        }
         private DataTable GetStudentInfomation(string classID)
        {
            //构造查询语句
            string sql = string.Format("SELECT StudentID,StudentName, gender,status,age,ClassName,nation FROM [tb_Student] INNER JOIN [tb_Class] ON [tb_Student].classid =[tb_Class].ClassID WHERE [tb_Student].classid LIKE '{0}'", classID);

            using (SqlConnection sqlcon = new SqlConnection(source))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter sdp = new SqlDataAdapter(sql, sqlcon);                               
                sdp.Fill(ds);

                return ds.Tables[0];              
            }
        }


        /*
        private void AddStudent()
        {
            Sudent[] stu = new Sudent[] { new Sudent("01", "01", "男", "2013"), new Sudent("02", "02", "男", "2013") };
            this.dgvStudent.DataSource = stu;
        }

        private void AddTree()
        {
            TreeNode topNode = new TreeNode("许昌学院");
            this.tvwCollege.Nodes.Add(topNode);

            TreeNode pNode1 = new TreeNode("信息工程学院");
            TreeNode pNode2 = new TreeNode("通信工程学院");
            TreeNode pNode3 = new TreeNode("机电工程学院");
            TreeNode pNode4 = new TreeNode("机械工程学院");
            TreeNode pNode5 = new TreeNode("土木工程学院");

            topNode.Nodes.Add(pNode1);
            topNode.Nodes.Add(pNode2);
            topNode.Nodes.Add(pNode3);
            topNode.Nodes.Add(pNode4);
            topNode.Nodes.Add(pNode5);

            pNode1.Nodes.Add("2013级计算机科学班");
            pNode1.Nodes.Add("2013级网络工程班");
            pNode1.Nodes.Add("2013级数字媒体班");
            pNode1.Nodes.Add("2013级物联网工程班");
           
        }
         * */

       
    }
}
