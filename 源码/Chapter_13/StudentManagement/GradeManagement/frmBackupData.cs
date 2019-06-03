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
    public partial class frmBackupData : Form
    {
        string backupPath = "";     //备份路径
        GradeBLL.ManageDatabase db = new GradeBLL.ManageDatabase();
        public frmBackupData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sfdlgBackup.FilterIndex = 1;
            sfdlgBackup.FileName = "";
            sfdlgBackup.Filter = "Bak Files (*.bak)|*.bak";
            if (sfdlgBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = sfdlgBackup.FileName.ToString();
                txtBackup.ReadOnly = true;
            }
            backupPath = txtBackup.Text.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backupPath == "")
            {
                MessageBox.Show("请先选择数据库备份路径", "提示");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                db.BackDb(backupPath);
                MessageBox.Show("数据库备份成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
