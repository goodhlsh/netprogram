using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace edu.xcu.GradeManagement
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string stuid = this.txtStuID.Text.Trim();

            string sql = string.Format("select StudentID,StudentName,gender,status,age,college,classid,nation from tb_Student where  StudentID='{0}'", stuid);

            string constr = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();
           
            using ( SqlConnection conn=new SqlConnection (constr ))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    sdr.Read();
                    this.txtSID.Text = sdr["StudentID"].ToString();
                    this.txtName.Text = sdr["StudentName"].ToString();
                    this.cboGender.SelectedText = sdr["gender"].ToString();
                    this.txtAge.Text = sdr["age"].ToString();
                    this.cboStatus.SelectedText  = sdr["status"].ToString();
                    this.cboCollege.SelectedText = sdr["college"].ToString();
                    this.cboClass.SelectedText = sdr["classid"].ToString();
                    this.txtPlace.Text = sdr["nation"].ToString();
                }

                sdr.Close();
                conn.Close();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();
            string updatesql = "UPDATE [tb_Student] SET StudentName=@stuname,gender=@gender,age=@age,nation=@nation WHERE StudentID=@stuid";
           
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(updatesql, conn);
                cmd.Parameters.Add("@stuname",SqlDbType.VarChar,50).Value = this.txtName.Text.Trim().ToString ();
                cmd.Parameters.Add("@gender",SqlDbType.VarChar,2).Value = this.cboGender.Text.Trim();
                cmd.Parameters.Add("@age",SqlDbType.VarChar,5).Value = this.txtAge.Text.Trim();
                cmd.Parameters.Add("@nation",SqlDbType.VarChar,50).Value = this.txtPlace.Text.Trim();
                cmd.Parameters.Add("@stuid", SqlDbType.VarChar, 11).Value = this.txtSID.Text.Trim().ToString();

                int rows = Convert.ToInt32 (cmd.ExecuteNonQuery());

                if (rows > 0)
                {
                    MessageBox.Show("学生信息修改成功！", "信息修改");
                }
                else
                {
                    MessageBox.Show("学生信息修改失败！", "信息修改");
                }
                conn.Close();
            }

        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            this.txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string source = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();
            string delsql = "DELETE FROM [tb_Student] WHERE StudentID=@stuid";
           
            using (SqlConnection conn = new SqlConnection(source))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(delsql,conn);
                cmd.Parameters.Add("@stuid", SqlDbType.VarChar, 11).Value = this.txtSID.Text.Trim();

                DialogResult result = MessageBox.Show("您确定要删除吗？", "删除确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {

                    int rows = Convert.ToInt32(cmd.ExecuteNonQuery());

                    if (rows > 0)
                    {
                        MessageBox.Show("学生信息删除成功！", "信息删除");
                    }
                    else
                    {
                        MessageBox.Show("学生信息删除失败！", "信息删除");
                    }
                }               
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtStuID.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
