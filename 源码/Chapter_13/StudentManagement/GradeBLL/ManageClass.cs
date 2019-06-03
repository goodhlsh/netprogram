using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeDAL;
using GradeModel;

namespace GradeBLL
{
    public class ManageClass
    {
        GradeDAL.SchooDal dalSchool = new SchooDal();
        public int AddClass(GradeModel.School sl)
        {
            return dalSchool.AddClass(sl);
        }

        public int DeleteClass(string id)
        {
            GradeDAL.StudentDal student = new GradeDAL.StudentDal();

            object obj = student.CountStudentByClass(id);

            if (Convert.ToInt32(obj) == 0)
            {
                return dalSchool.DelteClass(id);
            }
            else
            {
                return -1;
            }
        }

        public int UpdataClass(GradeModel.School sl)
        {
            return dalSchool.UpdateClass(sl);
        }

        public List<GradeModel.School> GetClassList(string con)
        {
            return dalSchool.GetClassList(con);
        }

        public List<GradeModel.School> GetAllClassList()
        {
            return dalSchool.GetAllClass ();
        }
    }
}
