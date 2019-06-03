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
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GradeModel.Course cs = new GradeModel.Course();
            cs.CourseID = this.txtCpurseID.Text.Trim();
            cs.CourseName = this.txtCourseName.Text.Trim();

            GradeBLL.CourseBll bllCourse = new GradeBLL.CourseBll();
            int rows = bllCourse.AddCourse (cs);

            if (rows > 0)
            {
                MessageBox.Show("添加课程成功！", "提示");
            }
            else
            {
                MessageBox.Show("添加课程失败！", "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
