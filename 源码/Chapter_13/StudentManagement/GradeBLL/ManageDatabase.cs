using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBLL
{
    public class ManageDatabase
    {
        GradeDAL.DatabaseDal db = new GradeDAL.DatabaseDal();
        public void BackDb(string backupPath)
        {
            db.BackDb(backupPath);
        }
        public void RestoreDb(string restorePath)
        {
            db.RestoreDb(restorePath);
        }
    }
}
