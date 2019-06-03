using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace edu.xcu.GradeManagement
{
    public partial class AddGradeForm : Form
    {
        private string source = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();

        public AddGradeForm()
        {
            InitializeComponent();
        }
        //添加课程信息
        private void GetCourse()
        {
              using (SqlConnection conn = new SqlConnection(source))
              {
                  SqlDataAdapter da = new SqlDataAdapter("select cid,cname from [tb_Course]", conn);
                  DataSet ds = new DataSet();
                  da.Fill(ds);
                  this.cboCourse.DataSource = ds.Tables[0];
                  this.cboCourse.DisplayMember = "cname";
                  this.cboCourse.ValueMember = "cid";                
               }
        }
        //添加班级信息
        private void GetClass()
        {
            using (SqlConnection conn = new SqlConnection(source))
            {
                SqlDataAdapter da = new SqlDataAdapter("select ClassID, ClassName from [tb_Class]", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.cboClass.DataSource = ds.Tables[0];
                this.cboClass.DisplayMember = "ClassName";
                this.cboClass.ValueMember = "ClassID";
            }
      }
        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            GetCourse();
            GetClass();
        }
        //查询按钮单击事件的相应方法
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = this.cboClass.SelectedValue.ToString ();

            string strSQL = string.Format("SELECT StudentID,StudentName FROM [tb_Student] WHERE classid ='{0}'", id);

            using (SqlConnection sqlcon = new SqlConnection(source))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter sdp = new SqlDataAdapter(strSQL, sqlcon);
                sdp.Fill(ds);

                this.dgvGrade.DataSource = ds.Tables[0];               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string term = this.txtTerm.Text.Trim();
            string cid = this.cboCourse.SelectedValue.ToString() ;
           
            List<string> list = new List<string>();

            foreach (DataGridViewRow dgvRow in dgvGrade.Rows)
            {
                string sid = (string)dgvGrade.Rows[dgvRow.Index].Cells[1].Value;
                string grade = (string)dgvGrade.Rows[dgvRow.Index].Cells[0].Value;

                string sql = string.Format("INSERT INTO [tb_Grade](sid,cid,grade,term) VALUES('{0}','{1}','{2}','{3}')", sid, cid, grade, term);
                list.Add(sql);
            }

             using (SqlConnection conn = new SqlConnection(source))
             {
                 //打开连接对象
                  conn.Open();
                 //开始本地事务
                 SqlTransaction sqlTran = conn.BeginTransaction();
                 //建立命令对象
                SqlCommand command = conn.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    //执行命令
                    foreach(string sql in list)
                    {
                        command.CommandText = sql.ToString();
                        command.ExecuteNonQuery();
                    }                  
                   // 提交事务
                    sqlTran.Commit();
                    Console.WriteLine("Both records were written to database.");
                }
                catch (Exception ex)
                {
                     Console.WriteLine(ex.Message);

                    try
                    {
                        // Attempt to roll back the transaction.
                        sqlTran.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                         Console.WriteLine(exRollback.Message);
                    }                   
                }
              }

            MessageBox.Show("学生成绩添加成功！", "添加学生成绩");
            this.dgvGrade.ReadOnly = true;
        }      

    }
}
