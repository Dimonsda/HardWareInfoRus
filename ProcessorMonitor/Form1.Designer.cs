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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcMemoryAvailable = new System.Diagnostics.PerformanceCounter();
            this.allram = new MetroFramework.Controls.MetroLabel();
            this.totalramlabel = new MetroFramework.Controls.MetroLabel();
            this.lblMemoryAvailable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.Memory = new System.Diagnostics.PerformanceCounter();
            this.Hddinfo1 = new System.Diagnostics.PerformanceCounter();
            this.gpumemory = new MetroFramework.Controls.MetroLabel();
            this.gpushader = new MetroFramework.Controls.MetroLabel();
            this.gpucore = new MetroFramework.Controls.MetroLabel();
            this.MonitorSize = new MetroFramework.Controls.MetroLabel();
            this.gpufanspeed = new MetroFramework.Controls.MetroLabel();
            this.tempgpu = new MetroFramework.Controls.MetroLabel();
            this.gpuramsize = new MetroFramework.Controls.MetroLabel();
            this.gpuname = new MetroFramework.Controls.MetroLabel();
            this.Hddinfo2 = new System.Diagnostics.PerformanceCounter();
            this.HDDspeed = new MetroFramework.Controls.MetroLabel();
            this.HDD = new MetroFramework.Controls.MetroLabel();
            this.version = new MetroFramework.Controls.MetroLabel();
            this.osnumber = new MetroFramework.Controls.MetroLabel();
            this.osname = new MetroFramework.Controls.MetroLabel();
            this.PCname = new MetroFramework.Controls.MetroLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.time = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tempcpu = new MetroFramework.Controls.MetroLabel();
            this.Corecount = new MetroFramework.Controls.MetroLabel();
            this.cpuclock = new MetroFramework.Controls.MetroLabel();
            this.cpuusage = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ramproc = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Multipl = new MetroFramework.Controls.MetroLabel();
            this.loading = new System.Windows.Forms.Button();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.RAMTabPage = new MetroFramework.Controls.MetroTabPage();
            this.CpuRPM = new MetroFramework.Controls.MetroLabel();
            this.L3Cache = new MetroFramework.Controls.MetroLabel();
            this.L2Cache = new MetroFramework.Controls.MetroLabel();
            this.L1Cache = new MetroFramework.Controls.MetroLabel();
            this.Socket = new MetroFramework.Controls.MetroLabel();
            this.cpusocket = new MetroFramework.Controls.MetroLabel();
            this.GPUTabPage = new MetroFramework.Controls.MetroTabPage();
            this.CPUTabPage = new MetroFramework.Controls.MetroTabPage();
            this.totalram = new MetroFramework.Controls.MetroLabel();
            this.rambox = new MetroFramework.Controls.MetroTextBox();
            this.VoltageTabPage = new MetroFramework.Controls.MetroTabPage();
            this.voltagebox = new MetroFramework.Controls.MetroTextBox();
            this.HDDTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.hddlist = new MetroFramework.Controls.MetroTextBox();
            this.USBTabPage = new MetroFramework.Controls.MetroTabPage();
            this.usb = new MetroFramework.Controls.MetroTextBox();
            this.PortsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.Ports = new MetroFramework.Controls.MetroTextBox();
            this.BoardTabPage = new MetroFramework.Controls.MetroTabPage();
            this.Motherboard = new MetroFramework.Controls.MetroLabel();
            this.NetworkTabPage = new MetroFramework.Controls.MetroTabPage();
            this.Network = new MetroFramework.Controls.MetroTextBox();
            this.OSTabPage = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hddinfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hddinfo2)).BeginInit();
            this.metroTabControl2.SuspendLayout();
            this.RAMTabPage.SuspendLayout();
            this.GPUTabPage.SuspendLayout();
            this.CPUTabPage.SuspendLayout();
            this.VoltageTabPage.SuspendLayout();
            this.HDDTabPage1.SuspendLayout();
            this.USBTabPage.SuspendLayout();
            this.PortsTabPage.SuspendLayout();
            this.BoardTabPage.SuspendLayout();
            this.NetworkTabPage.SuspendLayout();
            this.OSTabPage.SuspendLayout();
            this.SuspendLayout();
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
            // allram
            // 
            this.allram.AutoSize = true;
            this.allram.Location = new System.Drawing.Point(95, 282);
            this.allram.Name = "allram";
            this.allram.Size = new System.Drawing.Size(15, 19);
            this.allram.TabIndex = 16;
            this.allram.Text = "-";
            // 
            // totalramlabel
            // 
            this.totalramlabel.AutoSize = true;
            this.totalramlabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalramlabel.Location = new System.Drawing.Point(3, 282);
            this.totalramlabel.Name = "totalramlabel";
            this.totalramlabel.Size = new System.Drawing.Size(43, 19);
            this.totalramlabel.TabIndex = 15;
            this.totalramlabel.Text = "Всего";
            // 
            // lblMemoryAvailable
            // 
            this.lblMemoryAvailable.AutoSize = true;
            this.lblMemoryAvailable.Location = new System.Drawing.Point(95, 265);
            this.lblMemoryAvailable.Name = "lblMemoryAvailable";
            this.lblMemoryAvailable.Size = new System.Drawing.Size(15, 19);
            this.lblMemoryAvailable.TabIndex = 14;
            this.lblMemoryAvailable.Text = "-";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 263);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Доступно";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(501, 29);
            this.circularProgressBar1.MarqueeAnimationSpeed = 15;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.SkyBlue;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 25;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.DarkOrange;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(180, 180);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.White;
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
            this.circularProgressBar2.Location = new System.Drawing.Point(523, 28);
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
            // gpumemory
            // 
            this.gpumemory.AutoSize = true;
            this.gpumemory.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gpumemory.Location = new System.Drawing.Point(3, 156);
            this.gpumemory.Name = "gpumemory";
            this.gpumemory.Size = new System.Drawing.Size(84, 19);
            this.gpumemory.TabIndex = 26;
            this.gpumemory.Text = "gpumemory";
            // 
            // gpushader
            // 
            this.gpushader.AutoSize = true;
            this.gpushader.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gpushader.Location = new System.Drawing.Point(3, 175);
            this.gpushader.Name = "gpushader";
            this.gpushader.Size = new System.Drawing.Size(74, 19);
            this.gpushader.TabIndex = 25;
            this.gpushader.Text = "gpushader";
            // 
            // gpucore
            // 
            this.gpucore.AutoSize = true;
            this.gpucore.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gpucore.Location = new System.Drawing.Point(3, 137);
            this.gpucore.Name = "gpucore";
            this.gpucore.Size = new System.Drawing.Size(59, 19);
            this.gpucore.TabIndex = 24;
            this.gpucore.Text = "gpucore";
            // 
            // MonitorSize
            // 
            this.MonitorSize.AutoSize = true;
            this.MonitorSize.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MonitorSize.Location = new System.Drawing.Point(3, 30);
            this.MonitorSize.Name = "MonitorSize";
            this.MonitorSize.Size = new System.Drawing.Size(73, 19);
            this.MonitorSize.TabIndex = 23;
            this.MonitorSize.Text = "Rezolution";
            // 
            // gpufanspeed
            // 
            this.gpufanspeed.AutoSize = true;
            this.gpufanspeed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gpufanspeed.Location = new System.Drawing.Point(122, 293);
            this.gpufanspeed.Name = "gpufanspeed";
            this.gpufanspeed.Size = new System.Drawing.Size(36, 19);
            this.gpufanspeed.TabIndex = 22;
            this.gpufanspeed.Text = "NaN";
            // 
            // tempgpu
            // 
            this.tempgpu.AutoSize = true;
            this.tempgpu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tempgpu.Location = new System.Drawing.Point(208, 293);
            this.tempgpu.Name = "tempgpu";
            this.tempgpu.Size = new System.Drawing.Size(36, 19);
            this.tempgpu.TabIndex = 21;
            this.tempgpu.Text = "NaN";
            // 
            // gpuramsize
            // 
            this.gpuramsize.AutoSize = true;
            this.gpuramsize.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gpuramsize.Location = new System.Drawing.Point(3, 293);
            this.gpuramsize.Name = "gpuramsize";
            this.gpuramsize.Size = new System.Drawing.Size(67, 19);
            this.gpuramsize.TabIndex = 20;
            this.gpuramsize.Text = "GPURAM";
            // 
            // gpuname
            // 
            this.gpuname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.gpuname.Location = new System.Drawing.Point(3, 11);
            this.gpuname.Name = "gpuname";
            this.gpuname.Size = new System.Drawing.Size(601, 19);
            this.gpuname.TabIndex = 19;
            this.gpuname.Text = "GPU";
            // 
            // Hddinfo2
            // 
            this.Hddinfo2.CategoryName = "Физический диск";
            this.Hddinfo2.CounterName = "Скорость обмена с диском (байт/с)";
            this.Hddinfo2.InstanceName = "_Total";
            // 
            // HDDspeed
            // 
            this.HDDspeed.AutoSize = true;
            this.HDDspeed.BackColor = System.Drawing.Color.Transparent;
            this.HDDspeed.Location = new System.Drawing.Point(186, 9);
            this.HDDspeed.Name = "HDDspeed";
            this.HDDspeed.Size = new System.Drawing.Size(73, 19);
            this.HDDspeed.TabIndex = 19;
            this.HDDspeed.Text = "HDDSpeed";
            this.HDDspeed.UseCustomBackColor = true;
            // 
            // HDD
            // 
            this.HDD.AutoSize = true;
            this.HDD.BackColor = System.Drawing.Color.Transparent;
            this.HDD.Location = new System.Drawing.Point(13, 9);
            this.HDD.Name = "HDD";
            this.HDD.Size = new System.Drawing.Size(35, 19);
            this.HDD.TabIndex = 18;
            this.HDD.Text = "Free";
            this.HDD.UseCustomBackColor = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.version.Location = new System.Drawing.Point(4, 67);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(53, 19);
            this.version.TabIndex = 22;
            this.version.Text = "wininfo";
            // 
            // osnumber
            // 
            this.osnumber.AutoSize = true;
            this.osnumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.osnumber.Location = new System.Drawing.Point(4, 48);
            this.osnumber.Name = "osnumber";
            this.osnumber.Size = new System.Drawing.Size(53, 19);
            this.osnumber.TabIndex = 21;
            this.osnumber.Text = "wininfo";
            // 
            // osname
            // 
            this.osname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.osname.Location = new System.Drawing.Point(3, 30);
            this.osname.Name = "osname";
            this.osname.Size = new System.Drawing.Size(299, 19);
            this.osname.TabIndex = 20;
            this.osname.Text = "wininfo";
            // 
            // PCname
            // 
            this.PCname.AutoSize = true;
            this.PCname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PCname.ForeColor = System.Drawing.Color.Black;
            this.PCname.Location = new System.Drawing.Point(3, 11);
            this.PCname.Name = "PCname";
            this.PCname.Size = new System.Drawing.Size(56, 19);
            this.PCname.TabIndex = 19;
            this.PCname.Text = "Pcname";
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
            this.circularProgressBar3.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(569, 240);
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
            this.time.Location = new System.Drawing.Point(6, 8);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(35, 19);
            this.time.TabIndex = 18;
            this.time.Text = "time";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(574, 66);
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
            this.tempcpu.BackColor = System.Drawing.Color.White;
            this.tempcpu.Location = new System.Drawing.Point(569, 286);
            this.tempcpu.Name = "tempcpu";
            this.tempcpu.Size = new System.Drawing.Size(42, 19);
            this.tempcpu.TabIndex = 20;
            this.tempcpu.Text = "99 *C";
            this.tempcpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempcpu.UseCustomBackColor = true;
            this.tempcpu.UseCustomForeColor = true;
            // 
            // Corecount
            // 
            this.Corecount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Corecount.BackColor = System.Drawing.SystemColors.Menu;
            this.Corecount.Location = new System.Drawing.Point(669, -21);
            this.Corecount.Name = "Corecount";
            this.Corecount.Size = new System.Drawing.Size(95, 19);
            this.Corecount.TabIndex = 21;
            this.Corecount.Text = "Core";
            this.Corecount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Corecount.UseCustomBackColor = true;
            this.Corecount.UseCustomForeColor = true;
            // 
            // cpuclock
            // 
            this.cpuclock.AutoSize = true;
            this.cpuclock.BackColor = System.Drawing.Color.White;
            this.cpuclock.Location = new System.Drawing.Point(557, 126);
            this.cpuclock.Name = "cpuclock";
            this.cpuclock.Size = new System.Drawing.Size(72, 19);
            this.cpuclock.TabIndex = 22;
            this.cpuclock.Text = "Clock MHz";
            this.cpuclock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cpuclock.UseCustomBackColor = true;
            this.cpuclock.UseCustomForeColor = true;
            // 
            // cpuusage
            // 
            this.cpuusage.AutoSize = true;
            this.cpuusage.BackColor = System.Drawing.Color.White;
            this.cpuusage.Location = new System.Drawing.Point(574, 145);
            this.cpuusage.Name = "cpuusage";
            this.cpuusage.Size = new System.Drawing.Size(31, 19);
            this.cpuusage.TabIndex = 23;
            this.cpuusage.Text = "0 %";
            this.cpuusage.UseCustomBackColor = true;
            this.cpuusage.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Menu;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(595, 101);
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
            this.ramproc.Location = new System.Drawing.Point(584, 143);
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
            // Multipl
            // 
            this.Multipl.BackColor = System.Drawing.Color.White;
            this.Multipl.Location = new System.Drawing.Point(541, 104);
            this.Multipl.Name = "Multipl";
            this.Multipl.Size = new System.Drawing.Size(106, 19);
            this.Multipl.TabIndex = 26;
            this.Multipl.Text = "Multipl";
            this.Multipl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Multipl.UseCustomBackColor = true;
            this.Multipl.UseCustomForeColor = true;
            // 
            // loading
            // 
            this.loading.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loading.ForeColor = System.Drawing.Color.DarkGreen;
            this.loading.Location = new System.Drawing.Point(-4, 8);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(128, 19);
            this.loading.TabIndex = 27;
            this.loading.Text = "Loading";
            this.loading.UseVisualStyleBackColor = true;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl2.Controls.Add(this.RAMTabPage);
            this.metroTabControl2.Controls.Add(this.GPUTabPage);
            this.metroTabControl2.Controls.Add(this.CPUTabPage);
            this.metroTabControl2.Controls.Add(this.VoltageTabPage);
            this.metroTabControl2.Controls.Add(this.HDDTabPage1);
            this.metroTabControl2.Controls.Add(this.USBTabPage);
            this.metroTabControl2.Controls.Add(this.PortsTabPage);
            this.metroTabControl2.Controls.Add(this.BoardTabPage);
            this.metroTabControl2.Controls.Add(this.NetworkTabPage);
            this.metroTabControl2.Controls.Add(this.OSTabPage);
            this.metroTabControl2.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metroTabControl2.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl2.Location = new System.Drawing.Point(6, 30);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 2;
            this.metroTabControl2.Size = new System.Drawing.Size(730, 350);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl2.TabIndex = 29;
            this.metroTabControl2.UseSelectable = true;
            // 
            // RAMTabPage
            // 
            this.RAMTabPage.Controls.Add(this.CpuRPM);
            this.RAMTabPage.Controls.Add(this.Multipl);
            this.RAMTabPage.Controls.Add(this.L3Cache);
            this.RAMTabPage.Controls.Add(this.L2Cache);
            this.RAMTabPage.Controls.Add(this.cpuusage);
            this.RAMTabPage.Controls.Add(this.L1Cache);
            this.RAMTabPage.Controls.Add(this.cpuclock);
            this.RAMTabPage.Controls.Add(this.Socket);
            this.RAMTabPage.Controls.Add(this.tempcpu);
            this.RAMTabPage.Controls.Add(this.cpusocket);
            this.RAMTabPage.Controls.Add(this.metroLabel3);
            this.RAMTabPage.Controls.Add(this.circularProgressBar3);
            this.RAMTabPage.Controls.Add(this.circularProgressBar1);
            this.RAMTabPage.HorizontalScrollbarBarColor = true;
            this.RAMTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.RAMTabPage.HorizontalScrollbarSize = 10;
            this.RAMTabPage.Location = new System.Drawing.Point(4, 37);
            this.RAMTabPage.Name = "RAMTabPage";
            this.RAMTabPage.Size = new System.Drawing.Size(722, 309);
            this.RAMTabPage.TabIndex = 0;
            this.RAMTabPage.Text = "CPU";
            this.RAMTabPage.VerticalScrollbarBarColor = true;
            this.RAMTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.RAMTabPage.VerticalScrollbarSize = 10;
            // 
            // CpuRPM
            // 
            this.CpuRPM.AutoSize = true;
            this.CpuRPM.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CpuRPM.Location = new System.Drawing.Point(13, 286);
            this.CpuRPM.Name = "CpuRPM";
            this.CpuRPM.Size = new System.Drawing.Size(38, 19);
            this.CpuRPM.TabIndex = 27;
            this.CpuRPM.Text = "RPM";
            // 
            // L3Cache
            // 
            this.L3Cache.AutoSize = true;
            this.L3Cache.FontSize = MetroFramework.MetroLabelSize.Small;
            this.L3Cache.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.L3Cache.Location = new System.Drawing.Point(13, 183);
            this.L3Cache.Name = "L3Cache";
            this.L3Cache.Size = new System.Drawing.Size(55, 15);
            this.L3Cache.TabIndex = 25;
            this.L3Cache.Text = "L3 Cache";
            // 
            // L2Cache
            // 
            this.L2Cache.AutoSize = true;
            this.L2Cache.FontSize = MetroFramework.MetroLabelSize.Small;
            this.L2Cache.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.L2Cache.Location = new System.Drawing.Point(13, 168);
            this.L2Cache.Name = "L2Cache";
            this.L2Cache.Size = new System.Drawing.Size(55, 15);
            this.L2Cache.TabIndex = 24;
            this.L2Cache.Text = "L2 Cache";
            // 
            // L1Cache
            // 
            this.L1Cache.AutoSize = true;
            this.L1Cache.FontSize = MetroFramework.MetroLabelSize.Small;
            this.L1Cache.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.L1Cache.Location = new System.Drawing.Point(13, 153);
            this.L1Cache.Name = "L1Cache";
            this.L1Cache.Size = new System.Drawing.Size(55, 15);
            this.L1Cache.TabIndex = 23;
            this.L1Cache.Text = "L1 Cache";
            // 
            // Socket
            // 
            this.Socket.AutoSize = true;
            this.Socket.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Socket.Location = new System.Drawing.Point(13, 40);
            this.Socket.Name = "Socket";
            this.Socket.Size = new System.Drawing.Size(49, 19);
            this.Socket.TabIndex = 21;
            this.Socket.Text = "Socket";
            // 
            // cpusocket
            // 
            this.cpusocket.AutoSize = true;
            this.cpusocket.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.cpusocket.Location = new System.Drawing.Point(13, 11);
            this.cpusocket.Name = "cpusocket";
            this.cpusocket.Size = new System.Drawing.Size(36, 19);
            this.cpusocket.TabIndex = 20;
            this.cpusocket.Text = "CPU";
            // 
            // GPUTabPage
            // 
            this.GPUTabPage.Controls.Add(this.gpumemory);
            this.GPUTabPage.Controls.Add(this.gpushader);
            this.GPUTabPage.Controls.Add(this.gpucore);
            this.GPUTabPage.Controls.Add(this.gpuramsize);
            this.GPUTabPage.Controls.Add(this.MonitorSize);
            this.GPUTabPage.Controls.Add(this.gpuname);
            this.GPUTabPage.Controls.Add(this.gpufanspeed);
            this.GPUTabPage.Controls.Add(this.tempgpu);
            this.GPUTabPage.HorizontalScrollbarBarColor = true;
            this.GPUTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.GPUTabPage.HorizontalScrollbarSize = 10;
            this.GPUTabPage.Location = new System.Drawing.Point(4, 37);
            this.GPUTabPage.Name = "GPUTabPage";
            this.GPUTabPage.Size = new System.Drawing.Size(722, 309);
            this.GPUTabPage.TabIndex = 1;
            this.GPUTabPage.Text = "GPU";
            this.GPUTabPage.VerticalScrollbarBarColor = true;
            this.GPUTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.GPUTabPage.VerticalScrollbarSize = 10;
            // 
            // CPUTabPage
            // 
            this.CPUTabPage.Controls.Add(this.totalram);
            this.CPUTabPage.Controls.Add(this.rambox);
            this.CPUTabPage.Controls.Add(this.ramproc);
            this.CPUTabPage.Controls.Add(this.metroLabel4);
            this.CPUTabPage.Controls.Add(this.allram);
            this.CPUTabPage.Controls.Add(this.totalramlabel);
            this.CPUTabPage.Controls.Add(this.circularProgressBar2);
            this.CPUTabPage.Controls.Add(this.lblMemoryAvailable);
            this.CPUTabPage.Controls.Add(this.metroLabel1);
            this.CPUTabPage.HorizontalScrollbarBarColor = true;
            this.CPUTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.CPUTabPage.HorizontalScrollbarSize = 10;
            this.CPUTabPage.Location = new System.Drawing.Point(4, 37);
            this.CPUTabPage.Name = "CPUTabPage";
            this.CPUTabPage.Size = new System.Drawing.Size(722, 309);
            this.CPUTabPage.TabIndex = 2;
            this.CPUTabPage.Text = "RAM";
            this.CPUTabPage.VerticalScrollbarBarColor = true;
            this.CPUTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.CPUTabPage.VerticalScrollbarSize = 10;
            // 
            // totalram
            // 
            this.totalram.AutoSize = true;
            this.totalram.Location = new System.Drawing.Point(192, 263);
            this.totalram.Name = "totalram";
            this.totalram.Size = new System.Drawing.Size(63, 19);
            this.totalram.TabIndex = 27;
            this.totalram.Text = "TotalRam";
            // 
            // rambox
            // 
            // 
            // 
            // 
            this.rambox.CustomButton.Image = null;
            this.rambox.CustomButton.Location = new System.Drawing.Point(266, 2);
            this.rambox.CustomButton.Name = "";
            this.rambox.CustomButton.Size = new System.Drawing.Size(229, 229);
            this.rambox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rambox.CustomButton.TabIndex = 1;
            this.rambox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rambox.CustomButton.UseSelectable = true;
            this.rambox.CustomButton.Visible = false;
            this.rambox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.rambox.Lines = new string[0];
            this.rambox.Location = new System.Drawing.Point(3, 28);
            this.rambox.MaxLength = 32767;
            this.rambox.Multiline = true;
            this.rambox.Name = "rambox";
            this.rambox.PasswordChar = '\0';
            this.rambox.ReadOnly = true;
            this.rambox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rambox.SelectedText = "";
            this.rambox.SelectionLength = 0;
            this.rambox.SelectionStart = 0;
            this.rambox.ShortcutsEnabled = true;
            this.rambox.Size = new System.Drawing.Size(498, 234);
            this.rambox.Style = MetroFramework.MetroColorStyle.Black;
            this.rambox.TabIndex = 26;
            this.rambox.UseSelectable = true;
            this.rambox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rambox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // VoltageTabPage
            // 
            this.VoltageTabPage.Controls.Add(this.voltagebox);
            this.VoltageTabPage.HorizontalScrollbarBarColor = true;
            this.VoltageTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.VoltageTabPage.HorizontalScrollbarSize = 10;
            this.VoltageTabPage.Location = new System.Drawing.Point(4, 37);
            this.VoltageTabPage.Name = "VoltageTabPage";
            this.VoltageTabPage.Size = new System.Drawing.Size(722, 309);
            this.VoltageTabPage.TabIndex = 3;
            this.VoltageTabPage.Text = "Voltage";
            this.VoltageTabPage.VerticalScrollbarBarColor = true;
            this.VoltageTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.VoltageTabPage.VerticalScrollbarSize = 10;
            // 
            // voltagebox
            // 
            // 
            // 
            // 
            this.voltagebox.CustomButton.Image = null;
            this.voltagebox.CustomButton.Location = new System.Drawing.Point(408, 2);
            this.voltagebox.CustomButton.Name = "";
            this.voltagebox.CustomButton.Size = new System.Drawing.Size(291, 291);
            this.voltagebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.voltagebox.CustomButton.TabIndex = 1;
            this.voltagebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.voltagebox.CustomButton.UseSelectable = true;
            this.voltagebox.CustomButton.Visible = false;
            this.voltagebox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.voltagebox.Lines = new string[0];
            this.voltagebox.Location = new System.Drawing.Point(3, 16);
            this.voltagebox.MaxLength = 32767;
            this.voltagebox.Multiline = true;
            this.voltagebox.Name = "voltagebox";
            this.voltagebox.PasswordChar = '\0';
            this.voltagebox.ReadOnly = true;
            this.voltagebox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.voltagebox.SelectedText = "";
            this.voltagebox.SelectionLength = 0;
            this.voltagebox.SelectionStart = 0;
            this.voltagebox.ShortcutsEnabled = true;
            this.voltagebox.Size = new System.Drawing.Size(702, 296);
            this.voltagebox.Style = MetroFramework.MetroColorStyle.Black;
            this.voltagebox.TabIndex = 27;
            this.voltagebox.UseSelectable = true;
            this.voltagebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.voltagebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // HDDTabPage1
            // 
            this.HDDTabPage1.Controls.Add(this.hddlist);
            this.HDDTabPage1.Controls.Add(this.HDDspeed);
            this.HDDTabPage1.Controls.Add(this.HDD);
            this.HDDTabPage1.HorizontalScrollbarBarColor = true;
            this.HDDTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.HDDTabPage1.HorizontalScrollbarSize = 10;
            this.HDDTabPage1.Location = new System.Drawing.Point(4, 37);
            this.HDDTabPage1.Name = "HDDTabPage1";
            this.HDDTabPage1.Size = new System.Drawing.Size(722, 309);
            this.HDDTabPage1.TabIndex = 5;
            this.HDDTabPage1.Text = "HDD";
            this.HDDTabPage1.VerticalScrollbarBarColor = true;
            this.HDDTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.HDDTabPage1.VerticalScrollbarSize = 10;
            // 
            // hddlist
            // 
            // 
            // 
            // 
            this.hddlist.CustomButton.Image = null;
            this.hddlist.CustomButton.Location = new System.Drawing.Point(432, 2);
            this.hddlist.CustomButton.Name = "";
            this.hddlist.CustomButton.Size = new System.Drawing.Size(267, 267);
            this.hddlist.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hddlist.CustomButton.TabIndex = 1;
            this.hddlist.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hddlist.CustomButton.UseSelectable = true;
            this.hddlist.CustomButton.Visible = false;
            this.hddlist.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.hddlist.Lines = new string[0];
            this.hddlist.Location = new System.Drawing.Point(3, 44);
            this.hddlist.MaxLength = 32767;
            this.hddlist.Multiline = true;
            this.hddlist.Name = "hddlist";
            this.hddlist.PasswordChar = '\0';
            this.hddlist.ReadOnly = true;
            this.hddlist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hddlist.SelectedText = "";
            this.hddlist.SelectionLength = 0;
            this.hddlist.SelectionStart = 0;
            this.hddlist.ShortcutsEnabled = true;
            this.hddlist.Size = new System.Drawing.Size(702, 272);
            this.hddlist.Style = MetroFramework.MetroColorStyle.Black;
            this.hddlist.TabIndex = 27;
            this.hddlist.UseSelectable = true;
            this.hddlist.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hddlist.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // USBTabPage
            // 
            this.USBTabPage.Controls.Add(this.usb);
            this.USBTabPage.HorizontalScrollbarBarColor = true;
            this.USBTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.USBTabPage.HorizontalScrollbarSize = 10;
            this.USBTabPage.Location = new System.Drawing.Point(4, 37);
            this.USBTabPage.Name = "USBTabPage";
            this.USBTabPage.Size = new System.Drawing.Size(722, 309);
            this.USBTabPage.TabIndex = 6;
            this.USBTabPage.Text = "USB";
            this.USBTabPage.VerticalScrollbarBarColor = true;
            this.USBTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.USBTabPage.VerticalScrollbarSize = 10;
            // 
            // usb
            // 
            // 
            // 
            // 
            this.usb.CustomButton.Image = null;
            this.usb.CustomButton.Location = new System.Drawing.Point(422, 1);
            this.usb.CustomButton.Name = "";
            this.usb.CustomButton.Size = new System.Drawing.Size(293, 293);
            this.usb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usb.CustomButton.TabIndex = 1;
            this.usb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usb.CustomButton.UseSelectable = true;
            this.usb.CustomButton.Visible = false;
            this.usb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.usb.Lines = new string[0];
            this.usb.Location = new System.Drawing.Point(3, 21);
            this.usb.MaxLength = 32767;
            this.usb.Multiline = true;
            this.usb.Name = "usb";
            this.usb.PasswordChar = '\0';
            this.usb.ReadOnly = true;
            this.usb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usb.SelectedText = "";
            this.usb.SelectionLength = 0;
            this.usb.SelectionStart = 0;
            this.usb.ShortcutsEnabled = true;
            this.usb.Size = new System.Drawing.Size(716, 295);
            this.usb.Style = MetroFramework.MetroColorStyle.Black;
            this.usb.TabIndex = 27;
            this.usb.UseSelectable = true;
            this.usb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PortsTabPage
            // 
            this.PortsTabPage.Controls.Add(this.Ports);
            this.PortsTabPage.HorizontalScrollbarBarColor = true;
            this.PortsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.PortsTabPage.HorizontalScrollbarSize = 10;
            this.PortsTabPage.Location = new System.Drawing.Point(4, 37);
            this.PortsTabPage.Name = "PortsTabPage";
            this.PortsTabPage.Size = new System.Drawing.Size(722, 309);
            this.PortsTabPage.TabIndex = 7;
            this.PortsTabPage.Text = "Ports";
            this.PortsTabPage.VerticalScrollbarBarColor = true;
            this.PortsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.PortsTabPage.VerticalScrollbarSize = 10;
            // 
            // Ports
            // 
            // 
            // 
            // 
            this.Ports.CustomButton.Image = null;
            this.Ports.CustomButton.Location = new System.Drawing.Point(429, 2);
            this.Ports.CustomButton.Name = "";
            this.Ports.CustomButton.Size = new System.Drawing.Size(287, 287);
            this.Ports.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Ports.CustomButton.TabIndex = 1;
            this.Ports.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Ports.CustomButton.UseSelectable = true;
            this.Ports.CustomButton.Visible = false;
            this.Ports.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Ports.Lines = new string[0];
            this.Ports.Location = new System.Drawing.Point(0, 24);
            this.Ports.MaxLength = 32767;
            this.Ports.Multiline = true;
            this.Ports.Name = "Ports";
            this.Ports.PasswordChar = '\0';
            this.Ports.ReadOnly = true;
            this.Ports.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ports.SelectedText = "";
            this.Ports.SelectionLength = 0;
            this.Ports.SelectionStart = 0;
            this.Ports.ShortcutsEnabled = true;
            this.Ports.Size = new System.Drawing.Size(719, 292);
            this.Ports.Style = MetroFramework.MetroColorStyle.Black;
            this.Ports.TabIndex = 27;
            this.Ports.UseSelectable = true;
            this.Ports.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Ports.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BoardTabPage
            // 
            this.BoardTabPage.Controls.Add(this.Motherboard);
            this.BoardTabPage.HorizontalScrollbarBarColor = true;
            this.BoardTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.BoardTabPage.HorizontalScrollbarSize = 10;
            this.BoardTabPage.Location = new System.Drawing.Point(4, 37);
            this.BoardTabPage.Name = "BoardTabPage";
            this.BoardTabPage.Size = new System.Drawing.Size(722, 309);
            this.BoardTabPage.TabIndex = 8;
            this.BoardTabPage.Text = "Board";
            this.BoardTabPage.VerticalScrollbarBarColor = true;
            this.BoardTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.BoardTabPage.VerticalScrollbarSize = 10;
            // 
            // Motherboard
            // 
            this.Motherboard.AutoSize = true;
            this.Motherboard.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Motherboard.Location = new System.Drawing.Point(11, 22);
            this.Motherboard.Name = "Motherboard";
            this.Motherboard.Size = new System.Drawing.Size(45, 19);
            this.Motherboard.TabIndex = 23;
            this.Motherboard.Text = "Board";
            // 
            // NetworkTabPage
            // 
            this.NetworkTabPage.Controls.Add(this.Network);
            this.NetworkTabPage.HorizontalScrollbarBarColor = true;
            this.NetworkTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.NetworkTabPage.HorizontalScrollbarSize = 10;
            this.NetworkTabPage.Location = new System.Drawing.Point(4, 37);
            this.NetworkTabPage.Name = "NetworkTabPage";
            this.NetworkTabPage.Size = new System.Drawing.Size(722, 309);
            this.NetworkTabPage.TabIndex = 9;
            this.NetworkTabPage.Text = "Network";
            this.NetworkTabPage.VerticalScrollbarBarColor = true;
            this.NetworkTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.NetworkTabPage.VerticalScrollbarSize = 10;
            // 
            // Network
            // 
            // 
            // 
            // 
            this.Network.CustomButton.Image = null;
            this.Network.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.Network.CustomButton.Name = "";
            this.Network.CustomButton.Size = new System.Drawing.Size(299, 299);
            this.Network.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Network.CustomButton.TabIndex = 1;
            this.Network.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Network.CustomButton.UseSelectable = true;
            this.Network.CustomButton.Visible = false;
            this.Network.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Network.Lines = new string[0];
            this.Network.Location = new System.Drawing.Point(0, 15);
            this.Network.MaxLength = 32767;
            this.Network.Multiline = true;
            this.Network.Name = "Network";
            this.Network.PasswordChar = '\0';
            this.Network.ReadOnly = true;
            this.Network.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Network.SelectedText = "";
            this.Network.SelectionLength = 0;
            this.Network.SelectionStart = 0;
            this.Network.ShortcutsEnabled = false;
            this.Network.Size = new System.Drawing.Size(719, 301);
            this.Network.Style = MetroFramework.MetroColorStyle.Black;
            this.Network.TabIndex = 27;
            this.Network.UseSelectable = true;
            this.Network.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Network.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OSTabPage
            // 
            this.OSTabPage.Controls.Add(this.version);
            this.OSTabPage.Controls.Add(this.osnumber);
            this.OSTabPage.Controls.Add(this.osname);
            this.OSTabPage.Controls.Add(this.PCname);
            this.OSTabPage.HorizontalScrollbarBarColor = true;
            this.OSTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.OSTabPage.HorizontalScrollbarSize = 10;
            this.OSTabPage.Location = new System.Drawing.Point(4, 37);
            this.OSTabPage.Name = "OSTabPage";
            this.OSTabPage.Size = new System.Drawing.Size(722, 309);
            this.OSTabPage.TabIndex = 10;
            this.OSTabPage.Text = "OS";
            this.OSTabPage.VerticalScrollbarBarColor = true;
            this.OSTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.OSTabPage.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(738, 396);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.Corecount);
            this.Controls.Add(this.time);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.TransparencyKey = System.Drawing.Color.LawnGreen;
            ((System.ComponentModel.ISupportInitialize)(this.pcMemoryAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hddinfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hddinfo2)).EndInit();
            this.metroTabControl2.ResumeLayout(false);
            this.RAMTabPage.ResumeLayout(false);
            this.RAMTabPage.PerformLayout();
            this.GPUTabPage.ResumeLayout(false);
            this.GPUTabPage.PerformLayout();
            this.CPUTabPage.ResumeLayout(false);
            this.CPUTabPage.PerformLayout();
            this.VoltageTabPage.ResumeLayout(false);
            this.HDDTabPage1.ResumeLayout(false);
            this.HDDTabPage1.PerformLayout();
            this.USBTabPage.ResumeLayout(false);
            this.PortsTabPage.ResumeLayout(false);
            this.BoardTabPage.ResumeLayout(false);
            this.BoardTabPage.PerformLayout();
            this.NetworkTabPage.ResumeLayout(false);
            this.OSTabPage.ResumeLayout(false);
            this.OSTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Diagnostics.PerformanceCounter Memory;
        private System.Diagnostics.PerformanceCounter Hddinfo1;
        private System.Diagnostics.PerformanceCounter Hddinfo2;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel PCname;
        private MetroFramework.Controls.MetroLabel osname;
        private MetroFramework.Controls.MetroLabel version;
        private MetroFramework.Controls.MetroLabel osnumber;
        private MetroFramework.Controls.MetroLabel allram;
        private MetroFramework.Controls.MetroLabel totalramlabel;
        private MetroFramework.Controls.MetroLabel lblMemoryAvailable;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel tempgpu;
        private MetroFramework.Controls.MetroLabel gpuramsize;
        private MetroFramework.Controls.MetroLabel gpuname;
        private MetroFramework.Controls.MetroLabel gpufanspeed;
        private MetroFramework.Controls.MetroLabel MonitorSize;
        private MetroFramework.Controls.MetroLabel time;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel tempcpu;
        private MetroFramework.Controls.MetroLabel Corecount;
        private MetroFramework.Controls.MetroLabel cpuclock;
        private MetroFramework.Controls.MetroLabel cpuusage;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel ramproc;
        private System.Diagnostics.PerformanceCounter pcMemoryAvailable;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private MetroFramework.Controls.MetroLabel HDDspeed;
        private MetroFramework.Controls.MetroLabel HDD;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MetroFramework.Controls.MetroLabel Multipl;
        private MetroFramework.Controls.MetroLabel gpucore;
        private MetroFramework.Controls.MetroLabel gpushader;
        private System.Windows.Forms.Button loading;
        private MetroFramework.Controls.MetroLabel gpumemory;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage RAMTabPage;
        private MetroFramework.Controls.MetroTabPage GPUTabPage;
        private MetroFramework.Controls.MetroTabPage CPUTabPage;
        private MetroFramework.Controls.MetroLabel cpusocket;
        private MetroFramework.Controls.MetroLabel Socket;
        private MetroFramework.Controls.MetroLabel L1Cache;
        private MetroFramework.Controls.MetroLabel L2Cache;
        private MetroFramework.Controls.MetroLabel L3Cache;
        private MetroFramework.Controls.MetroLabel CpuRPM;
        private MetroFramework.Controls.MetroTabPage VoltageTabPage;
        private MetroFramework.Controls.MetroTabPage HDDTabPage1;
        private MetroFramework.Controls.MetroTabPage USBTabPage;
        private MetroFramework.Controls.MetroTabPage PortsTabPage;
        private MetroFramework.Controls.MetroTabPage BoardTabPage;
        private MetroFramework.Controls.MetroTabPage NetworkTabPage;
        private MetroFramework.Controls.MetroTabPage OSTabPage;
        private MetroFramework.Controls.MetroLabel Motherboard;
        private MetroFramework.Controls.MetroTextBox rambox;
        private MetroFramework.Controls.MetroTextBox voltagebox;
        private MetroFramework.Controls.MetroTextBox hddlist;
        private MetroFramework.Controls.MetroTextBox usb;
        private MetroFramework.Controls.MetroTextBox Ports;
        private MetroFramework.Controls.MetroTextBox Network;
        private MetroFramework.Controls.MetroLabel totalram;
    }
}

