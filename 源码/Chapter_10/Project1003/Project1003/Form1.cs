using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "*.jpg;*.bmp|*.jpg;*.bmp;";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap srcBitmap = new Bitmap(openFile.FileName);
                this.pictureBox1.Image = new Bitmap(srcBitmap, this.pictureBox1.Width, this.pictureBox1.Height);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.BackColor);

                for (int x = 0; x <= this.pictureBox1.Width; x++)
                {
                    g.DrawImage(this.pictureBox1.Image, 0, 0, x, this.pictureBox1.Height); 
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox1.Refresh(); 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Image myImage = pictureBox1.Image;
            Bitmap myBitmap = new Bitmap(myImage, myImage.Width * 2, myImage.Height * 2);
            pictureBox1.Image = myBitmap; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
