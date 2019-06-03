using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBLL
{
    public class CourseBll
    {
        GradeDAL.CourseDal dalCourse = new GradeDAL.CourseDal();

        public int AddCourse(GradeModel.Course c)
        {
            return dalCourse.AddCourse(c);
        }

        public int UpdateCourse(GradeModel.Course c)
        {
            return dalCourse.UpdateCourse(c);
        }

        public List<GradeModel.Course> CourseList()
        {
            return dalCourse.CourseList ();
        }

        public int DeleteCourse(string id)
        {
            GradeDAL.SchooDal dalSchool = new GradeDAL.SchooDal();

            object obj = dalSchool.GetClassByCollegeID(id);


            if (Convert.ToInt32(obj) == 0)
            {
                return dalCourse.DelteCourse(id);
            }
            else
            {
                return -1;
            }
        }

    }
}
