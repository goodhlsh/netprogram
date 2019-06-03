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
    public partial class frmClassList : Form
    {
        public frmClassList()
        {
            InitializeComponent();
        }
        //绑定院系组合框
        private void LoadCollege()
        {
            GradeBLL.CollegeBLL bllCollege = new GradeBLL.CollegeBLL();

            this.cboCollege.DataSource = bllCollege.CollegeList();
            this.cboCollege.DisplayMember = "CollegeName";
            this.cboCollege.ValueMember = "CollegeID";
        }

        private void LoadDataGridView()
        {
            //创建班级对象
            GradeBLL.ManageClass  bllSchool = new GradeBLL.ManageClass ();

            List<GradeModel.School> classList = bllSchool.GetClassList("1");

            this.dataGridView1.DataSource =classList; 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {                            
            this.txtClassID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//班级编号
            this.txtClassName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//班级名称
            this.cboCollege.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();  //院系编号
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //建立班级管理对象
            GradeBLL.ManageClass bllClass = new GradeBLL.ManageClass();

            DialogResult result = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)   //用户选择“确定”
            {
               //生成班级对象
                GradeModel.School modelSchool = new GradeModel.School();

                modelSchool.ClassID = this.txtClassID.Text.Trim();
                modelSchool.ClassName = this.txtClassName.Text.Trim();
                modelSchool.CollegeID = this.cboCollege.SelectedValue.ToString().Trim();

                if (bllClass.UpdataClass (modelSchool) > 0)
                {
                    MessageBox.Show("班级修改成功！", "提示");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("班级修改失败！", "提示");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //建立班级管理对象
            GradeBLL.ManageClass bllClass = new GradeBLL.ManageClass();

            DialogResult result = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)   //用户选择“确定”
            {
                if (bllClass.DeleteClass (this.txtClassID.Text.Trim()) >= 0)
                {
                    MessageBox.Show("班级删除成功！", "提示");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("该班级有学生，不允许删除！", "提示");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClassList_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LoadCollege();
            LoadDataGridView();
        }
    }
}
