using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentGrade
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            string SQL = string.Format("SELECT * FROM [tb_User] WHERE userid='{0}' AND passwd='{1}'",id,pwd);
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

            if (name == string.Empty || passwd == string.Empty)
            {
                MessageBox.Show("用户名或密码为空！","系统提示");
                return;
            }
            //检查用户名和密码
            if (CheckUser(name, passwd) == true)
            {
                MainForm main = new MainForm(name);
                this.Hide();
                main.Show();
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
