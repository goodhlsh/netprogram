using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Chapter0701
{
    class Program
    {
        static void Main(string[] args)
        {
         //构造连接字符串
         string constr = "Data Source = .\\SQLEXPRESS; Initial Catalog=master; Integrated Security =SSPI";
         SqlConnection conn = new SqlConnection(constr);   //创建连接对象
         conn.Open();                               //打开连接
          if(conn.State == ConnectionState.Open) 
         {
           Console.WriteLine("Database is linked.");
           Console.WriteLine("\nDataSource:{0}",conn.DataSource);
           Console.WriteLine("Database:{0}",conn.Database);
           Console.WriteLine("ConnectionTimeOut:{0}",conn.ConnectionTimeout);
          }

         conn.Close();       //关闭连接
         conn.Dispose();      //释放资源

         if(conn.State == ConnectionState.Closed)
         { 
            Console.WriteLine("\nDatabase is closed.");
          }

          Console.Read();
      }
    }
}
