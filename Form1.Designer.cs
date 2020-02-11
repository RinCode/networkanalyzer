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
            this.lblTcping = new System.Windows.Forms.Label();
            this.lblGoogle = new System.Windows.Forms.Label();
            this.lblTcpingResult = new System.Windows.Forms.Label();
            this.lblGoogleResult = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblStatusResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblLastUpdateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblLastUpdateTimeResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPing = new System.Windows.Forms.Label();
            this.lblPingResult = new System.Windows.Forms.Label();
            this.chtPing = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxRecord = new System.Windows.Forms.GroupBox();
            this.groupBoxNowRecord = new System.Windows.Forms.GroupBox();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.groupBoxWarningThreshold = new System.Windows.Forms.GroupBox();
            this.checkBoxGoogle = new System.Windows.Forms.CheckBox();
            this.checkBoxTcping = new System.Windows.Forms.CheckBox();
            this.checkBoxPing = new System.Windows.Forms.CheckBox();
            this.editWarningGoogleThreshold = new System.Windows.Forms.TextBox();
            this.editWarningTcpingThreshold = new System.Windows.Forms.TextBox();
            this.editWarningPingThreshold = new System.Windows.Forms.TextBox();
            this.lblServerIPPort = new System.Windows.Forms.Label();
            this.editServerIPPort = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonRun = new System.Windows.Forms.ToolStripDropDownButton();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonData = new System.Windows.Forms.ToolStripDropDownButton();
            this.日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPing)).BeginInit();
            this.groupBoxNowRecord.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.groupBoxWarningThreshold.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.lblLocalIPPort.Text = "本地IP:端口";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(239, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTcping
            // 
            this.lblTcping.AutoSize = true;
            this.lblTcping.Location = new System.Drawing.Point(18, 74);
            this.lblTcping.Name = "lblTcping";
            this.lblTcping.Size = new System.Drawing.Size(77, 12);
            this.lblTcping.TabIndex = 3;
            this.lblTcping.Text = "Tcping延迟：";
            // 
            // lblGoogle
            // 
            this.lblGoogle.AutoSize = true;
            this.lblGoogle.Location = new System.Drawing.Point(18, 119);
            this.lblGoogle.Name = "lblGoogle";
            this.lblGoogle.Size = new System.Drawing.Size(77, 12);
            this.lblGoogle.TabIndex = 4;
            this.lblGoogle.Text = "Google延迟：";
            // 
            // lblTcpingResult
            // 
            this.lblTcpingResult.AutoSize = true;
            this.lblTcpingResult.Location = new System.Drawing.Point(18, 98);
            this.lblTcpingResult.Name = "lblTcpingResult";
            this.lblTcpingResult.Size = new System.Drawing.Size(11, 12);
            this.lblTcpingResult.TabIndex = 5;
            this.lblTcpingResult.Text = "-";
            // 
            // lblGoogleResult
            // 
            this.lblGoogleResult.AutoSize = true;
            this.lblGoogleResult.Location = new System.Drawing.Point(18, 141);
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
            this.toolStripStatusLblLastUpdateTimeResult});
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
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Location = new System.Drawing.Point(18, 28);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(65, 12);
            this.lblPing.TabIndex = 9;
            this.lblPing.Text = "Ping延迟：";
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
            // chtPing
            // 
            chartArea1.Name = "ChartArea1";
            this.chtPing.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chtPing.Legends.Add(legend1);
            this.chtPing.Location = new System.Drawing.Point(396, 61);
            this.chtPing.Name = "chtPing";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtPing.Series.Add(series1);
            this.chtPing.Size = new System.Drawing.Size(488, 338);
            this.chtPing.TabIndex = 11;
            this.chtPing.Text = "chtPing";
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
            this.groupBoxNowRecord.Controls.Add(this.lblPing);
            this.groupBoxNowRecord.Controls.Add(this.lblPingResult);
            this.groupBoxNowRecord.Controls.Add(this.lblTcping);
            this.groupBoxNowRecord.Controls.Add(this.lblTcpingResult);
            this.groupBoxNowRecord.Controls.Add(this.lblGoogle);
            this.groupBoxNowRecord.Controls.Add(this.lblGoogleResult);
            this.groupBoxNowRecord.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxNowRecord.Location = new System.Drawing.Point(13, 236);
            this.groupBoxNowRecord.Name = "groupBoxNowRecord";
            this.groupBoxNowRecord.Size = new System.Drawing.Size(348, 166);
            this.groupBoxNowRecord.TabIndex = 13;
            this.groupBoxNowRecord.TabStop = false;
            this.groupBoxNowRecord.Text = "当前延迟";
            // 
            // groupBoxSetting
            // 
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
            // groupBoxWarningThreshold
            // 
            this.groupBoxWarningThreshold.Controls.Add(this.checkBoxGoogle);
            this.groupBoxWarningThreshold.Controls.Add(this.checkBoxTcping);
            this.groupBoxWarningThreshold.Controls.Add(this.checkBoxPing);
            this.groupBoxWarningThreshold.Controls.Add(this.editWarningGoogleThreshold);
            this.groupBoxWarningThreshold.Controls.Add(this.editWarningTcpingThreshold);
            this.groupBoxWarningThreshold.Controls.Add(this.editWarningPingThreshold);
            this.groupBoxWarningThreshold.Location = new System.Drawing.Point(22, 74);
            this.groupBoxWarningThreshold.Name = "groupBoxWarningThreshold";
            this.groupBoxWarningThreshold.Size = new System.Drawing.Size(211, 99);
            this.groupBoxWarningThreshold.TabIndex = 9;
            this.groupBoxWarningThreshold.TabStop = false;
            this.groupBoxWarningThreshold.Text = "警告阈值(ms)";
            // 
            // checkBoxGoogle
            // 
            this.checkBoxGoogle.AutoSize = true;
            this.checkBoxGoogle.Location = new System.Drawing.Point(25, 64);
            this.checkBoxGoogle.Name = "checkBoxGoogle";
            this.checkBoxGoogle.Size = new System.Drawing.Size(60, 16);
            this.checkBoxGoogle.TabIndex = 13;
            this.checkBoxGoogle.Text = "Google";
            this.checkBoxGoogle.UseVisualStyleBackColor = true;
            // 
            // checkBoxTcping
            // 
            this.checkBoxTcping.AutoSize = true;
            this.checkBoxTcping.Location = new System.Drawing.Point(25, 42);
            this.checkBoxTcping.Name = "checkBoxTcping";
            this.checkBoxTcping.Size = new System.Drawing.Size(60, 16);
            this.checkBoxTcping.TabIndex = 12;
            this.checkBoxTcping.Text = "Tcping";
            this.checkBoxTcping.UseVisualStyleBackColor = true;
            // 
            // checkBoxPing
            // 
            this.checkBoxPing.AutoSize = true;
            this.checkBoxPing.Location = new System.Drawing.Point(25, 20);
            this.checkBoxPing.Name = "checkBoxPing";
            this.checkBoxPing.Size = new System.Drawing.Size(48, 16);
            this.checkBoxPing.TabIndex = 11;
            this.checkBoxPing.Text = "Ping";
            this.checkBoxPing.UseVisualStyleBackColor = true;
            // 
            // editWarningGoogleThreshold
            // 
            this.editWarningGoogleThreshold.Location = new System.Drawing.Point(87, 62);
            this.editWarningGoogleThreshold.Name = "editWarningGoogleThreshold";
            this.editWarningGoogleThreshold.Size = new System.Drawing.Size(77, 21);
            this.editWarningGoogleThreshold.TabIndex = 10;
            // 
            // editWarningTcpingThreshold
            // 
            this.editWarningTcpingThreshold.Location = new System.Drawing.Point(87, 40);
            this.editWarningTcpingThreshold.Name = "editWarningTcpingThreshold";
            this.editWarningTcpingThreshold.Size = new System.Drawing.Size(77, 21);
            this.editWarningTcpingThreshold.TabIndex = 9;
            // 
            // editWarningPingThreshold
            // 
            this.editWarningPingThreshold.Location = new System.Drawing.Point(87, 18);
            this.editWarningPingThreshold.Name = "editWarningPingThreshold";
            this.editWarningPingThreshold.Size = new System.Drawing.Size(77, 21);
            this.editWarningPingThreshold.TabIndex = 8;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonRun,
            this.toolStripDropDownButtonData,
            this.toolStripButtonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(915, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripDropDownButtonRun
            // 
            this.toolStripDropDownButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.toolStripDropDownButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonRun.Image")));
            this.toolStripDropDownButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonRun.Name = "toolStripDropDownButtonRun";
            this.toolStripDropDownButtonRun.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButtonRun.Text = "运行";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Text = "运行";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "停止";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonData
            // 
            this.toolStripDropDownButtonData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日志ToolStripMenuItem,
            this.clearDataToolStripMenuItem});
            this.toolStripDropDownButtonData.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonData.Image")));
            this.toolStripDropDownButtonData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonData.Name = "toolStripDropDownButtonData";
            this.toolStripDropDownButtonData.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButtonData.Text = "数据";
            // 
            // 日志ToolStripMenuItem
            // 
            this.日志ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readLogToolStripMenuItem,
            this.clearLogToolStripMenuItem});
            this.日志ToolStripMenuItem.Name = "日志ToolStripMenuItem";
            this.日志ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.日志ToolStripMenuItem.Text = "日志";
            // 
            // readLogToolStripMenuItem
            // 
            this.readLogToolStripMenuItem.Name = "readLogToolStripMenuItem";
            this.readLogToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.readLogToolStripMenuItem.Text = "读取日志";
            this.readLogToolStripMenuItem.Click += new System.EventHandler(this.readLogToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearLogToolStripMenuItem.Text = "清空日志";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearDataToolStripMenuItem.Text = "清除数据";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
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
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.groupBoxNowRecord);
            this.Controls.Add(this.chtPing);
            this.Controls.Add(this.groupBoxRecord);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetworkAnalyzer";
            this.Text = "NetworkAnalyzer";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPing)).EndInit();
            this.groupBoxNowRecord.ResumeLayout(false);
            this.groupBoxNowRecord.PerformLayout();
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.groupBoxWarningThreshold.ResumeLayout(false);
            this.groupBoxWarningThreshold.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editLocalIPPort;
        private System.Windows.Forms.Label lblLocalIPPort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTcping;
        private System.Windows.Forms.Label lblGoogle;
        private System.Windows.Forms.Label lblTcpingResult;
        private System.Windows.Forms.Label lblGoogleResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblLastUpdateTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblLastUpdateTimeResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblStatusResult;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.Label lblPingResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPing;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox groupBoxRecord;
        private System.Windows.Forms.GroupBox groupBoxNowRecord;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblServerIPPort;
        private System.Windows.Forms.TextBox editServerIPPort;
        private System.Windows.Forms.TextBox editWarningPingThreshold;
        private System.Windows.Forms.GroupBox groupBoxWarningThreshold;
        private System.Windows.Forms.CheckBox checkBoxGoogle;
        private System.Windows.Forms.CheckBox checkBoxTcping;
        private System.Windows.Forms.CheckBox checkBoxPing;
        private System.Windows.Forms.TextBox editWarningGoogleThreshold;
        private System.Windows.Forms.TextBox editWarningTcpingThreshold;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonData;
        private System.Windows.Forms.ToolStripMenuItem 日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonRun;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
    }
}

