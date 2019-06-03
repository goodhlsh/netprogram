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
    public partial class frmAddClass : Form
    {
        public frmAddClass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建班级对象并赋值
            GradeModel.School school = new GradeModel.School();
            school.ClassID = this.txtClassID.Text.Trim();
            school.ClassName = this.txtClassName.Text.Trim();
            school.CollegeID = this.cboCollege.SelectedValue.ToString().Trim();

            //创建班级管理对象
            GradeBLL.ManageClass cl = new GradeBLL.ManageClass();
            
            if (cl.AddClass (school)>0)
            {
                MessageBox.Show("添加班级成功！", "提示");
            }
            else
            {
                MessageBox.Show("添加班级失败！", "提示");
            }


        }
        //绑定院系表
        private void LoadCollege()
        {
            GradeBLL.CollegeBLL bllCollege = new GradeBLL.CollegeBLL();

            this.cboCollege.DataSource = bllCollege.CollegeList();
            this.cboCollege.DisplayMember = "CollegeName";
            this.cboCollege.ValueMember = "CollegeID";
        }

        private void frmAddClass_Load(object sender, EventArgs e)
        {
            LoadCollege();
            this.txtClassID.Focus();
        }
    }
}
