namespace networkanalyzer
{
    partial class NetworkAnalyzer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkAnalyzer));
            this.editLocalIPPort = new System.Windows.Forms.TextBox();
            this.lblLocalIPPort = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTcpingResult = new System.Windows.Forms.Label();
            this.lblGoogleResult = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblStatusResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblLastUpdateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblLastUpdateTimeResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBlank = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarInterval = new System.Windows.Forms.ToolStripProgressBar();
            this.lblPingResult = new System.Windows.Forms.Label();
            this.chtRecord = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxRecord = new System.Windows.Forms.GroupBox();
            this.groupBoxNowRecord = new System.Windows.Forms.GroupBox();
            this.checkBoxGoogleOn = new System.Windows.Forms.CheckBox();
            this.checkBoxTcpingOn = new System.Windows.Forms.CheckBox();
            this.checkBoxPingOn = new System.Windows.Forms.CheckBox();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.editAverageTimes = new System.Windows.Forms.TextBox();
            this.lblAverageTimes = new System.Windows.Forms.Label();
            this.lblCheckInterval = new System.Windows.Forms.Label();
            this.editCheckInterval = new System.Windows.Forms.TextBox();
            this.groupBoxWarningThreshold = new System.Windows.Forms.GroupBox();
            this.checkBoxGoogleWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxTcpingWarning = new System.Windows.Forms.CheckBox();
            this.checkBoxPingWarning = new System.Windows.Forms.CheckBox();
            this.editWarningGoogleThreshold = new System.Windows.Forms.TextBox();
            this.editWarningTcpingThreshold = new System.Windows.Forms.TextBox();
            this.editWarningPingThreshold = new System.Windows.Forms.TextBox();
            this.lblServerIPPort = new System.Windows.Forms.Label();
            this.editServerIPPort = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonRun = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemRun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonData = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReadLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClearData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRecord)).BeginInit();
            this.groupBoxNowRecord.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.groupBoxWarningThreshold.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // editLocalIPPort
            // 
            this.editLocalIPPort.Location = new System.Drawing.Point(109, 20);
            this.editLocalIPPort.Name = "editLocalIPPort";
            this.editLocalIPPort.Size = new System.Drawing.Size(220, 21);
            this.editLocalIPPort.TabIndex = 0;
            // 
            // lblLocalIPPort
            // 
            this.lblLocalIPPort.AutoSize = true;
            this.lblLocalIPPort.Location = new System.Drawing.Point(32, 23);
            this.lblLocalIPPort.Name = "lblLocalIPPort";
            this.lblLocalIPPort.Size = new System.Drawing.Size(71, 12);
            this.lblLocalIPPort.TabIndex = 1;
            this.lblLocalIPPort.Text = "代理IP:端口";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTcpingResult
            // 
            this.lblTcpingResult.AutoSize = true;
            this.lblTcpingResult.Location = new System.Drawing.Point(18, 94);
            this.lblTcpingResult.Name = "lblTcpingResult";
            this.lblTcpingResult.Size = new System.Drawing.Size(11, 12);
            this.lblTcpingResult.TabIndex = 5;
            this.lblTcpingResult.Text = "-";
            // 
            // lblGoogleResult
            // 
            this.lblGoogleResult.AutoSize = true;
            this.lblGoogleResult.Location = new System.Drawing.Point(18, 137);
            this.lblGoogleResult.Name = "lblGoogleResult";
            this.lblGoogleResult.Size = new System.Drawing.Size(11, 12);
            this.lblGoogleResult.TabIndex = 6;
            this.lblGoogleResult.Text = "-";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblStatus,
            this.toolStripStatusLblStatusResult,
            this.toolStripStatusLblLastUpdateTime,
            this.toolStripStatusLblLastUpdateTimeResult,
            this.toolStripStatusLabelBlank,
            this.toolStripProgressBarInterval});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLblStatus
            // 
            this.toolStripStatusLblStatus.Name = "toolStripStatusLblStatus";
            this.toolStripStatusLblStatus.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLblStatus.Text = "当前状态：";
            // 
            // toolStripStatusLblStatusResult
            // 
            this.toolStripStatusLblStatusResult.Name = "toolStripStatusLblStatusResult";
            this.toolStripStatusLblStatusResult.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLblStatusResult.Text = "停止";
            // 
            // toolStripStatusLblLastUpdateTime
            // 
            this.toolStripStatusLblLastUpdateTime.Name = "toolStripStatusLblLastUpdateTime";
            this.toolStripStatusLblLastUpdateTime.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLblLastUpdateTime.Text = "上次更新时间：";
            // 
            // toolStripStatusLblLastUpdateTimeResult
            // 
            this.toolStripStatusLblLastUpdateTimeResult.Name = "toolStripStatusLblLastUpdateTimeResult";
            this.toolStripStatusLblLastUpdateTimeResult.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLblLastUpdateTimeResult.Text = "-";
            // 
            // toolStripStatusLabelBlank
            // 
            this.toolStripStatusLabelBlank.Name = "toolStripStatusLabelBlank";
            this.toolStripStatusLabelBlank.Size = new System.Drawing.Size(593, 17);
            this.toolStripStatusLabelBlank.Spring = true;
            // 
            // toolStripProgressBarInterval
            // 
            this.toolStripProgressBarInterval.Name = "toolStripProgressBarInterval";
            this.toolStripProgressBarInterval.Size = new System.Drawing.Size(100, 16);
            // 
            // lblPingResult
            // 
            this.lblPingResult.AutoSize = true;
            this.lblPingResult.Location = new System.Drawing.Point(18, 51);
            this.lblPingResult.Name = "lblPingResult";
            this.lblPingResult.Size = new System.Drawing.Size(11, 12);
            this.lblPingResult.TabIndex = 10;
            this.lblPingResult.Text = "-";
            // 
            // chtRecord
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRecord.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chtRecord.Legends.Add(legend1);
            this.chtRecord.Location = new System.Drawing.Point(396, 61);
            this.chtRecord.Name = "chtRecord";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtRecord.Series.Add(series1);
            this.chtRecord.Size = new System.Drawing.Size(488, 338);
            this.chtRecord.TabIndex = 11;
            this.chtRecord.Text = "chtPing";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // groupBoxRecord
            // 
            this.groupBoxRecord.Location = new System.Drawing.Point(377, 41);
            this.groupBoxRecord.Name = "groupBoxRecord";
            this.groupBoxRecord.Size = new System.Drawing.Size(526, 361);
            this.groupBoxRecord.TabIndex = 12;
            this.groupBoxRecord.TabStop = false;
            this.groupBoxRecord.Text = "延迟记录";
            // 
            // groupBoxNowRecord
            // 
            this.groupBoxNowRecord.Controls.Add(this.checkBoxGoogleOn);
            this.groupBoxNowRecord.Controls.Add(this.checkBoxTcpingOn);
            this.groupBoxNowRecord.Controls.Add(this.checkBoxPingOn);
            this.groupBoxNowRecord.Controls.Add(this.lblPingResult);
            this.groupBoxNowRecord.Controls.Add(this.lblTcpingResult);
            this.groupBoxNowRecord.Controls.Add(this.lblGoogleResult);
            this.groupBoxNowRecord.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxNowRecord.Location = new System.Drawing.Point(13, 236);
            this.groupBoxNowRecord.Name = "groupBoxNowRecord";
            this.groupBoxNowRecord.Size = new System.Drawing.Size(348, 166);
            this.groupBoxNowRecord.TabIndex = 13;
            this.groupBoxNowRecord.TabStop = false;
            this.groupBoxNowRecord.Text = "当前延迟";
            // 
            // checkBoxGoogleOn
            // 
            this.checkBoxGoogleOn.AutoSize = true;
            this.checkBoxGoogleOn.Location = new System.Drawing.Point(17, 118);
            this.checkBoxGoogleOn.Name = "checkBoxGoogleOn";
            this.checkBoxGoogleOn.Size = new System.Drawing.Size(60, 16);
            this.checkBoxGoogleOn.TabIndex = 13;
            this.checkBoxGoogleOn.Text = "Google";
            this.checkBoxGoogleOn.UseVisualStyleBackColor = true;
            // 
            // checkBoxTcpingOn
            // 
            this.checkBoxTcpingOn.AutoSize = true;
            this.checkBoxTcpingOn.Location = new System.Drawing.Point(17, 75);
            this.checkBoxTcpingOn.Name = "checkBoxTcpingOn";
            this.checkBoxTcpingOn.Size = new System.Drawing.Size(60, 16);
            this.checkBoxTcpingOn.TabIndex = 12;
            this.checkBoxTcpingOn.Text = "Tcping";
            this.checkBoxTcpingOn.UseVisualStyleBackColor = true;
            // 
            // checkBoxPingOn
            // 
            this.checkBoxPingOn.AutoSize = true;
            this.checkBoxPingOn.Location = new System.Drawing.Point(17, 32);
            this.checkBoxPingOn.Name = "checkBoxPingOn";
            this.checkBoxPingOn.Size = new System.Drawing.Size(48, 16);
            this.checkBoxPingOn.TabIndex = 11;
            this.checkBoxPingOn.Text = "Ping";
            this.checkBoxPingOn.UseVisualStyleBackColor = true;
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Controls.Add(this.editAverageTimes);
            this.groupBoxSetting.Controls.Add(this.lblAverageTimes);
            this.groupBoxSetting.Controls.Add(this.lblCheckInterval);
            this.groupBoxSetting.Controls.Add(this.editCheckInterval);
            this.groupBoxSetting.Controls.Add(this.groupBoxWarningThreshold);
            this.groupBoxSetting.Controls.Add(this.lblServerIPPort);
            this.groupBoxSetting.Controls.Add(this.editServerIPPort);
            this.groupBoxSetting.Controls.Add(this.btnSave);
            this.groupBoxSetting.Controls.Add(this.lblLocalIPPort);
            this.groupBoxSetting.Controls.Add(this.editLocalIPPort);
            this.groupBoxSetting.Location = new System.Drawing.Point(13, 41);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(348, 189);
            this.groupBoxSetting.TabIndex = 14;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "设置";
            // 
            // editAverageTimes
            // 
            this.editAverageTimes.Location = new System.Drawing.Point(291, 120);
            this.editAverageTimes.Name = "editAverageTimes";
            this.editAverageTimes.Size = new System.Drawing.Size(38, 21);
            this.editAverageTimes.TabIndex = 13;
            this.editAverageTimes.Text = "3";
            this.editAverageTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editAverageTimes_KeyPress);
            // 
            // lblAverageTimes
            // 
            this.lblAverageTimes.AutoSize = true;
            this.lblAverageTimes.Location = new System.Drawing.Point(214, 123);
            this.lblAverageTimes.Name = "lblAverageTimes";
            this.lblAverageTimes.Size = new System.Drawing.Size(53, 12);
            this.lblAverageTimes.TabIndex = 12;
            this.lblAverageTimes.Text = "平均次数";
            this.toolTip.SetToolTip(this.lblAverageTimes, "指对n次测试去最后平均值");
            // 
            // lblCheckInterval
            // 
            this.lblCheckInterval.AutoSize = true;
            this.lblCheckInterval.Location = new System.Drawing.Point(214, 92);
            this.lblCheckInterval.Name = "lblCheckInterval";
            this.lblCheckInterval.Size = new System.Drawing.Size(71, 12);
            this.lblCheckInterval.TabIndex = 11;
            this.lblCheckInterval.Text = "检测间隔(s)";
            this.toolTip.SetToolTip(this.lblCheckInterval, "由于延迟计算为四次取平均值，故此处非绝对间隔，且不要设置太短。");
            // 
            // editCheckInterval
            // 
            this.editCheckInterval.Location = new System.Drawing.Point(291, 89);
            this.editCheckInterval.Name = "editCheckInterval";
            this.editCheckInterval.Size = new System.Drawing.Size(38, 21);
            this.editCheckInterval.TabIndex = 10;
            this.editCheckInterval.Text = "10";
            this.editCheckInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCheckInterval_KeyPress);
            // 
            // groupBoxWarningThreshold
            // 
            this.groupBoxWarningThreshold.Controls.Add(this.checkBoxGoogleWarning);
            this.groupBoxWarningThreshold.Controls.Add(this.checkBoxTcpingWarning);
            this.groupBoxWarningThreshold.Controls.Add(this.checkBoxPingWarning);
            this.groupBoxWarningThreshold.Controls.Add(this.editWarningGoogleThreshold);
            this.groupBoxWarningThreshold.Controls.Add(this.editWarningTcpingThreshold);
            this.groupBoxWarningThreshold.Controls.Add(this.editWarningPingThreshold);
            this.groupBoxWarningThreshold.Location = new System.Drawing.Point(22, 74);
            this.groupBoxWarningThreshold.Name = "groupBoxWarningThreshold";
            this.groupBoxWarningThreshold.Size = new System.Drawing.Size(186, 99);
            this.groupBoxWarningThreshold.TabIndex = 9;
            this.groupBoxWarningThreshold.TabStop = false;
            this.groupBoxWarningThreshold.Text = "警告阈值(ms)";
            // 
            // checkBoxGoogleWarning
            // 
            this.checkBoxGoogleWarning.AutoSize = true;
            this.checkBoxGoogleWarning.Location = new System.Drawing.Point(25, 64);
            this.checkBoxGoogleWarning.Name = "checkBoxGoogleWarning";
            this.checkBoxGoogleWarning.Size = new System.Drawing.Size(60, 16);
            this.checkBoxGoogleWarning.TabIndex = 13;
            this.checkBoxGoogleWarning.Text = "Google";
            this.checkBoxGoogleWarning.UseVisualStyleBackColor = true;
            // 
            // checkBoxTcpingWarning
            // 
            this.checkBoxTcpingWarning.AutoSize = true;
            this.checkBoxTcpingWarning.Location = new System.Drawing.Point(25, 42);
            this.checkBoxTcpingWarning.Name = "checkBoxTcpingWarning";
            this.checkBoxTcpingWarning.Size = new System.Drawing.Size(60, 16);
            this.checkBoxTcpingWarning.TabIndex = 12;
            this.checkBoxTcpingWarning.Text = "Tcping";
            this.checkBoxTcpingWarning.UseVisualStyleBackColor = true;
            // 
            // checkBoxPingWarning
            // 
            this.checkBoxPingWarning.AutoSize = true;
            this.checkBoxPingWarning.Location = new System.Drawing.Point(25, 20);
            this.checkBoxPingWarning.Name = "checkBoxPingWarning";
            this.checkBoxPingWarning.Size = new System.Drawing.Size(48, 16);
            this.checkBoxPingWarning.TabIndex = 11;
            this.checkBoxPingWarning.Text = "Ping";
            this.checkBoxPingWarning.UseVisualStyleBackColor = true;
            // 
            // editWarningGoogleThreshold
            // 
            this.editWarningGoogleThreshold.Location = new System.Drawing.Point(87, 62);
            this.editWarningGoogleThreshold.Name = "editWarningGoogleThreshold";
            this.editWarningGoogleThreshold.Size = new System.Drawing.Size(77, 21);
            this.editWarningGoogleThreshold.TabIndex = 10;
            this.editWarningGoogleThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editWarningGoogleThreshold_KeyPress);
            // 
            // editWarningTcpingThreshold
            // 
            this.editWarningTcpingThreshold.Location = new System.Drawing.Point(87, 40);
            this.editWarningTcpingThreshold.Name = "editWarningTcpingThreshold";
            this.editWarningTcpingThreshold.Size = new System.Drawing.Size(77, 21);
            this.editWarningTcpingThreshold.TabIndex = 9;
            this.editWarningTcpingThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editWarningTcpingThreshold_KeyPress);
            // 
            // editWarningPingThreshold
            // 
            this.editWarningPingThreshold.Location = new System.Drawing.Point(87, 18);
            this.editWarningPingThreshold.Name = "editWarningPingThreshold";
            this.editWarningPingThreshold.Size = new System.Drawing.Size(77, 21);
            this.editWarningPingThreshold.TabIndex = 8;
            this.editWarningPingThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editWarningPingThreshold_KeyPress);
            // 
            // lblServerIPPort
            // 
            this.lblServerIPPort.AutoSize = true;
            this.lblServerIPPort.Location = new System.Drawing.Point(20, 50);
            this.lblServerIPPort.Name = "lblServerIPPort";
            this.lblServerIPPort.Size = new System.Drawing.Size(83, 12);
            this.lblServerIPPort.TabIndex = 6;
            this.lblServerIPPort.Text = "服务器IP:端口";
            // 
            // editServerIPPort
            // 
            this.editServerIPPort.Location = new System.Drawing.Point(109, 47);
            this.editServerIPPort.Name = "editServerIPPort";
            this.editServerIPPort.Size = new System.Drawing.Size(220, 21);
            this.editServerIPPort.TabIndex = 5;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonRun,
            this.toolStripDropDownButtonData,
            this.toolStripButtonAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(915, 25);
            this.toolStrip.TabIndex = 18;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripDropDownButtonRun
            // 
            this.toolStripDropDownButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRun,
            this.toolStripMenuItemStop});
            this.toolStripDropDownButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonRun.Image")));
            this.toolStripDropDownButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonRun.Name = "toolStripDropDownButtonRun";
            this.toolStripDropDownButtonRun.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButtonRun.Text = "运行";
            // 
            // toolStripMenuItemRun
            // 
            this.toolStripMenuItemRun.Name = "toolStripMenuItemRun";
            this.toolStripMenuItemRun.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemRun.Text = "运行";
            this.toolStripMenuItemRun.Click += new System.EventHandler(this.toolStripMenuItemRun_Click);
            // 
            // toolStripMenuItemStop
            // 
            this.toolStripMenuItemStop.Enabled = false;
            this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            this.toolStripMenuItemStop.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemStop.Text = "停止";
            this.toolStripMenuItemStop.Click += new System.EventHandler(this.toolStripMenuItemStop_Click);
            // 
            // toolStripDropDownButtonData
            // 
            this.toolStripDropDownButtonData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLog,
            this.toolStripMenuItemClearData});
            this.toolStripDropDownButtonData.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonData.Image")));
            this.toolStripDropDownButtonData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonData.Name = "toolStripDropDownButtonData";
            this.toolStripDropDownButtonData.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButtonData.Text = "数据";
            // 
            // toolStripMenuItemLog
            // 
            this.toolStripMenuItemLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReadLog,
            this.toolStripMenuItemClearLog});
            this.toolStripMenuItemLog.Name = "toolStripMenuItemLog";
            this.toolStripMenuItemLog.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemLog.Text = "日志";
            // 
            // toolStripMenuItemReadLog
            // 
            this.toolStripMenuItemReadLog.Name = "toolStripMenuItemReadLog";
            this.toolStripMenuItemReadLog.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemReadLog.Text = "读取日志";
            this.toolStripMenuItemReadLog.Click += new System.EventHandler(this.toolStripMenuItemReadLog_Click);
            // 
            // toolStripMenuItemClearLog
            // 
            this.toolStripMenuItemClearLog.Name = "toolStripMenuItemClearLog";
            this.toolStripMenuItemClearLog.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemClearLog.Text = "清空日志";
            this.toolStripMenuItemClearLog.Click += new System.EventHandler(this.toolStripMenuItemClearLog_Click);
            // 
            // toolStripMenuItemClearData
            // 
            this.toolStripMenuItemClearData.Name = "toolStripMenuItemClearData";
            this.toolStripMenuItemClearData.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemClearData.Text = "清除数据";
            this.toolStripMenuItemClearData.Click += new System.EventHandler(this.toolStripMenuItemClearData_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(36, 22);
            this.toolStripButtonAbout.Text = "关于";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // NetworkAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 435);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.groupBoxNowRecord);
            this.Controls.Add(this.chtRecord);
            this.Controls.Add(this.groupBoxRecord);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NetworkAnalyzer";
            this.Text = "NetworkAnalyzer";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRecord)).EndInit();
            this.groupBoxNowRecord.ResumeLayout(false);
            this.groupBoxNowRecord.PerformLayout();
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.groupBoxWarningThreshold.ResumeLayout(false);
            this.groupBoxWarningThreshold.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editLocalIPPort;
        private System.Windows.Forms.Label lblLocalIPPort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTcpingResult;
        private System.Windows.Forms.Label lblGoogleResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblLastUpdateTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblLastUpdateTimeResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblStatusResult;
        private System.Windows.Forms.Label lblPingResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRecord;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox groupBoxRecord;
        private System.Windows.Forms.GroupBox groupBoxNowRecord;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Label lblServerIPPort;
        private System.Windows.Forms.TextBox editServerIPPort;
        private System.Windows.Forms.TextBox editWarningPingThreshold;
        private System.Windows.Forms.GroupBox groupBoxWarningThreshold;
        private System.Windows.Forms.CheckBox checkBoxGoogleWarning;
        private System.Windows.Forms.CheckBox checkBoxTcpingWarning;
        private System.Windows.Forms.CheckBox checkBoxPingWarning;
        private System.Windows.Forms.TextBox editWarningGoogleThreshold;
        private System.Windows.Forms.TextBox editWarningTcpingThreshold;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonData;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReadLog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearLog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearData;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonRun;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRun;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.CheckBox checkBoxGoogleOn;
        private System.Windows.Forms.CheckBox checkBoxTcpingOn;
        private System.Windows.Forms.CheckBox checkBoxPingOn;
        private System.Windows.Forms.Label lblCheckInterval;
        private System.Windows.Forms.TextBox editCheckInterval;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblAverageTimes;
        private System.Windows.Forms.TextBox editAverageTimes;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarInterval;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBlank;
    }
}

