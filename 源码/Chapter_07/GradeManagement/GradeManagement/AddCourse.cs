using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace edu.xcu.GradeManagement
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();
            string id = this.textBox1.Text.Trim();
            string name = this.textBox2.Text;
            string strSQL = string.Format("INSERT INTO [tb_Course](cid,cname) VALUES('{0}','{1}')",id,name);
           
            using (SqlConnection conn = new SqlConnection(source))
            { 
                //打开连接对象
                 conn.Open();
                //建立命令对象
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                //执行command的方法
                int result=cmd.ExecuteNonQuery();

                if (result>0)
                {
                 MessageBox.Show("课程已成功添加！", "添加课程");
                }
                else
                {
                    MessageBox.Show("课程添加失败！", "添加课程");
                }
                    conn.Close();
             }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
