using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace edu.xcu.GradeManagement
{
    public partial class AddStudent : Form
    {
         //连接字符串
         string strcon = "Server=ZXQ-PC\\SQLEXPRESS; Database=db_Student; Integrated Security=SSPI";
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
            FillCollege();  //绑定院系下拉框
        }

        private void FillCollege()
        {
            string strSQL = "select CollegeID,CollegeName from [tb_College]";
           
            using (SqlConnection  conn=new SqlConnection (strcon))
            {
                DataSet ds = new DataSet();    //建立数据集对象
                SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn);
                sda.Fill(ds);  //填充数据集
                comDepart.DataSource = ds.Tables[0];  //数据绑定
                comDepart.DisplayMember = "CollegeName";
                comDepart.ValueMember = "CollegeID";
            }
        }
          /// <summary>
        /// 连接兴趣字符串
        /// </summary>
        /// <returns></returns>
        private string GetHobby()   
        {
            string hobby = "";
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

            return hobby;
        }
         private void btnConfirm_Click(object sender, EventArgs e)
        {
            //收集控件的值
            string stuid = this.txtStuID.Text;
            string name = this.txtName.Text;
            string gender = rbtMale.Checked == true?"男":"女";    
            string nation = this.comNation.Text;
            string age = Convert.ToString(this.numAge.Value);
            string depart = this.comDepart.SelectedValue.ToString ().Trim();
            string cl = this.comClass.SelectedValue.ToString().Trim();
            string location = this.txtLocation.Text;
            string hobby = GetHobby();
            hobby = GetHobby().Substring(0, hobby.Length - 1);

            string sql = string.Format("insert into [tb_Student](StudentID,StudentName,gender,status,age,college,classid,nation,hobby) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", stuid, name, gender, nation,age, depart, cl, location, hobby);    

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

         private void btnClose_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void comDepart_SelectedValueChanged(object sender, EventArgs e)
         {
             if (this.comDepart.SelectedIndex < 0)
             {
                 return;
             }

             string id = this.comDepart.SelectedValue.ToString().Trim();
             //构造SQL语句
             string strSQL = string.Format("select ClassID,ClassName from [tb_Class] where CollegeID='{0}'", id);


             using (SqlConnection conn = new SqlConnection(strcon))
             {
                 DataSet ds = new DataSet();    //建立数据集对象
                 SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn);
                 sda.Fill(ds);  //填充数据集
                 comClass.DataSource = ds.Tables[0];  //数据绑定
                 comClass.DisplayMember = "ClassName";
                 comClass.ValueMember = "ClassID";
             }
         }
    }
}