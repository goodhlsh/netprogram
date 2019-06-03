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
    public partial class frmCourseList : Form
    {
        public frmCourseList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立课程管理对象
            GradeBLL.CourseBll bllCourse = new GradeBLL.CourseBll();
           
            DialogResult result = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)   //用户选择“确定”
            {
                GradeModel.Course model = new GradeModel.Course();

                model.CourseID  = this.txtCourseID.Text.Trim();
                model.CourseName  = this.txtCourseName.Text.Trim();

                if (bllCourse.UpdateCourse (model) > 0)
                {
                    MessageBox.Show("修改成功！", "提示");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            DialogResult result = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)   //用户选择“确定”
            {
                //建立课程管理对象
                GradeBLL.CourseBll bllCourse = new GradeBLL.CourseBll();

                if (bllCourse.DeleteCourse (this.txtCourseID.Text.Trim()) >= 0)
                {
                    MessageBox.Show("删除课程成功！", "提示");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("该课程已有学生选修，不允许删除！", "提示");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCourseID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //显示课程编号
            this.txtCourseName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //显示课程名称
        }

        private void frmCourseList_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            GradeBLL.CourseBll bllCourse = new GradeBLL.CourseBll();

            List<GradeModel.Course> list = bllCourse.CourseList();

            this.dataGridView1.DataSource = list;
        }
    }
}
