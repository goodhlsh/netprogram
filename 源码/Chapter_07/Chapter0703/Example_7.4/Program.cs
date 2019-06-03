using System;
using System.Data;

namespace Example_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds=CreateDataSet();       //创建DataSet
            AddUserInfo(ds, "001", "admin", "张三", "15036589210", 30);
            AddUserInfo(ds, "100", "88888", "李四", "13625741036", 40);
            ShowDataSetInfo(ds);
            Console.WriteLine("--------------------------------------------------------------------------");
            ShowDataSetRow(ds);
            Console.ReadKey();
        }

        static DataSet CreateDataSet()
        {
            DataSet ds;                    //声明数据集对象
            DataTable dt;                  //声明数据表对象
            DataColumn col;               

            //创建数据集合对象
            ds = new DataSet("用户数据集");

            //创建第一个数据表：用户编号
            dt = new DataTable("用户编号");
            col = new DataColumn("编号",System.Type.GetType("System.String"));
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            col = new DataColumn("密码",System.Type.GetType("System.String"));
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            ds.Tables.Add(dt);

            //创建第二个数据表：用户信息
            dt = new DataTable("用户信息");
            col = new DataColumn("编号",System.Type.GetType("System.String"));
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            col = new DataColumn("姓名",System.Type.GetType("System.String"));
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            col = new DataColumn("年龄",System.Type.GetType("System.Int32"));
            col.AllowDBNull = false;
            dt.Columns.Add(col);
            dt.Columns.Add("电话", System.Type.GetType("System.String"));
            ds.Tables.Add(dt);

            return ds;
        }

        static void ShowDataSetInfo(DataSet ds)
        {
            Console.Write("DataSet----{0}",ds.DataSetName);
            Console.WriteLine("包含{0}个表，区分大小写={1}，有错误={2}，有变化={3}",
                ds.Tables.Count,ds.CaseSensitive,ds.HasErrors,ds.HasChanges());

            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("DataTable---{0},{1}列，{2}行",dt.TableName,
                    dt.Columns.Count,dt.Rows.Count);
                for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                {
                    DataColumn col = dt.Columns[colIndex];
                    Console.WriteLine("第{0}列：列名=[{1}]，类型=[{2}]，允许空=[{3}]",
                        colIndex,col.ColumnName,col.DataType.ToString(),col.AllowDBNull);
                }
            }
        }

        static void AddUserInfo(DataSet ds, string id, string pwd, string name, string tel, int age)
        {
            DataTable dt;
            DataRow row;

            dt=ds.Tables["用户编号"];
            row = dt.NewRow();
            row["编号"] = id;
            row["密码"] = pwd;
            dt.Rows.Add(row);

            dt = ds.Tables["用户信息"];//或者dt = ds.Tables[1];
            row = dt.NewRow();
            row["编号"] = id;
            row["姓名"] = name;
            row["年龄"] = age;
            row["电话"] = tel;
            dt.Rows.Add(row);
        }

        static void ShowDataSetRow(DataSet ds)
        {
             Console.WriteLine("                数据集信息");

            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("DataTable---{0},{1}列，{2}行", dt.TableName,
                    dt.Columns.Count, dt.Rows.Count);

                foreach (DataRow dr in dt.Rows)
                {
                    for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                    {
                        Console.Write("   "+dr[colIndex].ToString());
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}