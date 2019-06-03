using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentGrade
{
    public partial class DBBachupForm : Form
    {
        string backuppath = "";  //备份路径

        public DBBachupForm()
        {
            InitializeComponent();
        }
        //选择按钮单击事件
        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            sfdlgBackup.FilterIndex = 1;
            sfdlgBackup.FileName = "";
            sfdlgBackup.Filter = "Bak Files(*.bak)|*bak";
            if (sfdlgBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = sfdlgBackup.FileName.ToString();
                txtBackup.ReadOnly = true;
            }
            backuppath = txtBackup.Text.Trim();
        }
        //备份按钮单击事件
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (backuppath == "")
            {
                MessageBox.Show("请选择数据备份路径", "提示");
                return;
            }

        }
        //关闭按钮单击事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
