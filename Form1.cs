using MyProg;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace networkanalyzer
{
    public partial class NetworkAnalyzer : Form
    {
        public delegate void UpdateProgress(int status, string updatetime, List<double> pingresult, List<double> tcpresult, List<double> googleresult);
        private UpdateProgress updator;
        CancellationTokenSource cts = null;
        private bool Running = false;
        private List<double> pingresult;
        private List<double> tcpresult;
        private List<double> googleresult;
        Series pingseries = new System.Windows.Forms.DataVisualization.Charting.Series
        {
            Name = "Ping",
            Color = System.Drawing.Color.Green,
            IsVisibleInLegend = false,
            IsXValueIndexed = true,
            ChartType = SeriesChartType.Line
        };
        Series tcpingseries = new System.Windows.Forms.DataVisualization.Charting.Series
        {
            Name = "Tcping",
            Color = System.Drawing.Color.Blue,
            IsVisibleInLegend = false,
            IsXValueIndexed = true,
            ChartType = SeriesChartType.Line
        };
        Series googleseries = new System.Windows.Forms.DataVisualization.Charting.Series
        {
            Name = "Google",
            Color = System.Drawing.Color.Red,
            IsVisibleInLegend = false,
            IsXValueIndexed = true,
            ChartType = SeriesChartType.Line
        };

        public NetworkAnalyzer()
        {
            InitializeComponent();
            this.updator = new UpdateProgress(UIUpdateProgress);
            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.notifyIcon.ContextMenuStrip.Items.Add("Start", null, this.notifyIconMenuStart_Click);
            this.notifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.notifyIconMenuExit_Click);
           
            //read setting
            var MyIni = new IniFile("Settings.ini");
            this.editLocalIPPort.Text = MyIni.Read("local_ip_port", "basic");
            this.editServerIPPort.Text = MyIni.Read("server_ip_port", "basic");
            this.editCheckInterval.Text = MyIni.Read("interval", "monitor");
            try
            {
                this.checkBoxPingWarning.Checked = Convert.ToBoolean(MyIni.Read("ping_threshold_enable", "threshold"));
            }
            catch
            {

            }
            this.editWarningPingThreshold.Text = MyIni.Read("ping_threshold_time", "threshold");
            try
            {
                this.checkBoxTcpingWarning.Checked = Convert.ToBoolean(MyIni.Read("tcping_threshold_enable", "threshold"));
            }
            catch
            {

            }
            this.editWarningTcpingThreshold.Text = MyIni.Read("tcping_threshold_time", "threshold");
            try
            {
                this.checkBoxGoogleWarning.Checked = Convert.ToBoolean(MyIni.Read("google_threshold_enable", "threshold"));
            }
            catch
            {

            }
            this.editWarningGoogleThreshold.Text = MyIni.Read("google_threshold_time", "threshold");
            try
            {
                this.checkBoxPingOn.Checked = Convert.ToBoolean(MyIni.Read("ping_monitor_on", "monitor"));
            }
            catch
            {

            }
            try
            {
                this.checkBoxTcpingOn.Checked = Convert.ToBoolean(MyIni.Read("tcping_monitor_on", "monitor"));
            }
            catch
            {

            }
            try
            {
                this.checkBoxGoogleOn.Checked = Convert.ToBoolean(MyIni.Read("google_monitor_on", "monitor"));
            }
            catch
            {

            }
            this.editAverageTimes.Text = MyIni.Read("average_times", "monitor");

            //chart init
            this.chtRecord.Series.Clear();
            this.chtRecord.Series.Add(pingseries);
            this.chtRecord.Series.Add(tcpingseries);
            this.chtRecord.Series.Add(googleseries);
            this.chtRecord.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            this.chtRecord.ChartAreas[0].AxisX.LabelStyle.Angle = -80;
            this.chtRecord.ChartAreas[0].AxisX.LineWidth = 2;
            this.chtRecord.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chtRecord.ChartAreas[0].AxisX.Interval = 1;
            this.chtRecord.ChartAreas[0].CursorX.AutoScroll = true;
            this.chtRecord.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            this.chtRecord.ChartAreas[0].AxisX.ScaleView.Size = 20;
            this.chtRecord.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            this.chtRecord.ChartAreas[0].AxisX.ScaleView.Zoom(0, 20);
            this.chtRecord.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            this.chtRecord.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 20;
            this.chtRecord.Series["Ping"].MarkerSize = 5;
            this.chtRecord.Series["Ping"].MarkerStyle = MarkerStyle.Circle;
            this.chtRecord.Series["Tcping"].MarkerSize = 5;
            this.chtRecord.Series["Tcping"].MarkerStyle = MarkerStyle.Circle;
            this.chtRecord.Series["Google"].MarkerSize = 5;
            this.chtRecord.Series["Google"].MarkerStyle = MarkerStyle.Circle;
        }

        private void save_setting()
        {
            var MyIni = new IniFile("Settings.ini");
            MyIni.Write("local_ip_port", editLocalIPPort.Text, "basic");
            MyIni.Write("server_ip_port", editServerIPPort.Text, "basic");
            MyIni.Write("ping_threshold_enable", checkBoxPingWarning.Checked.ToString(), "threshold");
            MyIni.Write("ping_threshold_time", editWarningPingThreshold.Text, "threshold");
            MyIni.Write("tcping_threshold_enable", checkBoxTcpingWarning.Checked.ToString(), "threshold");
            MyIni.Write("tcping_threshold_time", editWarningTcpingThreshold.Text, "threshold");
            MyIni.Write("google_threshold_enable", checkBoxGoogleWarning.Checked.ToString(), "threshold");
            MyIni.Write("google_threshold_time", editWarningGoogleThreshold.Text, "threshold");
            MyIni.Write("ping_monitor_on", checkBoxPingOn.Checked.ToString(), "monitor");
            MyIni.Write("tcping_monitor_on", checkBoxTcpingOn.Checked.ToString(), "monitor");
            MyIni.Write("googleping_monitor_on", checkBoxGoogleOn.Checked.ToString(), "monitor");
            MyIni.Write("interval", editCheckInterval.Text, "monitor");
            MyIni.Write("average_times", editAverageTimes.Text, "monitor");
            MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.save_setting();
        }

        private void status_change_check(bool running)
        {
            this.Running = running;
            if (running)
            {
                this.toolStripStatusLblStatusResult.Text = "运行中";
                this.notifyIcon.ContextMenuStrip.Items[0].Text = "Stop";
                this.toolStripMenuItemRun.Enabled = false;
                this.toolStripMenuItemStop.Enabled = true;
                this.toolStripDropDownButtonData.Enabled = false;
                this.editCheckInterval.Enabled = false;
                this.editLocalIPPort.Enabled = false;
                this.editServerIPPort.Enabled = false;
                this.editAverageTimes.Enabled = false;
            }
            else
            {
                this.toolStripStatusLblStatusResult.Text = "已停止";
                this.notifyIcon.ContextMenuStrip.Items[0].Text = "Start";
                this.toolStripMenuItemRun.Enabled = true;
                this.toolStripMenuItemStop.Enabled = false;
                this.toolStripDropDownButtonData.Enabled = true;
                this.editCheckInterval.Enabled = true;
                this.editLocalIPPort.Enabled = true;
                this.editServerIPPort.Enabled = true;
                this.editAverageTimes.Enabled = true;
            }
            this.notifyIcon.ContextMenuStrip.Items[0].Enabled = true;
        }

        private void monitor()
        {
            this.toolStripMenuItemRun.Enabled = false;
            this.toolStripMenuItemStop.Enabled = false;
            this.toolStripDropDownButtonData.Enabled = false;
            this.editCheckInterval.Enabled = false;
            this.editLocalIPPort.Enabled = false;
            this.editServerIPPort.Enabled = false;
            this.editAverageTimes.Enabled = false;
            this.notifyIcon.ContextMenuStrip.Items[0].Enabled = false;
            if (!Running)
            {
                this.toolStripStatusLblStatusResult.Text = "处理中";
                cts = new CancellationTokenSource();
                ThreadPool.QueueUserWorkItem(new WaitCallback(DoInBackgroundThread), cts.Token);
                Running = true;
            }
            else
            {
                this.toolStripStatusLblStatusResult.Text = "处理中";
                cts.Cancel();
                Running = false;
            }
        }

        private void UIUpdateProgress(int status, string updatetime, List<double> pingresult, List<double> tcpresult, List<double> googleresult)
        {
            this.toolStripStatusLblLastUpdateTimeResult.Text = updatetime;
            if (status == 1)
            {
                updatetime = updatetime.Split(' ')[1];
                this.status_change_check(true);
                this.pingresult = pingresult;
                this.tcpresult = tcpresult;
                this.googleresult = googleresult;

                this.lblPingResult.ForeColor = Color.Black;
                this.lblTcpingResult.ForeColor = Color.Black;
                this.lblGoogleResult.ForeColor = Color.Black;
                string timeout = "";
                int threshold;
                threshold = strToInt(editWarningPingThreshold.Text,int.MaxValue);
                Console.WriteLine(threshold);
                if (checkBoxPingWarning.Checked && pingresult.Average() > threshold && pingresult.Average()!=2000)
                {
                    timeout += "Ping ";
                    this.lblPingResult.ForeColor = Color.Red;
                }
                threshold = strToInt(editWarningTcpingThreshold.Text,int.MaxValue);
                if (checkBoxTcpingWarning.Checked && tcpresult.Average() > threshold && tcpresult.Average() != 2000)
                {
                    timeout += "Tcping ";
                    this.lblTcpingResult.ForeColor = Color.Red;
                }
                threshold = strToInt(editWarningGoogleThreshold.Text,int.MaxValue);
                if (checkBoxGoogleWarning.Checked && googleresult.Average() > threshold && googleresult.Average() != 2000)
                {
                    timeout += "Google ";
                    this.lblGoogleResult.ForeColor = Color.Red;
                }
               
                if (timeout != "")
                {
                    this.notifyIcon.ShowBalloonTip(1000, "警告", timeout + "超时", ToolTipIcon.Info);
                }
                this.lblPingResult.Text = pingresult.Min() + "/" + pingresult.Max() + "/" + pingresult.Average() + "ms";
                pingseries.Points.AddXY(updatetime, pingresult.Average());
                this.lblTcpingResult.Text = tcpresult.Min() + "/" + tcpresult.Max() + "/" + tcpresult.Average() + "ms";
                tcpingseries.Points.AddXY(updatetime, tcpresult.Average());
                this.lblGoogleResult.Text = googleresult.Min() + "/" + googleresult.Max() + "/" + googleresult.Average() + "ms";
                googleseries.Points.AddXY(updatetime, googleresult.Average());
                if (pingseries.Points.Count > chtRecord.ChartAreas[0].AxisX.ScaleView.Size)
                {
                    chtRecord.ChartAreas[0].AxisX.ScaleView.Position = pingseries.Points.Count - chtRecord.ChartAreas[0].AxisX.ScaleView.Size;
                }
                chtRecord.Invalidate();
                using (StreamWriter sw = new StreamWriter("record.log", true))
                {
                    sw.WriteLine(String.Format("{0},{1:#.00},{2:#.00},{3:#.00}", updatetime, pingresult.Average(), tcpresult.Average(), googleresult.Average()));
                }
            }
            else
            {
                this.status_change_check(false);
            }
        }

        private void DoInBackgroundThread(object state)
        {
            CancellationToken token = (CancellationToken)state;
            DateTime dt = new DateTime();
            //如果直接在这个后台线程中调用UIUpdateProgress
            //可能会出现: System.InvalidOperationException
            //线程间操作无效: 从不是创建控件"XXX"的线程访问它。
            while (true)
            {
                dt = System.DateTime.Now;
                string strT = dt.ToString("yyyy-MM-dd HH:mm:ss");
                if (token.IsCancellationRequested)
                {
                    break;
                }

                string server_ip="";
                int server_port=0;
                string MyProxyHostString="";
                int MyProxyPort = 0;
                int interval = strToInt(editCheckInterval.Text,10);
                int averagetimes = strToInt(editAverageTimes.Text,3);
                if (interval < 1 ||  interval > 100)
                {
                    errorNotice("间隔不推荐");
                    break;
                }
                if (checkBoxPingOn.Checked == true || checkBoxTcpingOn.Checked == true)
                {
                    if (editServerIPPort.Text.Split(':').Length != 2)
                    {
                        errorNotice("服务器IP:端口错误");
                        break;
                    }
                    server_ip = editServerIPPort.Text.Split(':')[0];
                    server_port = strToInt(editServerIPPort.Text.Split(':')[1],-1);
                    if (server_port == -1)
                    {
                        errorNotice("服务器端口错误");
                        break;
                    }
                }
                if (checkBoxGoogleOn.Checked)
                {
                    if (editLocalIPPort.Text.Split(':').Length != 2)
                    {
                        errorNotice("代理IP:端口错误");
                        break;
                    }
                    MyProxyHostString = editLocalIPPort.Text.Split(':')[0];
                    MyProxyPort = strToInt(editLocalIPPort.Text.Split(':')[1],-1);
                    if (MyProxyPort == -1)
                    {
                        errorNotice("代理端口错误");
                        break;
                    } 
                }

                string ip;
                ip = this.GetReverseDNS(server_ip,1000);
                IPAddress IP;
                bool flag = IPAddress.TryParse(ip, out IP);
                if (!flag)
                {
                    errorNotice("服务器IP或域名错误");
                    break;
                }

                int processbarValue = 0;
                ProcessMaxValueDelegate max = new ProcessMaxValueDelegate(setProcessBarMax);
                this.Invoke(max, interval+3*averagetimes);
                ProcessNowValueDelegate now = new ProcessNowValueDelegate(setProcessBarNow);
                this.Invoke(now, processbarValue);

                //ping
                var pingtimes = new List<double>();
                if (checkBoxPingOn.Checked)
                {
                    Ping ping = new Ping();

                    for (int j = 0; j < averagetimes; j++)
                    {
                        PingReply pingReply = ping.Send(ip, 2000);
                        if (pingReply.Status == IPStatus.Success)
                        {
                            pingtimes.Add(pingReply.RoundtripTime);
                        }
                        else
                        {
                            pingtimes.Add(2000);
                        }
                        processbarValue += 1;
                        this.Invoke(now, processbarValue);
                    }
                }
                else
                {
                    pingtimes.Add(0);
                    processbarValue += averagetimes;
                    this.Invoke(now, processbarValue);
                }


                //tcping
                var tcptimes = new List<double>();
                if (checkBoxTcpingOn.Checked)
                {
                    for (int j = 0; j < averagetimes; j++)
                    {
                        try
                        {
                            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            var tcpstopwatch = new Stopwatch();
                            tcpstopwatch.Start();
                            IAsyncResult result = socket.BeginConnect(IP,server_port, null, null);
                            bool success = result.AsyncWaitHandle.WaitOne(2000, true);
                            if (socket.Connected)
                            {
                                socket.EndConnect(result);
                            }
                            else
                            {
                                socket.Close();
                                throw new ApplicationException("Failed to connect server.");
                            }
                            tcpstopwatch.Stop();
                            double tcpt = tcpstopwatch.Elapsed.TotalMilliseconds;
                            tcptimes.Add(tcpt);
                            Console.WriteLine(tcpt);
                        }
                        catch
                        {
                            tcptimes.Add(2000);
                        }
                        processbarValue += 1;
                        this.Invoke(now, processbarValue);
                    }
                }
                else
                {
                    tcptimes.Add(0);
                    processbarValue += averagetimes;
                    this.Invoke(now, processbarValue);
                }


                //调用Form对象的Invoke或BeginInvoke方法
                //传入的委托, 将会在UI线程中执行

                //google ping
                var googletimes = new List<double>();
                if (checkBoxGoogleOn.Checked)
                {
                    for (int j = 0; j < averagetimes; j++)
                    {
                        try
                        {
                            HttpWebRequest request = WebRequest.Create("https://www.google.com") as HttpWebRequest;
                            request.Proxy = new WebProxy(MyProxyHostString, MyProxyPort);
                            request.Method = "GET";
                            request.Timeout = 2000;
                            request.KeepAlive = false;
                            var googlestopwatch = new Stopwatch();
                            googlestopwatch.Start();
                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                            googlestopwatch.Stop();
                            double googlet = googlestopwatch.Elapsed.TotalMilliseconds;
                            googletimes.Add(googlet);
                        }
                        catch
                        {
                            googletimes.Add(2000);
                        }
                        processbarValue += 1;
                        this.Invoke(now, processbarValue);
                    }
                }
                else
                {
                    googletimes.Add(0);
                    processbarValue += averagetimes;
                    this.Invoke(now, processbarValue);
                }
                for (int j = 0; j < interval; j++)
                {
                    Thread.Sleep(1000);
                    processbarValue += 1;
                    this.Invoke(now, processbarValue);
                }
                this.BeginInvoke(updator, 1, strT, pingtimes, tcptimes, googletimes);
            }
            this.BeginInvoke(updator, 0, "-", null, null, null);
        }


        //tray funtion
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                notifyIcon.Text = String.Format("Ping:{0:#.00}ms\nTcp:{1:#.00}ms\nGoogle:{2:#.00}ms", this.pingresult.Average(), this.tcpresult.Average(), this.googleresult.Average());
            }
            catch
            {
                notifyIcon.Text = String.Format("Ping:-ms\nTcp:-ms\nGoogle:-ms");
            }
        }

        private void notifyIconMenuStart_Click(object sender, EventArgs e)
        {
            this.monitor();
        }

        private void notifyIconMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //tool strip
        private void toolStripMenuItemReadLog_Click(object sender, EventArgs e)
        {
            pingseries.Points.Clear();
            tcpingseries.Points.Clear();
            googleseries.Points.Clear();
            string line;
            using (StreamReader sr = new StreamReader("record.log"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var data = line.Split(',');
                    pingseries.Points.AddXY(data[0], data[1]);
                    tcpingseries.Points.AddXY(data[0], data[2]);
                    googleseries.Points.AddXY(data[0], data[3]);
                    chtRecord.Invalidate();
                }
            }
            if (pingseries.Points.Count > chtRecord.ChartAreas[0].AxisX.ScaleView.Size)
            {
                chtRecord.ChartAreas[0].AxisX.ScaleView.Position = pingseries.Points.Count - chtRecord.ChartAreas[0].AxisX.ScaleView.Size;
            }
        }

        private void toolStripMenuItemClearLog_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定清空?", "清空", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                using (StreamWriter sw = new StreamWriter("record.log"))
                {
                }
                MessageBox.Show("已清除", "清空", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItemClearData_Click(object sender, EventArgs e)
        {
            pingseries.Points.Clear();
            tcpingseries.Points.Clear();
            googleseries.Points.Clear();
            chtRecord.ChartAreas[0].AxisX.ScaleView.Position = 0;
            chtRecord.Invalidate();
        }

        private void toolStripMenuItemRun_Click(object sender, EventArgs e)
        {
            monitor();
        }

        private void toolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            monitor();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2020 Alfyn. All Rights Reserved", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //other function
        private delegate IPHostEntry GetHostEntryHandler(string ip);
        public string GetReverseDNS(string ip, int timeout)
        {
            try
            {
                GetHostEntryHandler callback = new GetHostEntryHandler(Dns.GetHostEntry);
                IAsyncResult result = callback.BeginInvoke(ip, null, null);
                if (result.AsyncWaitHandle.WaitOne(timeout, false))
                {
                    return callback.EndInvoke(result).AddressList[0].ToString();
                }
                else
                {
                    return ip;
                }
            }
            catch (Exception)
            {
                return ip;
            }
        }

        private delegate void ProcessMaxValueDelegate(int maxValue);
        private delegate void ProcessNowValueDelegate(int nowValue);

        private void setProcessBarMax(int maxValue)
        {
            toolStripProgressBarInterval.Maximum = maxValue;
        }

        private void setProcessBarNow(int nowValue)
        {
            toolStripProgressBarInterval.Value = nowValue;
        }

        private void onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void errorNotice(string e)
        {
            MessageBox.Show(e, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int strToInt(string s,int df)
        {
            try
            {
                Console.WriteLine("1");
                return Int32.Parse(s);
            }
            catch
            {
                return df;
            }
        }

        private void editAverageTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender,e);
        }

        private void editCheckInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void editWarningPingThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void editWarningTcpingThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }

        private void editWarningGoogleThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(sender, e);
        }
    }
}
