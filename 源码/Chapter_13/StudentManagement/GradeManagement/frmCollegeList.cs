using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradeModel;

namespace edu.xcu.GradeManagement
{
    public partial class frmCollegeList : Form
    {
        public frmCollegeList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GradeBLL.CollegeBLL bllCollege = new GradeBLL.CollegeBLL();

            DialogResult result = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)   //用户选择“确定”
            {
                GradeModel.College model = new GradeModel.College();

                model.CollegeID = this.txtCollegeID.Text.Trim();
                model.CollegeName = this.txtCollegeName.Text.Trim();

                if (bllCollege.UpdateCollege(model)>0)
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
            GradeBLL.CollegeBLL bllCollege = new GradeBLL.CollegeBLL();

            DialogResult result = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)   //用户选择“确定”
            {
                if (bllCollege.DeleteCollege(this.txtCollegeID.Text.Trim()) >=0)
                {
                    MessageBox.Show("删除成功！", "提示");
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("该院系有班级，不允许删除！", "提示");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataGridView()
        {
            GradeBLL.CollegeBLL collegeList = new GradeBLL.CollegeBLL();

            List<GradeModel.College> list = collegeList.CollegeList();

            this.dataGridView1.DataSource = list;   
        }

        private void frmCollegeList_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LoadDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCollegeID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //显示院系编号
            this.txtCollegeName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //显示院系名称
        }
    }
}
