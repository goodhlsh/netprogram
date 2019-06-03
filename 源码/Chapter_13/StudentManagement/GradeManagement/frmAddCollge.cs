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
    public partial class frmAddCollge : Form
    {
        public frmAddCollge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GradeModel.College c = new GradeModel.College();
            GradeBLL.CollegeBLL bllCollege = new GradeBLL.CollegeBLL();

            c.CollegeID = this.txtCollegeID.Text.Trim();
            c.CollegeName = this.txtCollegeName.Text.Trim();
           
            int rows = bllCollege.AddCollege(c);

            if (rows>0)
            {
                MessageBox.Show("添加院系成功！", "提示");
            }
            else
            {
                MessageBox.Show("添加院系失败！", "提示");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
