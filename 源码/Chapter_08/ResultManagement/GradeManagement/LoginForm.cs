using System;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.txtName.Text.Trim();
            string pass = this.txtPass.Text.Trim();

            if (string.IsNullOrEmpty (id) || string.IsNullOrEmpty (pass))
            {
                MessageBox.Show("用户名或密码不能为空！", "登录提示");
                this.txtName.Focus();
            }
            else
            {
                Model.User user = new Model.User();  //新建用户对象
                user.ID = id;
                user.Pass = pass;
                user.Name = "user";

                GradeBLL.User users = new GradeBLL.User();

                if (users.IsUser (user))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误","登录提示");
                    return;
                }
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
