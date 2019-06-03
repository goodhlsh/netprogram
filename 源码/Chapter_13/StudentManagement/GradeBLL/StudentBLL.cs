using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeDAL;

namespace GradeBLL
{
    public class StudentBLL
    {
        GradeDAL.StudentDal bllStudent = new GradeDAL.StudentDal();

        public GradeModel.Student GetStudentByID(string id)
        {
            return bllStudent.GetStudentByID(id);
        }

         public List<GradeModel.Student> StudentList(string cid)
         {
             return bllStudent.StudentList(cid);
         }

        public int AddStudent(GradeModel.Student student)
        {
            return bllStudent.AddStudent(student);
         }

        public int UpdateStudent(GradeModel.Student student)
        {
            return bllStudent.UpdateStudent(student);           
        }

        public int DeleteStudent(string id)
        {
            return bllStudent.DeleteStudent(id);
        }


    }
}
