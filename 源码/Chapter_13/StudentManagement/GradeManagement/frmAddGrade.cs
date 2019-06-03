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
    public partial class frmAddGrade : Form
    {
        public frmAddGrade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立成绩列表
            List<GradeModel.Grade> gradeList = new List<GradeModel.Grade>();
            //获取数据
            string term = this.textBox1.Text.Trim();
            string cid = this.comboBox1.SelectedValue.ToString().Trim();  //课程编号
            //遍历表格
            foreach(DataGridViewRow row in dgvGrade.Rows)
            {
                //读取单元格内容
                string sid = (string)(dgvGrade.Rows[row.Index].Cells[0].Value);
                string result = (string)(dgvGrade.Rows[row.Index].Cells[2].Value);
                //建立学生对象
                GradeModel.Grade model = new GradeModel.Grade();
                model.SID = sid;
                model.CID = cid;
                model.Result = result;
                model.Term = term;
                //将成绩添加到列表
                gradeList.Add(model);
            }

            //建立成绩管理实体
            GradeBLL.GradeBll  bllGrade=new GradeBLL.GradeBll ();

            if (bllGrade.AddGrade(gradeList))
                MessageBox.Show("添加成绩成功！", "提示");
            else
                MessageBox.Show("添加成绩失败！","提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //查询按钮
        private void button3_Click(object sender, EventArgs e)
        {
            string classid = this.comboBox2.SelectedValue.ToString().Trim();

            //建立学生管理对象
            GradeBLL.StudentBLL bllStudent = new GradeBLL.StudentBLL();
            //获取学生列表
            List<GradeModel.Student> listStudent = bllStudent.StudentList(classid);
            //绑定学生
            this.dgvGrade.DataSource  = listStudent;
        }

        private void frmAddGrade_Load(object sender, EventArgs e)
        {
            LoadCourse();
            LoadClass();
            this.dgvGrade.AutoGenerateColumns = false;  //禁止自动生成列
        }

        private void LoadCourse()
        {
           //建立课程管理对象
           GradeBLL.CourseBll  bllCourse=new GradeBLL.CourseBll ();
           //获取课程列表
           List<GradeModel.Course> listCourse = bllCourse.CourseList();
            //将课程绑定到课程组合框
           this.comboBox1.DataSource = listCourse;
           this.comboBox1.DisplayMember = "CourseName";
           this.comboBox1.ValueMember = "CourseID";
        }

        private void LoadClass()
        {
            //建立班级管理对象
            GradeBLL.ManageClass  bllClass = new GradeBLL.ManageClass ();
            //获取班级列表
            List<GradeModel.School> listClass = bllClass.GetAllClassList ();
            //将班级绑定到班级组合框
            this.comboBox2.DataSource = listClass;
            this.comboBox2.DisplayMember = "ClassName";
            this.comboBox2.ValueMember = "ClassID";
        }
    }
}
