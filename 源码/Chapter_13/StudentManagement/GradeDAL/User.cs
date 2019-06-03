using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace GradeDAL
{
    public class User
    {
        //判断用户名和密码是否正确
        public bool Login(GradeModel.User user)
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("select * from [tb_User] where UserID=@UserID and UserPass=@UserPass");
            SqlParameter[] para = { new SqlParameter("@UserID", user.UserID), new SqlParameter("@UserPass", user.UserPass) };
            object obj = SQLHelper.ExecuteScalar(strSQL.ToString(), CommandType.Text, para);

            if (obj != null)
                return true;
            else
                return false;
        }

        public int UpdateUser(GradeModel.User user)
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("update [tb_User] set UserPass=@UserPass where UserID=@UserID");
            SqlParameter[] paras = { new SqlParameter("@UserID", user.UserID), new SqlParameter("@UserPass", user.UserPass) };

            int rows = SQLHelper.ExecuteNonQuery(strSQL.ToString(), CommandType.Text, paras);

            return rows;
        }
    }
}
