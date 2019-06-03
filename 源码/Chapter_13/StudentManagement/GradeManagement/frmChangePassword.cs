using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edu.xcu.GradeManagement
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GradeModel.User user = new GradeModel.User();   //实例化User对象
            GradeBLL.UserBLL bllUser = new GradeBLL.UserBLL();

            string pass1 = this.textBox1.Text.Trim();
            string pass2 = this.textBox2.Text.Trim();
            string id = this.txtUserID.Text.Trim();

            if (pass1==pass2)
            {
                user.UserID = id;
                user.UserPass = pass1;

                if (bllUser.UpdateUser(user) > 0)
                    MessageBox.Show("修改密码成功！", "提示");
                else
                    MessageBox.Show("修改密码失败！", "提示");
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致！", "提示");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
