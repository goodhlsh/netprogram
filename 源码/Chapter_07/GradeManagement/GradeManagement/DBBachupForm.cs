using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace edu.xcu.GradeManagement
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
            //连接字符串
            string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["student"].ConnectionString.ToString();

            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                this.Cursor = Cursors.WaitCursor;
               
                //如果存在指定文件，则删除
                if (File.Exists (backuppath))
                {
                    File.Delete(backuppath);
                }
                //构造SQL命令
                string strSQL = string.Format("backup database [db_Student] to disk='{0}'",backuppath );
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("数据库备份成功！", "数据备份");                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            finally
            {
                conn.Close();
                this.Cursor = Cursors.Arrow;
            }    
        }
        //关闭按钮单击事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
