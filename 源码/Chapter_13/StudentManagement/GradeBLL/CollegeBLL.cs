using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBLL
{
    public class CollegeBLL
    {
      GradeDAL.CollegeDal  bllCollege = new GradeDAL.CollegeDal ();
      public int AddCollege(GradeModel.College c)
      {
          return bllCollege.AddCollege(c);
      }
        public int UpdateCollege(GradeModel.College c)
      {
          return bllCollege.UpdateCollege(c);
      }

        public List<GradeModel.College> CollegeList()
        {
            return bllCollege.CollegeList();
        }

        public GradeModel.College GetCollege(string con)
        {
            return bllCollege.GetCollege(con);
        }

        public int DeleteCollege(string id)
        {
            GradeDAL.GradeDal dalGrade = new GradeDAL.GradeDal();

            object obj ="";
            
           
            if(Convert.ToInt32 (obj)==0) 
            {
                return bllCollege.DelteCollege(id);
            }
            else
            {
                return -1;
            }
        }
    }
}
