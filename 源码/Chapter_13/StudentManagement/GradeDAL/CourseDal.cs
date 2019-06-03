using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GradeDAL
{
    public class CourseDal
    {
        //添加课程
        public int AddCourse(GradeModel.Course c)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append("INSERT INTO [tb_Course](CourseID,CourseName)");
            SQL.Append("  VALUES(@CourseID,@CourseName)");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@CourseID", c.CourseID), new SqlParameter("@CourseName",c.CourseName) };

            return SQLHelper.ExecuteNonQuery(SQL.ToString(), CommandType.Text, parameters);
        }
        //更改课程信息
        public int UpdateCourse(GradeModel.Course c)
        {
            string strSQL = string.Format("UPDATE [tb_Course] SET CourseName=@CourseName WHERE CourseID=@CourseID");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@CourseID", c.CourseID), new SqlParameter("@CourseName", c.CourseName) };

            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }
        //删除课程
        public int DelteCourse(string id)
        {
            string strSQL = string.Format("DELETE FROM [tb_Course] WHERE CourseID=@CourseID");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@CourseID", id) };

            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }
        //获取课程列表
        public List<GradeModel.Course>  CourseList()
        {
            //创建课程集合
            List<GradeModel.Course> list = new List<GradeModel.Course>();
            //构造SQL语句
            string strSQL = string.Format("SELECT [CourseID],[CourseName] FROM [tb_Course]");

            using (SqlDataReader dr = SQLHelper.ExecuteReader(strSQL))
            {
                //判断是否有数据
                if (dr.HasRows)
                {
                    //循环读取数据
                    while (dr.Read())
                    {
                        GradeModel.Course c = new GradeModel.Course();
                        c.CourseID = dr["CourseID"].ToString();
                        c.CourseName = dr["CourseName"].ToString();
                        
                        list.Add(c);
                    }
                }
            }

            return (list.Count > 0 ? list : null);
        }
    }
}
