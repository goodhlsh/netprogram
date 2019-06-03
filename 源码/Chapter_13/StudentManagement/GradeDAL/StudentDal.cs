using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GradeDAL
{
    public class StudentDal
    {
        //根据学号检索学生
       public GradeModel.Student GetStudentByID(string id)
        {
           //构造SQL命令
            string strSQL = string.Format("SELECT StudentID,StudentName,Gender,Birthday,CollegeID,ClassID,Address  FROM [tb_Student] WHERE StudentID='{0}' ", id);
           //实例化学生对象
            GradeModel.Student student = new GradeModel.Student();

             using (SqlDataReader dr = SQLHelper.ExecuteReader(strSQL.ToString()))
            {
                //判断是否有数据
                if (dr.HasRows)
                {
                    //循环读取数据
                    dr.Read();

                    student.StudentID = dr["StudentID"].ToString().Trim();
                    student.StudentName = dr["StudentName"].ToString().Trim();
                    student.Gender = dr["Gender"].ToString().Trim();
                    student.Birthday = dr["Birthday"].ToString().Trim();
                    student.CollegeID = dr["CollegeID"].ToString().Trim();
                    student.ClassID = dr["ClassID"].ToString().Trim();
                    student.Address = dr["Address"].ToString().Trim();
                }
            }
             
           return student;   
        }

        public object CountStudentByClass(string cid)
       {
           string strSQL = string.Format("select count(*) from [tb_Student] where ClassID=@ClassID");

           SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@ClassID",cid) };

            return SQLHelper.ExecuteScalar(strSQL, CommandType.Text, parameters);
       }
        //返回学生列表
        public List<GradeModel.Student> StudentList(string cid)
       {
            //创建一个学生集合
           List<GradeModel.Student> list = new List<GradeModel.Student>();
            //构造查询语句
           string strSQL = string.Format("SELECT StudentID,StudentName,Gender,Birthday,CollegeID,ClassID,Address  FROM [tb_Student] WHERE ClassID='{0}'",cid);

           using (SqlDataReader dr = SQLHelper.ExecuteReader(strSQL))
           {
               //判断是否有数据
               if (dr.HasRows)
               {
                   //循环读取数据
                   while (dr.Read())
                   {
                       //创建学生实体对象
                       GradeModel.Student stu = new GradeModel.Student();

                       stu.StudentID = dr["StudentID"].ToString();
                       stu.StudentName = dr["StudentName"].ToString();
                       stu.Gender = dr["Gender"].ToString();
                       stu.Birthday = dr["Birthday"].ToString();
                       stu.CollegeID = dr["CollegeID"].ToString();
                       stu.ClassID = dr["ClassID"].ToString();
                       stu.Address = dr["Address"].ToString();
                       //将学生对象添加到列表
                       list.Add(stu);
                   }
               }
           }
           return list;
       }       
        //删除学生
        public int DeleteStudent(string id)
        {
            string strSQL = string.Format("DELETE FROM [tb_Student] WHERE StudentID=@StudentID");
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@StudentID", id) };
            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }

        //添加学生
        public int AddStudent(GradeModel.Student student)
        {
            StringBuilder strSQL = new StringBuilder();

            strSQL.Append("INSERT INTO [tb_Student](StudentID,StudentName,Gender,Birthday,CollegeID,ClassID,Address)");
            strSQL.Append(" VALUES(@StudentID,@StudentName,@Gender,@Birthday,@CollegeID,@ClassID,@Address)");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@StudentID", student.StudentID), new SqlParameter("@StudentName", student.StudentName), new SqlParameter("@Gender", student.Gender), new SqlParameter("@Birthday", student.Birthday), new SqlParameter("@ClassID", student.ClassID), new SqlParameter("@CollegeID", student.CollegeID), new SqlParameter("@Address", student.Address) };

            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }
        //修改学生信息
        public int UpdateStudent(GradeModel.Student student)
        {
            //构造SQL语句
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("UPDATE [tb_Student] SET   ");
            strSQL.Append("StudentName=@StudentName,Gender=@Gender,Birthday=@Birthday,");
            strSQL.Append("CollegeID=@CollegeID,ClassID=@ClassID,Address=@Address");
            strSQL.Append("   WHERE StudentID=@StudentID ");
            //参数数组
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@StudentID", student.StudentID), new SqlParameter("@StudentName", student.StudentName), new SqlParameter("@Gender", student.Gender), new SqlParameter("@Birthday", student.Birthday), new SqlParameter("@ClassID", student.ClassID), new SqlParameter("@CollegeID", student.CollegeID), new SqlParameter("@Address", student.Address) };
            //执行SQL语句
            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }
    }
}
