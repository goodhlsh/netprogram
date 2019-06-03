using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GradeDAL
{
    public class SchooDal
    {
        //添加班级
        public int AddClass(GradeModel.School s)
        {
            StringBuilder SQL = new StringBuilder();

            SQL.Append("INSERT INTO [tb_Class](ClassID,ClassName,CollegeID)");
            SQL.Append("  VALUES(@ClassID,@ClassName,@CollegeID)");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@ClassID", s.ClassID), new SqlParameter("@ClassName", s.ClassName), new SqlParameter("@CollegeID", s.CollegeID) };

            return SQLHelper.ExecuteNonQuery(SQL.ToString(), CommandType.Text, parameters);
        }
        //修改班级
        public int UpdateClass(GradeModel.School s)
        {
            string strSQL = string.Format("UPDATE [tb_Class] SET ClassName=@ClassName,CollegeID=@CollegeID WHERE ClassID=@ClassID");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@ClassID", s.ClassID), new SqlParameter("@ClassName", s.ClassName), new SqlParameter("@CollegeID", s.CollegeID) };

            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }
        //删除班级
        public int DelteClass(string id)
        {
            string strSQL = string.Format("DELETE FROM [tb_Class] WHERE ClassID=@ClassID");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@ClassID", id) };

            return SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, parameters);
        }
        //根据院系编号查询该院系班级数
        public object GetClassByCollegeID(string id)
        {
            string strSQL = string.Format("select count(*) from [tb_Class] where CollegeID=@CollegeID");

            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@CollegeID", id) };

            return SQLHelper.ExecuteScalar(strSQL, CommandType.Text, parameters);
        }

        public List<GradeModel.School> GetAllClass( )
        {
           List<GradeModel.School> listClass = new List<GradeModel.School>();
           string strSQL = string.Format("SELECT [ClassID],[ClassName],[CollegeID] FROM [tb_Class]");

           using (SqlDataReader dr = SQLHelper.ExecuteReader(strSQL.ToString()))
           {
               //判断是否有数据
               if (dr.HasRows)
               {
                   //循环读取数据
                   while (dr.Read())
                   {
                       GradeModel.School school = new GradeModel.School();

                       school.ClassID = dr["ClassID"].ToString();
                       school.ClassName = dr["ClassName"].ToString();
                       school.CollegeID = dr["CollegeID"].ToString();
                       school.CollegeName = "";

                       //将对象添加到列表
                       listClass.Add(school);
                   }
               }
           }
           return listClass;
        }

        public List<GradeModel.School> GetClassList(string con)
        {
            List<GradeModel.School> listClass = new List<GradeModel.School>();
            string strSQL = "";
           
            if (con=="1")
            {
                strSQL=string.Format("SELECT [ClassID],[ClassName],tb_Class.CollegeID,[CollegeName]  FROM [tb_Class] INNER JOIN [tb_College] ON tb_Class.CollegeID=tb_College.CollegeID"); 
            }
            else 
            {
                strSQL=string.Format("SELECT [ClassID],[ClassName],[CollegeID] FROM [tb_Class] WHERE CollegeID='{0}'",con);
            }
                   

            using (SqlDataReader dr = SQLHelper.ExecuteReader(strSQL.ToString()))
            {
                //判断是否有数据
                if (dr.HasRows)
                {
                    //循环读取数据
                    while (dr.Read())
                    {
                        GradeModel.School school = new GradeModel.School();

                        school.ClassID = dr["ClassID"].ToString();
                        school.ClassName = dr["ClassName"].ToString();
                        school.CollegeID = dr["CollegeID"].ToString();

                        if (con == "1")
                            school.CollegeName = dr["CollegeName"].ToString();
                        else
                            school.CollegeName = "";

                        //将对象添加到列表
                        listClass.Add(school);
                    }
                }
            }
            return listClass;
        }

    }
}
