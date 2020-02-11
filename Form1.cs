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
        public delegate void UpdateProgress(int status, string updatetime, List<double> pingresult,List<double> tcpresult, List<double> googleresult);
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

            var MyIni = new IniFile("Settings.ini");
            this.editLocalIPPort.Text = MyIni.Read("local_ip_port","basic");
            this.editServerIPPort.Text = MyIni.Read("server_ip_port", "basic");
            try
            {
                this.checkBoxPing.Checked = Convert.ToBoolean(MyIni.Read("ping_threshold_enable", "threshold"));
            }
            catch
            {

            }
            this.editWarningPingThreshold.Text = MyIni.Read("ping_threshold_time", "threshold");
            try
            {
                this.checkBoxTcping.Checked = Convert.ToBoolean(MyIni.Read("tcping_threshold_enable", "threshold"));
            }
            catch
            {

            }
            this.editWarningTcpingThreshold.Text = MyIni.Read("tcping_threshold_time", "threshold");
            try
            {
                this.checkBoxGoogle.Checked = Convert.ToBoolean(MyIni.Read("google_threshold_enable", "threshold"));
            }
            catch
            {

            }
            this.editWarningGoogleThreshold.Text = MyIni.Read("google_threshold_time", "threshold");


            this.chtPing.Series.Clear();
            this.chtPing.Series.Add(pingseries);
            this.chtPing.Series.Add(tcpingseries);
            this.chtPing.Series.Add(googleseries);
            this.chtPing.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            this.chtPing.ChartAreas[0].AxisX.LabelStyle.Angle = -80;
            this.chtPing.ChartAreas[0].AxisX.LineWidth = 2;
            this.chtPing.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chtPing.ChartAreas[0].AxisX.Interval = 1;
            this.chtPing.ChartAreas[0].CursorX.AutoScroll = true;
            this.chtPing.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            this.chtPing.ChartAreas[0].AxisX.ScaleView.Size = 20;
            this.chtPing.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            this.chtPing.ChartAreas[0].AxisX.ScaleView.Zoom(0,20);
            this.chtPing.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            this.chtPing.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 20;
            this.chtPing.Series["Ping"].MarkerSize = 5;
            this.chtPing.Series["Ping"].MarkerStyle = MarkerStyle.Circle;
            this.chtPing.Series["Tcping"].MarkerSize = 5;
            this.chtPing.Series["Tcping"].MarkerStyle = MarkerStyle.Circle;
            this.chtPing.Series["Google"].MarkerSize = 5;
            this.chtPing.Series["Google"].MarkerStyle = MarkerStyle.Circle;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                Console.WriteLine("min");
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

        private void save_setting()
        {
            var MyIni = new IniFile("Settings.ini");
            MyIni.Write("local_ip_port", editLocalIPPort.Text, "basic");
            MyIni.Write("server_ip_port", editServerIPPort.Text, "basic");
            MyIni.Write("ping_threshold_enable",checkBoxPing.Checked.ToString(),"threshold");
            MyIni.Write("ping_threshold_time", editWarningPingThreshold.Text, "threshold");
            MyIni.Write("tcping_threshold_enable", checkBoxTcping.Checked.ToString(),"threshold");
            MyIni.Write("tcping_threshold_time", editWarningTcpingThreshold.Text, "threshold");
            MyIni.Write("google_threshold_enable", checkBoxGoogle.Checked.ToString(), "threshold");
            MyIni.Write("google_threshold_time", editWarningGoogleThreshold.Text, "threshold");
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
                this.runToolStripMenuItem.Enabled = false;
                this.stopToolStripMenuItem.Enabled = true;
                this.toolStripDropDownButtonData.Enabled = false;
            }
            else
            {
                this.toolStripStatusLblStatusResult.Text = "已停止";
                this.notifyIcon.ContextMenuStrip.Items[0].Text = "Start";
                this.runToolStripMenuItem.Enabled = true;
                this.stopToolStripMenuItem.Enabled = false;
                this.toolStripDropDownButtonData.Enabled = true;
            }
            this.notifyIcon.ContextMenuStrip.Items[0].Enabled = true;
        }

        private void monitor()
        {
            this.runToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Enabled = false;
            this.toolStripDropDownButtonData.Enabled = false;
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

        private void UIUpdateProgress(int status,string updatetime, List<double> pingresult,List<double> tcpresult, List<double> googleresult)
        {
            this.toolStripStatusLblLastUpdateTimeResult.Text = updatetime;
            if (status==1)
            {
                this.status_change_check(true);
                this.pingresult = pingresult;
                this.tcpresult = tcpresult;
                this.googleresult = googleresult;

                this.lblPingResult.ForeColor = Color.Black;
                this.lblTcpingResult.ForeColor = Color.Black;
                this.lblGoogleResult.ForeColor = Color.Black;
                string timeout = "";
                try
                {
                    int threshold = Int32.Parse(editWarningPingThreshold.Text);
                    if (pingresult.Average() >= threshold && checkBoxPing.Checked == true)
                    {
                        timeout += "Ping ";
                        this.lblPingResult.ForeColor = Color.Red;
                    }
                }
                catch
                {

                }

                try
                {
                    int threshold = Int32.Parse(editWarningTcpingThreshold.Text);
                    if (tcpresult.Average() >= threshold && checkBoxTcping.Checked == true)
                    {
                        timeout += "Tcping ";
                        this.lblTcpingResult.ForeColor = Color.Red;
                    }
                }
                catch
                {

                }
                try
                {
                    int threshold = Int32.Parse(editWarningGoogleThreshold.Text);
                    if (googleresult.Average() >= threshold && checkBoxGoogle.Checked == true)
                    {
                        timeout += "Google ";
                        this.lblGoogleResult.ForeColor = Color.Red;
                    }
                }
                catch
                {

                }
                if (timeout != "")
                {
                    this.notifyIcon.ShowBalloonTip(1000, "警告", timeout + "超时", ToolTipIcon.Info);
                }
                this.lblPingResult.Text = pingresult.Min() + "/" + pingresult.Max() + "/" + pingresult.Average() + "ms";
                this.lblTcpingResult.Text = tcpresult.Min() + "/" + tcpresult.Max() + "/" + tcpresult.Average() + "ms";
                this.lblGoogleResult.Text = googleresult.Min() + "/" + googleresult.Max() + "/" + googleresult.Average() + "ms";
                updatetime = updatetime.Split(' ')[1];
                pingseries.Points.AddXY(updatetime,pingresult.Average());
                tcpingseries.Points.AddXY(updatetime, tcpresult.Average());
                googleseries.Points.AddXY(updatetime, googleresult.Average());
                if (pingseries.Points.Count > chtPing.ChartAreas[0].AxisX.ScaleView.Size)
                {
                    chtPing.ChartAreas[0].AxisX.ScaleView.Position = pingseries.Points.Count - chtPing.ChartAreas[0].AxisX.ScaleView.Size;
                }
                chtPing.Invalidate();
                using (StreamWriter sw = new StreamWriter("record.log",true))
                {
                     sw.WriteLine(String.Format("{0},{1:#.00},{2:#.00},{3:#.00}",updatetime, pingresult.Average(), tcpresult.Average(), googleresult.Average()));
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
                string server_ip = editServerIPPort.Text.Split(':')[0];
                int server_port = 0;
                try
                {
                    server_port = Int32.Parse(editServerIPPort.Text.Split(':')[1]);
                }
                catch
                {
                    MessageBox.Show("server port error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                string MyProxyHostString = editLocalIPPort.Text.Split(':')[0];
                int MyProxyPort = 0;
                try
                {
                    MyProxyPort = Int32.Parse(editLocalIPPort.Text.Split(':')[1]);
                }
                catch
                {
                    MessageBox.Show("proxy port error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                int addresslength = 0;
                string ip;
                try
                {
                    IPHostEntry hostEntry;
                    hostEntry = Dns.GetHostEntry(server_ip);
                    ip = hostEntry.AddressList[0].ToString();
                    addresslength = hostEntry.AddressList.Length;
                }
                catch
                {
                    MessageBox.Show("dns resovle error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                //ping
                var pingtimes = new List<double>();
                Ping ping = new Ping();

                for (int j = 0; j < 4; j++)
                {
                    PingReply pingReply = ping.Send(ip,2000);
                    if (pingReply.Status == IPStatus.Success)
                    {
                        pingtimes.Add(pingReply.RoundtripTime);
                    }
                    else
                    {
                        pingtimes.Add(2000);
                    }
                }


                //tcping
                var tcptimes = new List<double>();
                if (addresslength > 0)
                {
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), server_port);
                    for (int j = 0; j < 4; j++)
                    {
                        try
                        {
                            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            sock.Blocking = true;

                            var tcpstopwatch = new Stopwatch();

                            // Measure the Connect call only
                            tcpstopwatch.Start();
                            sock.Connect(endPoint);
                            tcpstopwatch.Stop();

                            double tcpt = tcpstopwatch.Elapsed.TotalMilliseconds;
                            tcptimes.Add(tcpt);

                            sock.Close();
                        }
                        catch
                        {
                            tcptimes.Add(2000);
                        }
                    }
                }
              
                //调用Form对象的Invoke或BeginInvoke方法
                //传入的委托, 将会在UI线程中执行

                //google ping
                var googletimes = new List<double>();
                for (int j = 0; j < 4; j++)
                {
                    try
                    {
                        HttpWebRequest request = WebRequest.Create("https://www.google.com") as HttpWebRequest;
                        request.Proxy = new WebProxy(MyProxyHostString, MyProxyPort);
                        request.Method = "GET";
                        request.Timeout = 5000;
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
                }
                this.BeginInvoke(updator, 1, strT,pingtimes,tcptimes, googletimes) ;
                Thread.Sleep(60000);
            }
            this.BeginInvoke(updator,0 ,"-", null, null, null);
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


        private void readLogToolStripMenuItem_Click(object sender, EventArgs e)
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
                    chtPing.Invalidate();
                }
            }
            if (pingseries.Points.Count > chtPing.ChartAreas[0].AxisX.ScaleView.Size)
            {
                chtPing.ChartAreas[0].AxisX.ScaleView.Position = pingseries.Points.Count - chtPing.ChartAreas[0].AxisX.ScaleView.Size;
            }
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pingseries.Points.Clear();
            tcpingseries.Points.Clear();
            googleseries.Points.Clear();
            chtPing.ChartAreas[0].AxisX.ScaleView.Position = 0;
            chtPing.Invalidate();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitor();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitor();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© 2020 Alfyn. All Rights Reserved", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
