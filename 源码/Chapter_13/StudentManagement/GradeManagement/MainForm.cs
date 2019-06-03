using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using edu.xcu.GradeManagement;

namespace GradeManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword pw = new frmChangePassword();
            pw.ShowDialog();
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupData data = new frmBackupData();
            data.ShowDialog();
        }

        private void 数据恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestoreData data = new frmRestoreData();
            data.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent student = new frmAddStudent();
            student.ShowDialog();
        }

        private void 编辑学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditStudent frmEdit = new frmEditStudent();
            frmEdit.ShowDialog();
        }

        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInquiryStudent student = new frmInquiryStudent();
            student.ShowDialog();
        }

        private void 添加院系ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCollge college = new frmAddCollge();
            college.ShowDialog();
        }

        private void 院系列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCollegeList list = new frmCollegeList();
            list.ShowDialog();
        }

        private void 添加班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClass cl = new frmAddClass();
            cl.ShowDialog();
        }

        private void 班级列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassList list = new frmClassList();
            list.ShowDialog();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCourse course = new frmAddCourse();
            course.ShowDialog();
        }

        private void 课程列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseList list = new frmCourseList();
            list.ShowDialog();
        }       

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddGrade grade = new frmAddGrade();
            grade.ShowDialog();
        }

        private void 成绩更改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditGrade grade = new frmEditGrade();
            grade.ShowDialog();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInqueryGrade grade = new frmInqueryGrade();
            grade.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edu.xcu.GradeManagement.AboutGrade about = new edu.xcu.GradeManagement.AboutGrade();
            about.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";
            this.toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }
    }
}
