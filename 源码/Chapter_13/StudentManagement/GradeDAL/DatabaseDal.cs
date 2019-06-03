using GradeModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace GradeDAL
{
   public class DatabaseDal
    {
        public void BackDb(string backupPath)
        {
            if (File.Exists(backupPath))
            {
                File.Delete(backupPath);
            }
            string strSql = "backup database AddressList to disk=@backupPath";
            SqlParameter[] parameters = {
                    new SqlParameter("@backupPath", backupPath)
                    };
            
            SQLHelper.ExecuteNonQuery(strSql, CommandType.Text, parameters);
        }
        public void RestoreDb(string restorePath)
        {
            string strSql = "Alter Database AddressList Set Offline with Rollback immediate;use master;restore database AddressList from disk=@restorePath With Replace;Alter Database AddressList Set OnLine With rollback Immediate";
            SqlParameter[] parameters = {
                    new SqlParameter("@restorePath", restorePath)  
                    };
            
            SQLHelper.ExecuteNonQuery(strSql, CommandType.Text, parameters);
        }
    }
}
