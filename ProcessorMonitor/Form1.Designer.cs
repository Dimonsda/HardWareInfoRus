namespace ProcessorMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pcProcessor = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcMemoryAvailable = new System.Diagnostics.PerformanceCounter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temper = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblMemoryAvailable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Multipl = new MetroFramework.Controls.MetroLabel();
            this.L3Cache = new MetroFramework.Controls.MetroLabel();
            this.L2Cache = new MetroFramework.Controls.MetroLabel();
            this.L1Cache = new MetroFramework.Controls.MetroLabel();
            this.ramspeedl = new MetroFramework.Controls.MetroLabel();
            this.Socket = new MetroFramework.Controls.MetroLabel();
            this.cpusocket = new MetroFramework.Controls.MetroLabel();
            this.lblProcessor = new MetroFramework.Controls.MetroLabel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.Memory = new System.Diagnostics.PerformanceCounter();
            this.Hddinfo1 = new System.Diagnostics.PerformanceCounter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MonitorSize = new MetroFramework.Controls.MetroLabel();
            this.gpufanspeed = new MetroFramework.Controls.MetroLabel();
            this.tempgpu = new MetroFramework.Controls.MetroLabel();
            this.gpuram1 = new MetroFramework.Controls.MetroLabel();
            this.video = new MetroFramework.Controls.MetroLabel();
            this.Hddinfo2 = new System.Diagnostics.PerformanceCounter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.HDD = new MetroFramework.Controls.MetroLabel();
            this.hddlist = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.raznoe = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.usb = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Ports = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Motherboard = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Network = new System.Windows.Forms.TextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.version = new MetroFramework.Controls.MetroLabel();
            this.osnumber = new MetroFramework.Controls.MetroLabel();
            this.osviever = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.time = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tempcpu = new MetroFramework.Controls.MetroLabel();
            this.core = new MetroFramework.Controls.MetroLabel();
            this.cpuclock = new MetroFramework.Controls.MetroLabel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ramproc = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.CpuRPM = new MetroFramework.Controls.MetroLabel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.voltagebox = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.testbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcProcessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryAvailable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hddinfo1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hddinfo2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(342, 79);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(13, 22);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // pcProcessor
            // 
            this.pcProcessor.CategoryName = "Процессор";
            this.pcProcessor.CounterName = "% загруженности процессора";
            this.pcProcessor.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcMemoryAvailable
            // 
            this.pcMemoryAvailable.CategoryName = "Память";
            this.pcMemoryAvailable.CounterName = "Доступно МБ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.temper);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.lblMemoryAvailable);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оперативная память (MB)";
            // 
            // temper
            // 
            this.temper.AutoSize = true;
            this.temper.Location = new System.Drawing.Point(101, 29);
            this.temper.Name = "temper";
            this.temper.Size = new System.Drawing.Size(15, 19);
            this.temper.TabIndex = 16;
            this.temper.Text = "-";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Всего";
            // 
            // lblMemoryAvailable
            // 
            this.lblMemoryAvailable.AutoSize = true;
            this.lblMemoryAvailable.Location = new System.Drawing.Point(101, 12);
            this.lblMemoryAvailable.Name = "lblMemoryAvailable";
            this.lblMemoryAvailable.Size = new System.Drawing.Size(15, 19);
            this.lblMemoryAvailable.TabIndex = 14;
            this.lblMemoryAvailable.Text = "-";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Доступно";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Multipl);
            this.groupBox2.Controls.Add(this.L3Cache);
            this.groupBox2.Controls.Add(this.L2Cache);
            this.groupBox2.Controls.Add(this.L1Cache);
            this.groupBox2.Controls.Add(this.ramspeedl);
            this.groupBox2.Controls.Add(this.Socket);
            this.groupBox2.Controls.Add(this.cpusocket);
            this.groupBox2.Controls.Add(this.lblProcessor);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Процессор";
            // 
            // Multipl
            // 
            this.Multipl.AutoSize = true;
            this.Multipl.Location = new System.Drawing.Point(205, 16);
            this.Multipl.Name = "Multipl";
            this.Multipl.Size = new System.Drawing.Size(17, 19);
            this.Multipl.TabIndex = 26;
            this.Multipl.Text = "X";
            // 
            // L3Cache
            // 
            this.L3Cache.AutoSize = true;
            this.L3Cache.FontSize = MetroFramework.MetroLabelSize.Small;
            this.L3Cache.Location = new System.Drawing.Point(320, 87);
            this.L3Cache.Name = "L3Cache";
            this.L3Cache.Size = new System.Drawing.Size(49, 15);
            this.L3Cache.TabIndex = 25;
            this.L3Cache.Text = "L1 Cache";
            // 
            // L2Cache
            // 
            this.L2Cache.AutoSize = true;
            this.L2Cache.FontSize = MetroFramework.MetroLabelSize.Small;
            this.L2Cache.Location = new System.Drawing.Point(320, 72);
            this.L2Cache.Name = "L2Cache";
            this.L2Cache.Size = new System.Drawing.Size(49, 15);
            this.L2Cache.TabIndex = 24;
            this.L2Cache.Text = "L1 Cache";
            // 
            // L1Cache
            // 
            this.L1Cache.AutoSize = true;
            this.L1Cache.FontSize = MetroFramework.MetroLabelSize.Small;
            this.L1Cache.Location = new System.Drawing.Point(320, 57);
            this.L1Cache.Name = "L1Cache";
            this.L1Cache.Size = new System.Drawing.Size(49, 15);
            this.L1Cache.TabIndex = 23;
            this.L1Cache.Text = "L1 Cache";
            // 
            // ramspeedl
            // 
            this.ramspeedl.AutoSize = true;
            this.ramspeedl.Location = new System.Drawing.Point(6, 73);
            this.ramspeedl.Name = "ramspeedl";
            this.ramspeedl.Size = new System.Drawing.Size(71, 19);
            this.ramspeedl.TabIndex = 22;
            this.ramspeedl.Text = "Ramspeed";
            // 
            // Socket
            // 
            this.Socket.AutoSize = true;
            this.Socket.Location = new System.Drawing.Point(6, 54);
            this.Socket.Name = "Socket";
            this.Socket.Size = new System.Drawing.Size(47, 19);
            this.Socket.TabIndex = 21;
            this.Socket.Text = "Socket";
            // 
            // cpusocket
            // 
            this.cpusocket.AutoSize = true;
            this.cpusocket.Location = new System.Drawing.Point(6, 35);
            this.cpusocket.Name = "cpusocket";
            this.cpusocket.Size = new System.Drawing.Size(35, 19);
            this.cpusocket.TabIndex = 20;
            this.cpusocket.Text = "CPU";
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Location = new System.Drawing.Point(6, 16);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(64, 19);
            this.lblProcessor.TabIndex = 19;
            this.lblProcessor.Text = "CPULoad";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.Menu;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(12, 196);
            this.circularProgressBar1.MarqueeAnimationSpeed = 15;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.SkyBlue;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 25;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.DarkOrange;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(180, 169);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.DimGray;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(5, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 5;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgressBar1.Value = 5;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.InnerColor = System.Drawing.SystemColors.Menu;
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(217, 196);
            this.circularProgressBar2.MarqueeAnimationSpeed = 15;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.SkyBlue;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 25;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.DarkOrange;
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar2.Size = new System.Drawing.Size(180, 169);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.Step = 1;
            this.circularProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 6;
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 5;
            // 
            // Memory
            // 
            this.Memory.CategoryName = "Память";
            this.Memory.CounterName = "% использования выделенной памяти";
            // 
            // Hddinfo1
            // 
            this.Hddinfo1.CategoryName = "Логический диск";
            this.Hddinfo1.CounterName = "% свободного места";
            this.Hddinfo1.InstanceName = "_Total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MonitorSize);
            this.groupBox3.Controls.Add(this.gpufanspeed);
            this.groupBox3.Controls.Add(this.tempgpu);
            this.groupBox3.Controls.Add(this.gpuram1);
            this.groupBox3.Controls.Add(this.video);
            this.groupBox3.Location = new System.Drawing.Point(173, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 54);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPU";
            // 
            // MonitorSize
            // 
            this.MonitorSize.AutoSize = true;
            this.MonitorSize.Location = new System.Drawing.Point(1, 12);
            this.MonitorSize.Name = "MonitorSize";
            this.MonitorSize.Size = new System.Drawing.Size(70, 19);
            this.MonitorSize.TabIndex = 23;
            this.MonitorSize.Text = "Rezolution";
            // 
            // gpufanspeed
            // 
            this.gpufanspeed.AutoSize = true;
            this.gpufanspeed.Location = new System.Drawing.Point(159, 29);
            this.gpufanspeed.Name = "gpufanspeed";
            this.gpufanspeed.Size = new System.Drawing.Size(36, 19);
            this.gpufanspeed.TabIndex = 22;
            this.gpufanspeed.Text = "NaN";
            // 
            // tempgpu
            // 
            this.tempgpu.AutoSize = true;
            this.tempgpu.Location = new System.Drawing.Point(159, 12);
            this.tempgpu.Name = "tempgpu";
            this.tempgpu.Size = new System.Drawing.Size(36, 19);
            this.tempgpu.TabIndex = 21;
            this.tempgpu.Text = "NaN";
            // 
            // gpuram1
            // 
            this.gpuram1.AutoSize = true;
            this.gpuram1.Location = new System.Drawing.Point(1, 29);
            this.gpuram1.Name = "gpuram1";
            this.gpuram1.Size = new System.Drawing.Size(64, 19);
            this.gpuram1.TabIndex = 20;
            this.gpuram1.Text = "GPURAM";
            // 
            // video
            // 
            this.video.Location = new System.Drawing.Point(36, -4);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(182, 19);
            this.video.TabIndex = 19;
            this.video.Text = "GPU";
            // 
            // Hddinfo2
            // 
            this.Hddinfo2.CategoryName = "Физический диск";
            this.Hddinfo2.CounterName = "Скорость обмена с диском (байт/с)";
            this.Hddinfo2.InstanceName = "_Total";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.metroTabControl1);
            this.groupBox4.Controls.Add(this.version);
            this.groupBox4.Controls.Add(this.osnumber);
            this.groupBox4.Controls.Add(this.osviever);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(403, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 361);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Системная информация";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Controls.Add(this.tabPage5);
            this.metroTabControl1.Controls.Add(this.tabPage6);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage7);
            this.metroTabControl1.Location = new System.Drawing.Point(10, 94);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 7;
            this.metroTabControl1.Size = new System.Drawing.Size(298, 246);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 23;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(290, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HDD";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.HDD);
            this.groupBox6.Controls.Add(this.hddlist);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 204);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "HDD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(159, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "HDDSpeed";
            this.label8.UseCustomBackColor = true;
            // 
            // HDD
            // 
            this.HDD.AutoSize = true;
            this.HDD.BackColor = System.Drawing.Color.Transparent;
            this.HDD.Location = new System.Drawing.Point(6, 16);
            this.HDD.Name = "HDD";
            this.HDD.Size = new System.Drawing.Size(35, 19);
            this.HDD.TabIndex = 18;
            this.HDD.Text = "Free";
            this.HDD.UseCustomBackColor = true;
            // 
            // hddlist
            // 
            this.hddlist.BackColor = System.Drawing.Color.White;
            this.hddlist.Location = new System.Drawing.Point(0, 50);
            this.hddlist.Multiline = true;
            this.hddlist.Name = "hddlist";
            this.hddlist.ReadOnly = true;
            this.hddlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hddlist.ShortcutsEnabled = false;
            this.hddlist.Size = new System.Drawing.Size(276, 141);
            this.hddlist.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.raznoe);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(290, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RAM";
            // 
            // raznoe
            // 
            this.raznoe.BackColor = System.Drawing.Color.White;
            this.raznoe.Location = new System.Drawing.Point(7, 7);
            this.raznoe.Multiline = true;
            this.raznoe.Name = "raznoe";
            this.raznoe.ReadOnly = true;
            this.raznoe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.raznoe.ShortcutsEnabled = false;
            this.raznoe.Size = new System.Drawing.Size(276, 187);
            this.raznoe.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(290, 204);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "USB";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.usb);
            this.groupBox5.Location = new System.Drawing.Point(7, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 197);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "USB";
            // 
            // usb
            // 
            this.usb.BackColor = System.Drawing.Color.White;
            this.usb.Location = new System.Drawing.Point(0, 19);
            this.usb.Multiline = true;
            this.usb.Name = "usb";
            this.usb.ReadOnly = true;
            this.usb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usb.ShortcutsEnabled = false;
            this.usb.Size = new System.Drawing.Size(276, 172);
            this.usb.TabIndex = 17;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(290, 204);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Порты";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Ports);
            this.groupBox7.Location = new System.Drawing.Point(7, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(276, 194);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Порты";
            // 
            // Ports
            // 
            this.Ports.BackColor = System.Drawing.Color.White;
            this.Ports.Location = new System.Drawing.Point(0, 19);
            this.Ports.Multiline = true;
            this.Ports.Name = "Ports";
            this.Ports.ReadOnly = true;
            this.Ports.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ports.ShortcutsEnabled = false;
            this.Ports.Size = new System.Drawing.Size(276, 172);
            this.Ports.TabIndex = 17;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox8);
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(290, 204);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Плата";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Motherboard);
            this.groupBox8.Location = new System.Drawing.Point(7, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(276, 194);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Материнская плата";
            // 
            // Motherboard
            // 
            this.Motherboard.BackColor = System.Drawing.Color.White;
            this.Motherboard.Location = new System.Drawing.Point(0, 19);
            this.Motherboard.Multiline = true;
            this.Motherboard.Name = "Motherboard";
            this.Motherboard.ReadOnly = true;
            this.Motherboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Motherboard.ShortcutsEnabled = false;
            this.Motherboard.Size = new System.Drawing.Size(276, 172);
            this.Motherboard.TabIndex = 17;
            // 
            // tabPage6
            // 
            this.tabPage6.CausesValidation = false;
            this.tabPage6.Controls.Add(this.groupBox9);
            this.tabPage6.Location = new System.Drawing.Point(4, 38);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(290, 204);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Сеть";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Network);
            this.groupBox9.Location = new System.Drawing.Point(7, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(276, 194);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Сеть";
            // 
            // Network
            // 
            this.Network.BackColor = System.Drawing.Color.White;
            this.Network.Location = new System.Drawing.Point(0, 19);
            this.Network.Multiline = true;
            this.Network.Name = "Network";
            this.Network.ReadOnly = true;
            this.Network.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Network.ShortcutsEnabled = false;
            this.Network.Size = new System.Drawing.Size(276, 172);
            this.Network.TabIndex = 17;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox10);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(290, 204);
            this.metroTabPage1.TabIndex = 6;
            this.metroTabPage1.Text = "Напряжение";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(10, 72);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(50, 19);
            this.version.TabIndex = 22;
            this.version.Text = "wininfo";
            // 
            // osnumber
            // 
            this.osnumber.AutoSize = true;
            this.osnumber.Location = new System.Drawing.Point(10, 53);
            this.osnumber.Name = "osnumber";
            this.osnumber.Size = new System.Drawing.Size(50, 19);
            this.osnumber.TabIndex = 21;
            this.osnumber.Text = "wininfo";
            // 
            // osviever
            // 
            this.osviever.Location = new System.Drawing.Point(9, 35);
            this.osviever.Name = "osviever";
            this.osviever.Size = new System.Drawing.Size(299, 19);
            this.osviever.TabIndex = 20;
            this.osviever.Text = "wininfo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pcname";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(185, 326);
            this.circularProgressBar3.MarqueeAnimationSpeed = 500;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.DodgerBlue;
            this.circularProgressBar3.OuterMargin = -25;
            this.circularProgressBar3.OuterWidth = 26;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar3.ProgressWidth = 25;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar3.Size = new System.Drawing.Size(40, 40);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.DimGray;
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = "";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar3.SuperscriptText = "";
            this.circularProgressBar3.TabIndex = 17;
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar3.Value = 5;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(18, 5);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(35, 19);
            this.time.TabIndex = 18;
            this.time.Text = "time";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Menu;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(85, 233);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "CPU";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // tempcpu
            // 
            this.tempcpu.AutoSize = true;
            this.tempcpu.BackColor = System.Drawing.SystemColors.Menu;
            this.tempcpu.Location = new System.Drawing.Point(85, 311);
            this.tempcpu.Name = "tempcpu";
            this.tempcpu.Size = new System.Drawing.Size(42, 19);
            this.tempcpu.TabIndex = 20;
            this.tempcpu.Text = "99 *C";
            this.tempcpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempcpu.UseCustomBackColor = true;
            this.tempcpu.UseCustomForeColor = true;
            // 
            // core
            // 
            this.core.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.core.BackColor = System.Drawing.SystemColors.Menu;
            this.core.Location = new System.Drawing.Point(56, 254);
            this.core.Name = "core";
            this.core.Size = new System.Drawing.Size(95, 19);
            this.core.TabIndex = 21;
            this.core.Text = "Core";
            this.core.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.core.UseCustomBackColor = true;
            this.core.UseCustomForeColor = true;
            // 
            // cpuclock
            // 
            this.cpuclock.AutoSize = true;
            this.cpuclock.BackColor = System.Drawing.SystemColors.Menu;
            this.cpuclock.Location = new System.Drawing.Point(68, 273);
            this.cpuclock.Name = "cpuclock";
            this.cpuclock.Size = new System.Drawing.Size(72, 19);
            this.cpuclock.TabIndex = 22;
            this.cpuclock.Text = "Clock MHz";
            this.cpuclock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cpuclock.UseCustomBackColor = true;
            this.cpuclock.UseCustomForeColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(85, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "0 %";
            this.label7.UseCustomBackColor = true;
            this.label7.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Menu;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(293, 233);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "RAM";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // ramproc
            // 
            this.ramproc.BackColor = System.Drawing.SystemColors.Menu;
            this.ramproc.ForeColor = System.Drawing.Color.Black;
            this.ramproc.Location = new System.Drawing.Point(278, 311);
            this.ramproc.Name = "ramproc";
            this.ramproc.Size = new System.Drawing.Size(64, 19);
            this.ramproc.TabIndex = 25;
            this.ramproc.Text = "RAM";
            this.ramproc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ramproc.UseCustomBackColor = true;
            this.ramproc.UseCustomForeColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // CpuRPM
            // 
            this.CpuRPM.AutoSize = true;
            this.CpuRPM.Location = new System.Drawing.Point(12, 368);
            this.CpuRPM.Name = "CpuRPM";
            this.CpuRPM.Size = new System.Drawing.Size(37, 19);
            this.CpuRPM.TabIndex = 27;
            this.CpuRPM.Text = "RPM";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.voltagebox);
            this.groupBox10.Location = new System.Drawing.Point(7, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(276, 197);
            this.groupBox10.TabIndex = 21;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Voltage";
            // 
            // voltagebox
            // 
            this.voltagebox.BackColor = System.Drawing.Color.White;
            this.voltagebox.Location = new System.Drawing.Point(0, 19);
            this.voltagebox.Multiline = true;
            this.voltagebox.Name = "voltagebox";
            this.voltagebox.ReadOnly = true;
            this.voltagebox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.voltagebox.ShortcutsEnabled = false;
            this.voltagebox.Size = new System.Drawing.Size(276, 172);
            this.voltagebox.TabIndex = 17;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox11);
            this.tabPage7.Location = new System.Drawing.Point(4, 38);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(290, 204);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Test";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.testbox);
            this.groupBox11.Location = new System.Drawing.Point(7, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(276, 197);
            this.groupBox11.TabIndex = 22;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Test";
            // 
            // testbox
            // 
            this.testbox.BackColor = System.Drawing.Color.White;
            this.testbox.Location = new System.Drawing.Point(0, 19);
            this.testbox.Multiline = true;
            this.testbox.Name = "testbox";
            this.testbox.ReadOnly = true;
            this.testbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.testbox.ShortcutsEnabled = false;
            this.testbox.Size = new System.Drawing.Size(276, 172);
            this.testbox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(723, 389);
            this.Controls.Add(this.CpuRPM);
            this.Controls.Add(this.ramproc);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cpuclock);
            this.Controls.Add(this.core);
            this.Controls.Add(this.tempcpu);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.circularProgressBar3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.TransparencyKey = System.Drawing.Color.LawnGreen;
            ((System.ComponentModel.ISupportInitialize)(this.pcProcessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryAvailable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hddinfo1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hddinfo2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Diagnostics.PerformanceCounter Memory;
        private System.Diagnostics.PerformanceCounter Hddinfo1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Diagnostics.PerformanceCounter Hddinfo2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel osviever;
        private MetroFramework.Controls.MetroLabel version;
        private MetroFramework.Controls.MetroLabel osnumber;
        private MetroFramework.Controls.MetroLabel cpusocket;
        private MetroFramework.Controls.MetroLabel lblProcessor;
        private MetroFramework.Controls.MetroLabel Socket;
        private MetroFramework.Controls.MetroLabel ramspeedl;
        private MetroFramework.Controls.MetroLabel temper;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblMemoryAvailable;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel tempgpu;
        private MetroFramework.Controls.MetroLabel gpuram1;
        private MetroFramework.Controls.MetroLabel video;
        private MetroFramework.Controls.MetroLabel gpufanspeed;
        private MetroFramework.Controls.MetroLabel MonitorSize;
        private MetroFramework.Controls.MetroLabel time;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel tempcpu;
        private MetroFramework.Controls.MetroLabel core;
        private MetroFramework.Controls.MetroLabel cpuclock;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel ramproc;
        private System.Diagnostics.PerformanceCounter pcProcessor;
        private System.Diagnostics.PerformanceCounter pcMemoryAvailable;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroLabel HDD;
        private System.Windows.Forms.TextBox hddlist;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox raznoe;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox usb;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox Ports;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox Motherboard;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox Network;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MetroFramework.Controls.MetroLabel L2Cache;
        private MetroFramework.Controls.MetroLabel L1Cache;
        private MetroFramework.Controls.MetroLabel L3Cache;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel Multipl;
        private MetroFramework.Controls.MetroLabel CpuRPM;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox voltagebox;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox testbox;
    }
}

