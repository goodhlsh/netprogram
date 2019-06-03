using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing; 

namespace edu.xcu.GradeManagement
{
    public partial class LoginForm : Form
    {
        private const int iVerifyCodeLength =4; //随机码的长度
        private String strVerifyCode = "";//随机码
        public LoginForm()
        {
            InitializeComponent();
            UpdateVerifyCode();
        }
        //更新验证码
        private void UpdateVerifyCode()
        {
            strVerifyCode = CreateRandomCode(iVerifyCodeLength);
            CreateImage(strVerifyCode);
        }

        private string CreateRandomCode(int iLength)
        {
            int rand;
            char code;
            string randomCode = String.Empty;
            //生成一定长度的验证码
            System.Random random = new Random();
            for (int i = 0; i < iLength; i++)
            {
                rand = random.Next();

                if (rand % 3 == 0)
                {
                    code = (char)('A' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }

                randomCode += code.ToString();
            }
            return randomCode;
        }

        ///  创建随机码图片
        private void CreateImage(string strVerifyCode)
        {
            try
            {
                int iRandAngle = 45;    //随机转动角度
                int iMapWidth = (int)(strVerifyCode.Length * 21);
                Bitmap map = new Bitmap(iMapWidth, 28);     //创建图片背景

                Graphics graph = Graphics.FromImage(map);
                graph.Clear(Color.AliceBlue);//清除画面，填充背景
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);//画一个边框
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式

                Random rand = new Random();
                //背景噪点生成
                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i < 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }
                //验证码旋转，防止机器识别
                char[] chars = strVerifyCode.ToCharArray();//拆散字符串成单字符数组
                 //文字距中
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                //定义颜色
                Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
                //定义字体
                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };

                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(7);
                    int findex = rand.Next(5);

                    Font f = new System.Drawing.Font(font[findex], 13, System.Drawing.FontStyle.Bold);//字体样式(参数2为字体大小)
                    Brush b = new System.Drawing.SolidBrush(c[cindex]);

                    Point dot = new Point(16, 16);

                    float angle = rand.Next(-iRandAngle, iRandAngle);//转动的度数

                    graph.TranslateTransform(dot.X, dot.Y);//移动光标到指定位置
                    graph.RotateTransform(angle);
                    graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);

                    graph.RotateTransform(-angle);//转回去
                    graph.TranslateTransform(2, -dot.Y);//移动光标到指定位置
                }
                pbVerifyCode.Image = map;

            }
            catch (ArgumentException)
            {
                MessageBox.Show("创建图片错误。");
            }
        }
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
        }
        /// <summary>
        /// 检查用户名和密码
        /// </summary>
        /// <param name="id">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        private bool CheckUser(string id, string pwd)
        {   
            //连接字符串
            string strcon = ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();
            //SQL语句
            string SQL = string.Format("SELECT * FROM [tb_Users] WHERE UserID='{0}' AND UserPassword='{1}'", id, pwd);
            //建立连接对象
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                //打开连接对象
                conn.Open();
               
                //建立命令对象
                SqlCommand cmd = new SqlCommand();
                //设置命令对象的属性
                cmd.Connection = conn;
                cmd.CommandText = SQL;
                cmd.CommandType = CommandType.Text;
               
                //执行命令对象的方法
                Object result = cmd.ExecuteScalar();
                
                if (result!= null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        /// <summary>
        /// 登录按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //收集输入信息
            string name = this.txtUserName.Text.Trim();
            string passwd = this.txtPasswd.Text.Trim();
            string code = txtVerifyCode.Text.Trim().ToString();

            if (name == string.Empty || passwd == string.Empty)
            {
                MessageBox.Show("用户名或密码为空！","登陆提示");
                return;
            }
            //检查用户名和密码
            if (CheckUser(name, passwd) == true)
            {
                if(strVerifyCode == code)
                {
                    MainForm main = new MainForm(name);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("验证码错误", "验证信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("用户名或密码错误,请重新输入！", "登录信息",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtUserName.Clear();
                this.txtPasswd.Clear();
                this.txtUserName.Focus();
                return;                
            }
        }
        /// <summary>
        /// 关闭按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
