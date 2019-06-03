using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudentGrade
{
    public partial class AddGradeForm : Form
    {
        private string source = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();

        public AddGradeForm()
        {
            InitializeComponent();
        }
        //添加课程信息
        private void AddCourse()
        {
              using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select cname from tb_Course", conn);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    this.cmbCourse.Items.Add(sdr["cname"].ToString());
                }
                sdr.Close();
                conn.Close();
            }
        }
        //添加班级信息
        private void AddClass()
        {
             using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select ClassName from  tb_Class", conn);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    this.cmbClass.Items.Add(sdr["ClassName"].ToString());
                }
                sdr.Close();
                conn.Close();
            }
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            AddCourse();
            AddClass();
        }
        //查询按钮单击事件的相应方法
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string classname = this.cmbClass.Text.ToString().Trim();

            string SQL = string.Format("SELECT stuid,stuname FROM [tb_Student] INNER JOIN [tb_Class] ON [tb_Student].class =[tb_Class].ClassID WHERE [tb_Class].ClassName LIKE '{0}'", classname);

            using (SqlConnection sqlcon = new SqlConnection(source))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter sdp = new SqlDataAdapter(SQL, sqlcon);
                sdp.Fill(ds);

                this.dgvGrade.DataSource = ds.Tables[0];
                sqlcon.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string term = this.txtTerm.Text.Trim();
            string course = GetCourseID( this.cmbCourse.Text.ToString().Trim());

            foreach (DataGridViewRow dgvRow in dgvGrade.Rows)
            {
                string sid = (string)dgvGrade.Rows[dgvRow.Index].Cells[1].Value;
                string grade = (string)dgvGrade.Rows[dgvRow.Index].Cells[0].Value;
                string sql = string.Format("INSERT INTO [tb_Grade](sid,cid,grade,term) VALUES('{0}','{1}','{2}','{3}')", sid, course, grade, term);

                using (SqlConnection conn = new SqlConnection(source))
                {  //打开连接对象
                    conn.Open();
                    //建立命令对象
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //执行command的方法
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            MessageBox.Show("学生成绩添加成功！", "添加学生成绩");
            this.dgvGrade.ReadOnly = true;
        }

        private string GetCourseID(string name)
        {
            string sql = string.Format("SELECT cid FROM [tb_Course] WHERE cname LIKE '{0}'",name);
            string id = "";
            using (SqlConnection conn = new SqlConnection(source))
            {  //打开连接对象
                conn.Open();
                //建立命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                //执行command的方法
                SqlDataReader  sdr= cmd.ExecuteReader ();
               
                if (sdr.HasRows)
                {
                    sdr.Read();
                    id = sdr["cid"].ToString();  
                }
                sdr.Close();
                conn.Close();
            }

            return id;
        }

    }
}
