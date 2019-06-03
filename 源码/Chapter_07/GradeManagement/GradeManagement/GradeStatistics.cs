using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace edu.xcu.GradeManagement
{
    public partial class GradeStatistics : Form
    {
        //定义变量
        Graphics g;
        Font font = new Font("Arial", 10, FontStyle.Regular);
        Font font1 = new Font("宋体", 10, FontStyle.Bold);
        Brush Bbrush = Brushes.Blue;
        SolidBrush Wfill = new SolidBrush(Color.Blue);      //定义单色画刷用于填充图形   
        public GradeStatistics()
        {
            InitializeComponent();
        }

        private void GradeStatistics_Load(object sender, EventArgs e)
        {
            string strSQL = string.Format("select [cid],[cname] from [tb_Course]");
            this.cmbCourse.DataSource = GetTable(strSQL);
            this.cmbCourse.DisplayMember = "cname";
            this.cmbCourse.ValueMember = "cid";              
        }
        //从数据库读取数据
        private DataTable  GetTable(string sql)
        {
            string strConn = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();
            using (SqlConnection conn=new SqlConnection (strConn))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);

                return ds.Tables[0];
            }           
        }
        //绘制图表
         private void CreateTable()
        {
            g = this.panel1.CreateGraphics();  //创建Graphics类对象
            g.Clear(Color.White);    //清空图片背景色
           
           LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, this.panel1.Width, this.panel1.Height), Color.Blue, Color.BlueViolet, 1.2f, true);

            g.FillRectangle(Brushes.WhiteSmoke, 0, 0, this.panel1.Width, this.panel1.Height);
            g.DrawString(this.txtTerm.Text + "《" + this.cmbCourse.Text + "》" + "成绩统计图", font1, brush, new PointF(160, 20));
            //画图片的边框线
            g.DrawRectangle(new Pen(Color.Blue), 0, 0, this.panel1.Width - 1, this.panel1.Height - 1);
           
            Pen Rpen = new Pen(Color.Red,3);  //画笔定义 
            //绘制Y轴
            g.DrawLine(Rpen, new Point(30, 40), new Point(30,300));   //Y坐标
            g.DrawLine(Rpen, new Point(30, 40), new Point(20, 50));    //Y坐标 左箭头
            g.DrawLine(Rpen, new Point(30, 40), new Point(40, 50));    //Y坐标 右箭头 
             //绘制X轴
            g.DrawLine(Rpen, new Point(30, 300), new Point(500, 300));  //X坐标 
            g.DrawLine(Rpen, new Point(460,290), new Point(500,300));  //X坐标 上箭头
            g.DrawLine(Rpen, new Point(460,310), new Point(500,300));  //X坐标 下箭头            
          }
         private void DrawTable()
         {
             string[] result = new string[]{ "90-100", "80-90", "70-80", "60-70", "0-60" };
             //x轴
             for (int i = 0; i < 5; i++)
             {
                 g.DrawString(result[i], font, Bbrush, 60+i*80,300);  
             }
             //获取数据
             int[] count = new int[5];
             string strSQL = "select  COUNT(*) AS count from [tb_Grade] where grade>=90 and grade<=100";
             DataTable dt1 = GetTable(strSQL);

             if (dt1.Rows.Count==0)
             {
                 count[0] = 0;
             }
             else
             {
                 count[0] = Convert.ToInt32(dt1.Rows[0][0].ToString()); 
             }

             strSQL = "select COUNT(*) AS count from [tb_Grade] where grade>=80 and grade<90";
             DataTable dt2 = GetTable(strSQL);
             if (dt2.Rows.Count == 0)
             {
                 count[1] = 0;
             }
             else
             {
                 count[1] = Convert.ToInt32(dt2.Rows[0][0].ToString());
             }

             strSQL = "select COUNT(*) AS count from [tb_Grade] where grade>=70 and grade<80";
             DataTable dt3 = GetTable(strSQL);
             if (dt3.Rows.Count == 0)
             {
                 count[2] = 0;
             }
             else
             {
                 count[2] = Convert.ToInt32(dt3.Rows[0][0].ToString());
             }

             strSQL = "select  COUNT(*) AS count from [tb_Grade] where grade>=60 and grade<70";
             DataTable dt4 = GetTable(strSQL);
             if (dt4.Rows.Count == 0)
             {
                 count[3] = 0;
             }
             else
             {
                 count[3] = Convert.ToInt32(dt4.Rows[0][0].ToString());
             }

             strSQL = "select  COUNT(*) AS count from [tb_Grade] where grade>=0 and grade<60";
             DataTable dt5 = GetTable(strSQL);
             if (dt5.Rows.Count == 0)
             {
                 count[4] = 0;
             }
             else
             {
                 count[4] = Convert.ToInt32(dt5.Rows[0][0].ToString());
             }

              //绘制柱状图            
             for (int i = 0; i < 5; i++)
             {
                 //填充图形
                 Rectangle rect = new Rectangle(60 + i * 80, 300-count[i]*40/10, 30, count[i]*40/10);
                 g.FillRectangle(Wfill, rect);
                 //显示数量
                 g.DrawString(count[i].ToString(), font, Brushes.Red, 70 + i * 80, 260 - count[i] * 40 / 10);
             }
         }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateTable();
            DrawTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
