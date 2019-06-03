using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = this.txtName.Text.Trim();
            string pass = this.txtPasswd.Text.Trim();

            if (string.IsNullOrEmpty (id) || string.IsNullOrEmpty (pass))
            {
                MessageBox.Show("用户名或密码不能为空！", "登陆提示");
                this.txtName.Focus();
            }
            else
            {
                GradeModel.User user = new GradeModel.User();  //新建用户对象
                user.UserID  = id;
                user.UserPass  = pass;
                user.UserName  = "";

                GradeBLL.UserBLL  userBLL = new GradeBLL.UserBLL();

                if (userBLL.Login (user))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "登录提示");
                    return;
                }
            }
           }
    }
}
