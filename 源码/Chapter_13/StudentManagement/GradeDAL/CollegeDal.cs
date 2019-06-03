using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GradeModel;

namespace GradeDAL
{
    public class CollegeDal
    {
        //添加院系
        public int AddCollege(GradeModel.College college)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append("INSERT INTO [tb_College](CollegeID,CollegeName)");
            SQL.Append("  VALUES(@CollegeID,@CollegeName)");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@CollegeID", college.CollegeID), new SqlParameter("@CollegeName", college.CollegeName) };

            return SQLHelper.ExecuteNonQuery(SQL.ToString(), CommandType.Text, parameters);
        }
        //更改院系信息
        public int UpdateCollege(GradeModel.College college)
        {
            string strSQL = string.Format("UPDATE [tb_College] SET CollegeName=@CollegeName WHERE CollegeID=@CollegeID");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@CollegeID", college.CollegeID), new SqlParameter("@CollegeName", college.CollegeName) };

            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }
        //删除院系
        public int DelteCollege(string id)
        {
            string strSQL = string.Format("DELETE FROM [tb_College] WHERE CollegeID=@CollegeID");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@CollegeID", id) };

            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }
        //获取院系列表
        public List<College> CollegeList()
        {
            //创建院系集合
            List<College> listCollege = new List<College>();
            //构造SQL语句
            string strSQL = string.Format("SELECT [CollegeID],[CollegeName] FROM [tb_College]");
            
            using(SqlDataReader dr=SQLHelper.ExecuteReader (strSQL))
            {
                //判断是否有数据
                if (dr.HasRows)
                {
                    //循环读取数据
                    while(dr.Read())
                    {
                        College col = new College();

                        col.CollegeID = dr["CollegeID"].ToString();
                        col.CollegeName =(string)(dr["CollegeName"]);

                        listCollege.Add(col);

                    }
                }                
            }                   

            return (listCollege.Count>0? listCollege :null);
        }

        public GradeModel.College  GetCollege(string con)
        {
            GradeModel.College depart = new College();

            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("SELECT [CollegeID],[CollegeName]  FROM [tb_College] WHERE 1=1");

            if (string.IsNullOrEmpty (con))
            {
                strSQL.Append("  AND  " + con);
            }

            using (SqlDataReader dr = SQLHelper.ExecuteReader(strSQL.ToString()))
            {
                //判断是否有数据
                if (dr.HasRows)
                {
                    //循环读取数据
                    dr.Read();
                    depart.CollegeID = dr["CollegeID"].ToString();
                    depart.CollegeName = dr["CollegeName"].ToString();
                }
            }
            return depart;
        }
    }
}
