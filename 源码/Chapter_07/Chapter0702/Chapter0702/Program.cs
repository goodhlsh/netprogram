using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Chapter0702
{
    class Program
    {
        static void Main(string[] args)
        {
            //构造连接字符串
            string connstr = @"Data Source=.\SQLEXPRESS; Initial Catalog=db_MyDemo; 
Integrated Security=SSPI";
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                //拼接SQL语句
                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("insert into tb_SelCustomer ");
                strSQL.Append("values(");
                strSQL.Append("'zengxq','0','0','13803743333','zxq@126.com','河南省许昌市八一路88号',12.234556,34.222234,'422900','备注信息')");
                Console.WriteLine("Output SQL:\n{0}", strSQL.ToString());

                //创建Command对象
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL.ToString();

                try
                {
                    conn.Open();//一定要注意打开连接
                    int rows = cmd.ExecuteNonQuery();//执行命令
                    Console.WriteLine("\nResult: {0}行受影响", rows);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nError：\n{0}", ex.Message);
                }
            }
            Console.Read();

        }
    }
}
