using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace edu.xcu.GradeManagement
{
    public partial class frmEditGrade : Form
    {
        public frmEditGrade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立成绩列表
            List<GradeModel.Grade> gradeList = new List<GradeModel.Grade>();
            //获取数据
            string term = this.textBox1.Text.Trim();
            string cid = this.comboBox1.SelectedValue.ToString().Trim();  //课程编号
            //遍历表格
            foreach (DataGridViewRow row in dgvGrade.Rows)
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
            GradeBLL.GradeBll bllGrade = new GradeBLL.GradeBll();

            if (bllGrade.UpdateGrade(gradeList))
                MessageBox.Show("修改成绩成功！", "提示");
            else
                MessageBox.Show("修改成绩失败！", "提示");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string term = this.textBox1.Text.Trim();
            string cid = this.comboBox1.SelectedValue.ToString().Trim();

            //建立成绩管理实体
            GradeBLL.GradeBll bllGrade = new GradeBLL.GradeBll();
            //绑定表格
            this.dgvGrade.DataSource = bllGrade.GradeTables(cid, term);

        }

        private void frmEditGrade_Load(object sender, EventArgs e)
        {
           this.dgvGrade.AutoGenerateColumns = false;  //禁止自动生成列
            LoadCourse();
        }
        private void LoadCourse()
        {
            //建立课程管理对象
            GradeBLL.CourseBll bllCourse = new GradeBLL.CourseBll();
            //获取课程列表
            List<GradeModel.Course> listCourse = bllCourse.CourseList();
            //将课程绑定到课程组合框
            this.comboBox1.DataSource = listCourse;
            this.comboBox1.DisplayMember = "CourseName";
            this.comboBox1.ValueMember = "CourseID";
        }      
    }
}
