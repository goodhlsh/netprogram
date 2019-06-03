using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GradeDAL
{
    public class GradeDal
    {
        public bool AddGrade(List<GradeModel.Grade> list)
        {
          //建立命令列表
            List<string> listSQL = new List<string>();
            //遍历成绩列表
            foreach (var grade in list)
            {
                //构建SQL命令
                string strSQL = string.Format("INSERT INTO [tb_Grade](SID,CID,Result,Term)  VALUES('{0}','{1}','{2}','{3}')", grade.SID, grade.CID, grade.Result, grade.Term);
                //将命令添加到列表
                listSQL.Add(strSQL);
            }

            return SQLHelper.ExecuteTransaction(listSQL);
        }
        //修改成绩
        public bool UpdateGrade(List<GradeModel.Grade> list)
        {
            //建立命令列表
            List<string> listSQL = new List<string>();
            //遍历成绩列表
            foreach (var grade in list)
            {
                //构建SQL命令
                string strSQL = string.Format("UPDATE [tb_Grade] SET Result='{0}' WHERE SID='{1}' AND CID='{2}' AND Term='{3}'", grade.Result, grade.SID, grade.CID, grade.Term);
                //将命令添加到列表
                listSQL.Add(strSQL);
            }

            return SQLHelper.ExecuteTransaction(listSQL);
        }
        //获取成绩表
        public DataTable  GradeTables(string cid,string term)
        {
            string strSQL = string.Format("SELECT [SID],[StudentName],[Result] FROM [tb_Grade] INNER JOIN [tb_Student] ON SID=StudentID WHERE CID='{0}' AND Term='{1}'", cid, term);
            return SQLHelper.ExecuteDataTable(strSQL);
        }
        //获取指定学生成绩表
        public DataTable StudentGradeTablesByID(string sid)
        {
            string strSQL = string.Format("SELECT [CourseName],[Result],[Term] FROM [tb_Grade] INNER JOIN [tb_Course] ON CID=CourseID WHERE SID='{0}'", sid);
            return SQLHelper.ExecuteDataTable(strSQL);
        }
    }
}
