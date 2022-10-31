using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace hxsfxIPSet
{
    public partial class Form1 : Form
    {
        public NetworkInterface[] NetworkInterfaces { get; set; }
        public Form1()
        {
            InitializeComponent();
            InitalNetworkInterfaceName();
        }
        #region 按住标题拖动窗体
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void lb_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion
        /// <summary>
        /// 初始化适配器（以太网）名称列表
        /// </summary>
        private void InitalNetworkInterfaceName()
        {
            this.NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var adapter in this.NetworkInterfaces)
            {
                if (adapter.OperationalStatus == OperationalStatus.Up)
                {
                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                    || adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    {
                        this.cb_adapter.Items.Add(adapter.Name);
                    }
                }
            }
            if (this.cb_adapter.Items.Count > 0)
            {
                this.cb_adapter.SelectedIndex = 0;
            }
        }
        private void cb_adapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var adapter in NetworkInterfaces)
            {
                if (adapter.Name == (string)this.cb_adapter.SelectedItem)
                {
                    var p = adapter.GetIPProperties();
                    var gatewayCollection = p.GatewayAddresses;
                    if (gatewayCollection.Count > 0)
                    {
                        this.textBox_gateway.Text = gatewayCollection[0].Address.ToString();
                    }
                    var ipCollection = p.UnicastAddresses;
                    if (ipCollection.Count > 0)
                    {
                        this.textBox_ip.Text = ipCollection[1].Address.ToString();
                        var ipv4Mask = ipCollection[1].IPv4Mask;
                        this.textBox_maskCode.Text = ipv4Mask == null ? "" : ipv4Mask.ToString();
                    }
                    break;
                }
            }
        }
        private void textBox_ip_TextChanged(object sender, EventArgs e)
        {
            //var ipSplit = this.textBox_ip.Text.Split('.');
            //var gateway = new string[4];
            //gateway[0] = ipSplit.Length > 0 ? ipSplit[0] : "0";
            //gateway[1] = ipSplit.Length > 1 ? ipSplit[1] : "0";
            //gateway[2] = ipSplit.Length > 2 ? ipSplit[2] : "0";
            //gateway[3] = "254";

            //this.textBox_gateway.Text = string.Join(".", gateway);
        }
        private void btn_getNetworkInterfaceName_Click(object sender, EventArgs e)
        {
            this.cb_adapter.SelectedIndex = -1;
            InitalNetworkInterfaceName();
        }
        private void btn_modify_Click(object sender, EventArgs e)
        {
            using (Process process = new System.Diagnostics.Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                //是否使用操作系统shell启动
                process.StartInfo.UseShellExecute = false;
                //接受来自调用程序的输入信息
                process.StartInfo.RedirectStandardInput = true;
                //由调用程序获取输出信息
                process.StartInfo.RedirectStandardOutput = true;
                //不显示程序窗口
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                //向cmd窗口发送输入信息
                process.StandardInput.WriteLine($"netsh interface ip set address name=\"{(string)this.cb_adapter.SelectedItem}\" source=static addr={this.textBox_ip.Text} mask={this.textBox_maskCode.Text} gateway={this.textBox_gateway.Text} gwmetric=1&exit");
                process.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息
                var outputList = new List<string>();
                string output = process.StandardOutput.ReadLine();
                while (output != null)
                {
                    output = process.StandardOutput.ReadLine();
                    if (output != null)
                    {
                        outputList.Add(output);
                    }
                }
                MessageBox.Show(string.Join("\r\n", outputList.ToArray()));
                process.WaitForExit();//等待程序执行完退出进程
            }
        }
        private void button_closeForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
