using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GradeBLL
{
    public class GradeBll
    {
        GradeDAL.GradeDal dalGrade = new GradeDAL.GradeDal();
        public bool AddGrade(List<GradeModel.Grade> list)
        {
            return dalGrade.AddGrade(list);
        }

        public bool UpdateGrade(List<GradeModel.Grade> list)
        {
            return dalGrade.UpdateGrade(list);
        }

        public  DataTable  GradeTables(string cid,string term)
        {
            return dalGrade.GradeTables(cid, term);
        }
        public DataTable StudentGradeTablesByID(string sid)
        {
            return dalGrade.StudentGradeTablesByID(sid);
        }


    }
}
