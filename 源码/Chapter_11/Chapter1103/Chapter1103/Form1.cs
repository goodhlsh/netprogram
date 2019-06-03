using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Chapter1103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxLocalInfo.Items.Clear();
            string name = Dns.GetHostName();
            listBoxLocalInfo.Items.Add("本机主机名：" + name);
            IPHostEntry me = Dns.GetHostEntry(name);
            listBoxLocalInfo.Items.Add("本机所有IP地址：");
            foreach (IPAddress ip in me.AddressList)
            {
                listBoxLocalInfo.Items.Add(ip);
            }
            IPAddress localip = IPAddress.Parse("127.0.0.1");
            IPEndPoint iep = new IPEndPoint(localip, 80);
            listBoxLocalInfo.Items.Add("IP端点: " + iep.ToString());
            listBoxLocalInfo.Items.Add("IP端口: " + iep.Port);
            listBoxLocalInfo.Items.Add("IP地址: " + iep.Address);
            listBoxLocalInfo.Items.Add("IP地址族: " + iep.AddressFamily);
            listBoxLocalInfo.Items.Add("可分配端口最大值: " + IPEndPoint.MaxPort);
            listBoxLocalInfo.Items.Add("可分配端口最小值: " + IPEndPoint.MinPort);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBoxRemoteInfo.Items.Clear();
            this.listBoxRemoteInfo.Items.Add("许昌学院官网的IP地址是：");
            IPHostEntry remoteHost = Dns.GetHostEntry("www.xcu.edu.cn");
            IPAddress[] remoteIP = remoteHost.AddressList;
            IPEndPoint iep;
            foreach (IPAddress ip in remoteIP)
            {
                iep = new IPEndPoint(ip, 80);
                listBoxRemoteInfo.Items.Add(iep);
            }
        }
    }
}
