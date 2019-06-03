using System;
using System.Windows.Forms;

namespace edu.xcu.GradeManagement
{
    public partial class frmRestoreData : Form
    {
        string restorepath = "";
        GradeBLL.ManageDatabase db = new GradeBLL.ManageDatabase();
        public frmRestoreData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdlgRestore.FilterIndex = 1;
            ofdlgRestore.FileName = "";
            ofdlgRestore.Filter = "Bak File(*.bak)|*.bak";

            if (ofdlgRestore.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = ofdlgRestore.FileName.ToString();
                txtRestore.ReadOnly = true;
            }

            restorepath = txtRestore.Text.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (restorepath =="")
            {
                MessageBox.Show("请选择备份数据库！", "数据恢复");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;

                db.RestoreDb(restorepath);

                MessageBox.Show("数据库恢复成功");
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
