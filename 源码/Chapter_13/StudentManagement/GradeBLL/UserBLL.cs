using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeDAL;

namespace GradeBLL
{
    public class UserBLL
    {
        GradeDAL.User users = new User();
        public bool Login(GradeModel.User user)
        {

            return users.Login(user);
        }

        public int UpdateUser(GradeModel.User user)
        {
            return users.UpdateUser(user);
        }
    }
}
