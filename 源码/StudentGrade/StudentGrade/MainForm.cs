using System;
using System.Windows.Forms;

namespace StudentGrade
{
    public partial class MainForm : Form
    {
        private string name;

        public MainForm()
        {
            InitializeComponent();
        }
        //带参数的构造函数
        public MainForm(string name)
        {
            InitializeComponent();
            this.name = name;
        }      

        private void 添加学生信息AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addFrom = new AddStudent();
            addFrom.Show();
        }

        private void 退出系统XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tsslInfo.Text = "欢迎" + name+"使用学生成绩管理系统";
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tsslTime.Text = DateTime.Now.ToString();
        }

        private void 查询班级学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryClass classForm = new QueryClass();
            classForm.Show();
        }

        private void 修改学生信息MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent editstu = new EditStudent();
            editstu.Show();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryClass classForm = new QueryClass();
            classForm.Show();
        }

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGradeForm gradeForm = new AddGradeForm();
            gradeForm.Show();
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBBachupForm backup = new DBBachupForm();
            backup.ShowDialog();
        }
    }
}
