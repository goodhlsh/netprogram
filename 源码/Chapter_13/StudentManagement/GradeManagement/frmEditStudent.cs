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
    public partial class frmEditStudent : Form
    {
        public frmEditStudent()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = this.txtSID.Text.Trim();

            GradeBLL.StudentBLL bllStudent = new GradeBLL.StudentBLL();
            //查询学生信息
            GradeModel.Student modelStudent = bllStudent.GetStudentByID(id);

            this.txtID.Text = modelStudent.StudentID;
            this.txtName.Text = modelStudent.StudentName;
            if (modelStudent.Gender == "男")
                this.rboMale.Checked = true;
            else
                this.rboFemal.Checked = true;
            this.txtBirthday.Text = modelStudent.Birthday;
            this.cboCollege.SelectedValue = modelStudent.CollegeID;
            this.txtAddress.Text = modelStudent.Address;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)   //用户选择“确定”
            {
                //建立学生实体
                GradeModel.Student student = new GradeModel.Student();
                //学生实体赋值
                student.StudentID = this.txtID.Text.Trim();
                student.StudentName = this.txtName.Text.Trim();
                student.Gender = this.rboMale.Checked ? "男" : "女";
                student.Birthday = this.txtBirthday.Text.Trim();
                student.CollegeID = this.cboCollege.SelectedValue.ToString().Trim();
                student.ClassID = this.cboClass.SelectedValue.ToString().Trim();
                student.Address = this.txtAddress.Text.Trim();
                //生成学生管理对象
                GradeBLL.StudentBLL bllStudent = new GradeBLL.StudentBLL();

                if (bllStudent.UpdateStudent(student) > 0)
                    MessageBox.Show("修改学生信息成功！", "提示");
                else
                    MessageBox.Show("修改学生信息失败！", "提示");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          DialogResult result = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

          if (result == DialogResult.Yes)   //用户选择“确定”
          {
              //生成学生管理对象
              GradeBLL.StudentBLL bllStudent = new GradeBLL.StudentBLL();

              if (bllStudent.DeleteStudent (this.txtID.Text.Trim()) > 0)
                  MessageBox.Show("删除学生成功！", "提示");
              else
                  MessageBox.Show("删除学生失败！", "提示");
          }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCollege_SelectedValueChanged(object sender, EventArgs e)
        {
            string cid = this.cboCollege.SelectedValue.ToString().Trim();

            GradeBLL.ManageClass bllClass = new GradeBLL.ManageClass();

            this.cboClass.DataSource = bllClass.GetClassList(cid);
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassID";  
        }

        private void LoadCollege()
        {
            //生成班级管理对象
            GradeBLL.CollegeBLL bllCollege = new GradeBLL.CollegeBLL();
            //绑定数据
            this.cboCollege.DataSource = bllCollege.CollegeList();
            this.cboCollege.DisplayMember = "CollegeName";
            this.cboCollege.ValueMember = "CollegeID";
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            LoadCollege();
            this.txtSID.Focus();
        }
    }
}
