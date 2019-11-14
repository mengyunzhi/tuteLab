using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace tool
{
    public partial class Form1 : Form
    {
        private IPAddress address;

        public Form1()
        {
            InitializeComponent();
            try
            {
                this.address = GetDefaultGateway();
                this.Gateway.Text = address.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("获取网关发生错误，请检查静态路由配置是否正确. " + exception.Message);
            }
        }

        /**
         * 获取默认网关
         * https://stackoverflow.com/questions/13634868/get-the-default-gateway
         */
        private IPAddress GetDefaultGateway()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .Where(a => a != null)
                // .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                // .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                .FirstOrDefault();
        }

        /**
         * 执行CMD命令
         * https://blog.csdn.net/Factor_/article/details/83690503
         */
        public void CMDOperator(string cmd)
        {
            Process myProcess = new Process();                 // 创建进程对象
            myProcess.StartInfo.FileName = "cmd.exe";          // 设置打开cmd命令窗口
            myProcess.StartInfo.UseShellExecute = false;       // 不使用操作系统shell启动进程的值
            myProcess.StartInfo.RedirectStandardInput = true;  // 设置可以从标准输入流读取值
            myProcess.StartInfo.RedirectStandardOutput = true; // 设置可以向标准输出流写入值
            myProcess.StartInfo.RedirectStandardError = true;  // 设置可以显示输入输出流中出现的错误
            myProcess.StartInfo.CreateNoWindow = true;         // 设置在新窗口中启动进程
            myProcess.Start();                                 // 启动进程
            myProcess.StandardInput.WriteLine(cmd);            // 传入要执行的命令
        }

        private void EDIT_Click(object sender, System.EventArgs e)
        {
            try
            {
                // 1. 添加静态路由到原网关
                CMDOperator("route add 192.168.0.0 mask 255.255.254.0 " + address.ToString());
                // 2. 原地址转到新的网关
                byte[] addressBytes = this.address.GetAddressBytes();
                if (addressBytes[3] <= 253)
                {
                    addressBytes[3]++;
                }
                IPAddress newAddress = new IPAddress(addressBytes);
                CMDOperator("route change 0.0.0.0 mask 0.0.0.0 " + newAddress.ToString());
                this.EDIT.Enabled = false;
                MessageBox.Show("设置成功");
            }
            catch (Exception exception)
            {
                MessageBox.Show("发生错误，请检查静态路由配置是否正确. " + exception.Message);
            }
        }

        private void Yunzhi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.yunzhi.LinkVisited = true;
            // 跳转到首页
            Process.Start("http://www.mengyunzhi.com/");
        }
    }
}
