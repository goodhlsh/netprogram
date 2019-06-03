using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace GradeDAL
{
    public class User
    {
      public bool IsUser(Model.User  user)
        {
            bool isUser = false;

           string strSQL = string.Format("select [UserName] from [tb_Users] where UserID=@id and UserPassword=@pass");

            SqlParameter[] parameters = new SqlParameter[2]{ new SqlParameter("@id",SqlDbType.Char,5), new SqlParameter("@pass", SqlDbType.NVarChar,10)};
            parameters[0].Value = user.ID;
            parameters[1].Value = user.Pass;
                    
            DataTable  dt = SQLHelper.ExecuteDataTable (strSQL, CommandType.Text, parameters);

            if (dt.Rows.Count>0)
            {
                if (dt.Rows[0]["UserName"] != null && dt.Rows[0]["UserName"].ToString() !="")
                {
                    user.Name = dt.Rows[0]["UserName"].ToString();
                    isUser = true;
                }               
            }
            return isUser;            
        }
    }
}
