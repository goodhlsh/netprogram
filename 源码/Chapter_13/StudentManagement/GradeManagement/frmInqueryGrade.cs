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
    public partial class frmInqueryGrade : Form
    {
        public frmInqueryGrade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.txtSID.Text.Trim();
            if (string.IsNullOrEmpty (id))
            {
                MessageBox.Show("学号不能为空！", "系统提示");
                return;
            }
            else
            {
                GradeBLL.GradeBll bllGrade = new GradeBLL.GradeBll();
                this.dataGridView1.DataSource = bllGrade.StudentGradeTablesByID(id);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInqueryGrade_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
        }
    }
}
