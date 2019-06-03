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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //建立学生对象
            GradeModel.Student student = new GradeModel.Student();
            //给学生对象赋值
            student.StudentID = this.cboClass.SelectedValue.ToString().Trim() + this.txtID.Text.Trim();
            student.StudentName = this.txtName.Text.Trim();
            student.Gender = this.rboMale.Checked ? "男" : "女";
            student.Birthday = this.txtBirthday.Text.Trim();
            student.CollegeID = this.cboCollege.SelectedValue.ToString().Trim();
            student.ClassID = this.cboClass.SelectedValue.ToString().Trim();
            student.Address = this.txtAddress.Text.Trim();

            GradeBLL.StudentBLL bllStudent = new GradeBLL.StudentBLL();

            if (bllStudent.AddStudent(student) > 0)
                MessageBox.Show("添加学生信息成功！", "添加学生");
            else
                MessageBox.Show("添加学生信息失败，请联系管理员！", "添加学生");

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            //初始化院系列表
            GradeBLL.CollegeBLL bllCollege = new GradeBLL.CollegeBLL();
            this.cboCollege.DataSource = bllCollege.CollegeList();
            this.cboCollege.DisplayMember = "CollegeName";
            this.cboCollege.ValueMember = "CollegeID";
            //焦点
            this.txtID.Focus();
        }     

        private void cboCollege_SelectedValueChanged(object sender, EventArgs e)
        {
            string cid = this.cboCollege.SelectedValue.ToString().Trim();

            GradeBLL.ManageClass bllClass = new GradeBLL.ManageClass();

            this.cboClass.DataSource = bllClass.GetClassList(cid);
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassID";           
        }
    }
}
