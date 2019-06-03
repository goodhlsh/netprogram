using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBLL
{
    public class User
    {
        public bool IsUser(Model.User user)
        {
            GradeDAL.User userList = new GradeDAL.User();  //新建用户对象

            return userList.IsUser(user);            
        }
    }
}
