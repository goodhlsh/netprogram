using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentGrade
{
    public partial class AddStudent : Form
    {
        string hobby = "";
        public AddStudent()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.txtStuID.Focus();
            this.rbtMale.Checked = true;
        }
        /// <summary>
        /// 院系选择改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comDepart.SelectedIndex < 0)
            {
                return;
            }
            string department = this.comDepart.Text.Trim();

            if (department == "信息工程学院")
            {
                this.comClass.Items.Add("2013级计算机1班");
                this.comClass.Items.Add("2013级网络工程1班");
                this.comClass.Items.Add("2013级物联网工程1班");
                this.comClass.Items.Add("2013级数字媒体技术1班");
            }

        }
        /// <summary>
        /// 连接兴趣字符串
        /// </summary>
        /// <returns></returns>
        private void GetHobby()   
        {
           if (this.checkBox1.Checked == true)
            {
                hobby = hobby + this.checkBox1.Text.Trim() + "、";
            }

            if (this.checkBox2.Checked == true)
            {
                hobby = hobby + this.checkBox2.Text.Trim() + "、";
            }

            if (this.checkBox3.Checked == true)
            {
                hobby = hobby + this.checkBox3.Text.Trim() + "、";
            }

            if (this.checkBox4.Checked == true)
            {
                hobby = hobby + this.checkBox4.Text.Trim() + "、";
            }

            if (this.checkBox5.Checked == true)
            {
                hobby = hobby + this.checkBox5.Text.Trim() + "、";
            }           
        }
         private void btnConfirm_Click(object sender, EventArgs e)
        {
            //收集控件的值
            string stuid = this.txtStuID.Text;
            string name = this.txtName.Text;
            string gender = rbtMale.Checked == true?"男":"女";    
            string nation = this.comNation.Text;
            string age = Convert.ToString(this.numAge.Value);
            string depart = this.comDepart.Text;
            string cl = this.comClass.Text;
            string lcation = this.txtLocation.Text;
            hobby = hobby.Substring(0, hobby.Length - 1);

            string sql =string.Format("insert into [tb_Student](stuid,stuname,gender,department,stuclass,nation,age,courty,intersting) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",stuid,name,gender,depart,cl,nation,age,lcation,hobby);                 

            //连接字符串
            string strcon = "Server=B55\\SQL01;Database=db_Student; Integrated Security=SSPI";

            //建立连接对象
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                //打开连接对象
                conn.Open();

                //建立命令对象
                SqlCommand cmd = new SqlCommand();
                //设置命令对象的属性
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                //执行command的方法
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("添加学生成功！", "添加学生", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加学生失败！", "添加学生", MessageBoxButtons.OK);
                }
                /*

                string info = "学号：" + stuid + "  姓名：" + name + "  性别：" + gender + "\n";
                info = info + "政治面貌：" + nation + " 年龄：" + age + " 院系：" + depart + " 班级:" + cl + "\n";

                info = info + " 籍贯：" + lcation + "  兴趣和爱好：" + hobby;

                MessageBox.Show(info, "学生信息");
            }
    */
            }
        }
    }
}