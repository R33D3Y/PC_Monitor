namespace PC_Monitor
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxCPU = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.circularProgressBarCPUTemp = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarCPULoad = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarCPURPM = new CircularProgressBar.CircularProgressBar();
            this.groupBoxGPU = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circularProgressBarGPURPM = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarGPULoad = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarGPUTemp = new CircularProgressBar.CircularProgressBar();
            this.groupBoxHDD = new System.Windows.Forms.GroupBox();
            this.groupBoxDisk2 = new System.Windows.Forms.GroupBox();
            this.progressBarDisk2 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.labelReadDisk2 = new System.Windows.Forms.Label();
            this.labelWriteDisk2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBoxDisk1 = new System.Windows.Forms.GroupBox();
            this.progressBarDisk1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.labelReadDisk1 = new System.Windows.Forms.Label();
            this.labelWriteDisk1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxDisk0 = new System.Windows.Forms.GroupBox();
            this.progressBarDisk0 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.labelReadDisk0 = new System.Windows.Forms.Label();
            this.labelWriteDisk0 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxRAM = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Usage = new System.Windows.Forms.Label();
            this.circularProgressBarRAMLoad = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarRAMUsage = new CircularProgressBar.CircularProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.geckoWebBrowserCapital = new Gecko.GeckoWebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.geckoWebBrowserCalc = new Gecko.GeckoWebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.geckoWebBrowserYoutube = new Gecko.GeckoWebBrowser();
            this.labelSpaceDisk0 = new System.Windows.Forms.Label();
            this.labelSpaceDisk1 = new System.Windows.Forms.Label();
            this.labelSpaceDisk2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxCPU.SuspendLayout();
            this.groupBoxGPU.SuspendLayout();
            this.groupBoxHDD.SuspendLayout();
            this.groupBoxDisk2.SuspendLayout();
            this.groupBoxDisk1.SuspendLayout();
            this.groupBoxDisk0.SuspendLayout();
            this.groupBoxRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Controls.Add(this.groupBoxHDD);
            this.panel1.Controls.Add(this.groupBoxRAM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 386);
            this.panel1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(165, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxCPU);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBoxGPU);
            this.splitContainer2.Size = new System.Drawing.Size(523, 386);
            this.splitContainer2.SplitterDistance = 186;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.Controls.Add(this.label6);
            this.groupBoxCPU.Controls.Add(this.label4);
            this.groupBoxCPU.Controls.Add(this.label2);
            this.groupBoxCPU.Controls.Add(this.circularProgressBarCPUTemp);
            this.groupBoxCPU.Controls.Add(this.circularProgressBarCPULoad);
            this.groupBoxCPU.Controls.Add(this.circularProgressBarCPURPM);
            this.groupBoxCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCPU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(523, 186);
            this.groupBoxCPU.TabIndex = 9;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Load";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temp";
            // 
            // circularProgressBarCPUTemp
            // 
            this.circularProgressBarCPUTemp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarCPUTemp.AnimationSpeed = 500;
            this.circularProgressBarCPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPUTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarCPUTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarCPUTemp.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBarCPUTemp.InnerMargin = 2;
            this.circularProgressBarCPUTemp.InnerWidth = -1;
            this.circularProgressBarCPUTemp.Location = new System.Drawing.Point(6, 30);
            this.circularProgressBarCPUTemp.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPUTemp.Name = "circularProgressBarCPUTemp";
            this.circularProgressBarCPUTemp.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarCPUTemp.OuterMargin = -15;
            this.circularProgressBarCPUTemp.OuterWidth = 10;
            this.circularProgressBarCPUTemp.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBarCPUTemp.ProgressWidth = 17;
            this.circularProgressBarCPUTemp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarCPUTemp.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarCPUTemp.StartAngle = 270;
            this.circularProgressBarCPUTemp.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarCPUTemp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPUTemp.SubscriptText = "";
            this.circularProgressBarCPUTemp.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarCPUTemp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPUTemp.SuperscriptText = "";
            this.circularProgressBarCPUTemp.TabIndex = 0;
            this.circularProgressBarCPUTemp.Text = "0°C";
            this.circularProgressBarCPUTemp.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarCPUTemp.Value = 68;
            // 
            // circularProgressBarCPULoad
            // 
            this.circularProgressBarCPULoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarCPULoad.AnimationSpeed = 500;
            this.circularProgressBarCPULoad.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPULoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarCPULoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarCPULoad.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBarCPULoad.InnerMargin = 2;
            this.circularProgressBarCPULoad.InnerWidth = -1;
            this.circularProgressBarCPULoad.Location = new System.Drawing.Point(162, 30);
            this.circularProgressBarCPULoad.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPULoad.Name = "circularProgressBarCPULoad";
            this.circularProgressBarCPULoad.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarCPULoad.OuterMargin = -15;
            this.circularProgressBarCPULoad.OuterWidth = 10;
            this.circularProgressBarCPULoad.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBarCPULoad.ProgressWidth = 17;
            this.circularProgressBarCPULoad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarCPULoad.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarCPULoad.StartAngle = 270;
            this.circularProgressBarCPULoad.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarCPULoad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPULoad.SubscriptText = "";
            this.circularProgressBarCPULoad.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarCPULoad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPULoad.SuperscriptText = "";
            this.circularProgressBarCPULoad.TabIndex = 1;
            this.circularProgressBarCPULoad.Text = "0%";
            this.circularProgressBarCPULoad.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarCPULoad.Value = 68;
            // 
            // circularProgressBarCPURPM
            // 
            this.circularProgressBarCPURPM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarCPURPM.AnimationSpeed = 500;
            this.circularProgressBarCPURPM.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarCPURPM.Enabled = false;
            this.circularProgressBarCPURPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarCPURPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarCPURPM.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBarCPURPM.InnerMargin = 2;
            this.circularProgressBarCPURPM.InnerWidth = -1;
            this.circularProgressBarCPURPM.Location = new System.Drawing.Point(318, 30);
            this.circularProgressBarCPURPM.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarCPURPM.Name = "circularProgressBarCPURPM";
            this.circularProgressBarCPURPM.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarCPURPM.OuterMargin = -15;
            this.circularProgressBarCPURPM.OuterWidth = 10;
            this.circularProgressBarCPURPM.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBarCPURPM.ProgressWidth = 17;
            this.circularProgressBarCPURPM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarCPURPM.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarCPURPM.StartAngle = 270;
            this.circularProgressBarCPURPM.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarCPURPM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarCPURPM.SubscriptText = "";
            this.circularProgressBarCPURPM.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarCPURPM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarCPURPM.SuperscriptText = "";
            this.circularProgressBarCPURPM.TabIndex = 2;
            this.circularProgressBarCPURPM.Text = "0%";
            this.circularProgressBarCPURPM.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarCPURPM.Value = 68;
            // 
            // groupBoxGPU
            // 
            this.groupBoxGPU.Controls.Add(this.label5);
            this.groupBoxGPU.Controls.Add(this.label3);
            this.groupBoxGPU.Controls.Add(this.label1);
            this.groupBoxGPU.Controls.Add(this.circularProgressBarGPURPM);
            this.groupBoxGPU.Controls.Add(this.circularProgressBarGPULoad);
            this.groupBoxGPU.Controls.Add(this.circularProgressBarGPUTemp);
            this.groupBoxGPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGPU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGPU.Name = "groupBoxGPU";
            this.groupBoxGPU.Size = new System.Drawing.Size(523, 196);
            this.groupBoxGPU.TabIndex = 10;
            this.groupBoxGPU.TabStop = false;
            this.groupBoxGPU.Text = "GPU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Load";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temp";
            // 
            // circularProgressBarGPURPM
            // 
            this.circularProgressBarGPURPM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarGPURPM.AnimationSpeed = 500;
            this.circularProgressBarGPURPM.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarGPURPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarGPURPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarGPURPM.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBarGPURPM.InnerMargin = 2;
            this.circularProgressBarGPURPM.InnerWidth = -1;
            this.circularProgressBarGPURPM.Location = new System.Drawing.Point(318, 29);
            this.circularProgressBarGPURPM.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarGPURPM.Name = "circularProgressBarGPURPM";
            this.circularProgressBarGPURPM.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarGPURPM.OuterMargin = -15;
            this.circularProgressBarGPURPM.OuterWidth = 10;
            this.circularProgressBarGPURPM.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBarGPURPM.ProgressWidth = 17;
            this.circularProgressBarGPURPM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarGPURPM.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarGPURPM.StartAngle = 270;
            this.circularProgressBarGPURPM.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarGPURPM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarGPURPM.SubscriptText = "";
            this.circularProgressBarGPURPM.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarGPURPM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarGPURPM.SuperscriptText = "";
            this.circularProgressBarGPURPM.TabIndex = 2;
            this.circularProgressBarGPURPM.Text = "0%";
            this.circularProgressBarGPURPM.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarGPURPM.Value = 68;
            // 
            // circularProgressBarGPULoad
            // 
            this.circularProgressBarGPULoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarGPULoad.AnimationSpeed = 500;
            this.circularProgressBarGPULoad.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarGPULoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarGPULoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarGPULoad.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBarGPULoad.InnerMargin = 2;
            this.circularProgressBarGPULoad.InnerWidth = -1;
            this.circularProgressBarGPULoad.Location = new System.Drawing.Point(162, 29);
            this.circularProgressBarGPULoad.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarGPULoad.Name = "circularProgressBarGPULoad";
            this.circularProgressBarGPULoad.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarGPULoad.OuterMargin = -15;
            this.circularProgressBarGPULoad.OuterWidth = 10;
            this.circularProgressBarGPULoad.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBarGPULoad.ProgressWidth = 17;
            this.circularProgressBarGPULoad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarGPULoad.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarGPULoad.StartAngle = 270;
            this.circularProgressBarGPULoad.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarGPULoad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarGPULoad.SubscriptText = "";
            this.circularProgressBarGPULoad.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarGPULoad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarGPULoad.SuperscriptText = "";
            this.circularProgressBarGPULoad.TabIndex = 1;
            this.circularProgressBarGPULoad.Text = "0%";
            this.circularProgressBarGPULoad.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarGPULoad.Value = 68;
            // 
            // circularProgressBarGPUTemp
            // 
            this.circularProgressBarGPUTemp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarGPUTemp.AnimationSpeed = 500;
            this.circularProgressBarGPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarGPUTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarGPUTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarGPUTemp.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBarGPUTemp.InnerMargin = 2;
            this.circularProgressBarGPUTemp.InnerWidth = -1;
            this.circularProgressBarGPUTemp.Location = new System.Drawing.Point(6, 29);
            this.circularProgressBarGPUTemp.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarGPUTemp.Name = "circularProgressBarGPUTemp";
            this.circularProgressBarGPUTemp.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarGPUTemp.OuterMargin = -15;
            this.circularProgressBarGPUTemp.OuterWidth = 10;
            this.circularProgressBarGPUTemp.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBarGPUTemp.ProgressWidth = 17;
            this.circularProgressBarGPUTemp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarGPUTemp.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarGPUTemp.StartAngle = 270;
            this.circularProgressBarGPUTemp.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarGPUTemp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarGPUTemp.SubscriptText = "";
            this.circularProgressBarGPUTemp.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarGPUTemp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarGPUTemp.SuperscriptText = "";
            this.circularProgressBarGPUTemp.TabIndex = 0;
            this.circularProgressBarGPUTemp.Text = "0°C";
            this.circularProgressBarGPUTemp.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarGPUTemp.Value = 68;
            // 
            // groupBoxHDD
            // 
            this.groupBoxHDD.Controls.Add(this.groupBoxDisk2);
            this.groupBoxHDD.Controls.Add(this.groupBoxDisk1);
            this.groupBoxHDD.Controls.Add(this.groupBoxDisk0);
            this.groupBoxHDD.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHDD.Location = new System.Drawing.Point(688, 0);
            this.groupBoxHDD.Name = "groupBoxHDD";
            this.groupBoxHDD.Size = new System.Drawing.Size(296, 386);
            this.groupBoxHDD.TabIndex = 12;
            this.groupBoxHDD.TabStop = false;
            this.groupBoxHDD.Text = "HDD";
            // 
            // groupBoxDisk2
            // 
            this.groupBoxDisk2.Controls.Add(this.labelSpaceDisk2);
            this.groupBoxDisk2.Controls.Add(this.progressBarDisk2);
            this.groupBoxDisk2.Controls.Add(this.label11);
            this.groupBoxDisk2.Controls.Add(this.labelReadDisk2);
            this.groupBoxDisk2.Controls.Add(this.labelWriteDisk2);
            this.groupBoxDisk2.Controls.Add(this.label15);
            this.groupBoxDisk2.Location = new System.Drawing.Point(6, 272);
            this.groupBoxDisk2.Name = "groupBoxDisk2";
            this.groupBoxDisk2.Size = new System.Drawing.Size(283, 114);
            this.groupBoxDisk2.TabIndex = 11;
            this.groupBoxDisk2.TabStop = false;
            this.groupBoxDisk2.Text = "Disk 2";
            // 
            // progressBarDisk2
            // 
            this.progressBarDisk2.Location = new System.Drawing.Point(6, 81);
            this.progressBarDisk2.Name = "progressBarDisk2";
            this.progressBarDisk2.Size = new System.Drawing.Size(271, 23);
            this.progressBarDisk2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Write:";
            // 
            // labelReadDisk2
            // 
            this.labelReadDisk2.AutoSize = true;
            this.labelReadDisk2.Location = new System.Drawing.Point(1, 53);
            this.labelReadDisk2.Name = "labelReadDisk2";
            this.labelReadDisk2.Size = new System.Drawing.Size(115, 25);
            this.labelReadDisk2.TabIndex = 8;
            this.labelReadDisk2.Text = "10.00MB/s";
            // 
            // labelWriteDisk2
            // 
            this.labelWriteDisk2.AutoSize = true;
            this.labelWriteDisk2.Location = new System.Drawing.Point(162, 53);
            this.labelWriteDisk2.Name = "labelWriteDisk2";
            this.labelWriteDisk2.Size = new System.Drawing.Size(115, 25);
            this.labelWriteDisk2.TabIndex = 6;
            this.labelWriteDisk2.Text = "10.00MB/s";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "Read:";
            // 
            // groupBoxDisk1
            // 
            this.groupBoxDisk1.Controls.Add(this.labelSpaceDisk1);
            this.groupBoxDisk1.Controls.Add(this.progressBarDisk1);
            this.groupBoxDisk1.Controls.Add(this.label10);
            this.groupBoxDisk1.Controls.Add(this.labelReadDisk1);
            this.groupBoxDisk1.Controls.Add(this.labelWriteDisk1);
            this.groupBoxDisk1.Controls.Add(this.label13);
            this.groupBoxDisk1.Location = new System.Drawing.Point(6, 150);
            this.groupBoxDisk1.Name = "groupBoxDisk1";
            this.groupBoxDisk1.Size = new System.Drawing.Size(283, 114);
            this.groupBoxDisk1.TabIndex = 11;
            this.groupBoxDisk1.TabStop = false;
            this.groupBoxDisk1.Text = "Disk 1";
            // 
            // progressBarDisk1
            // 
            this.progressBarDisk1.Location = new System.Drawing.Point(6, 81);
            this.progressBarDisk1.Name = "progressBarDisk1";
            this.progressBarDisk1.Size = new System.Drawing.Size(271, 23);
            this.progressBarDisk1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Write:";
            // 
            // labelReadDisk1
            // 
            this.labelReadDisk1.AutoSize = true;
            this.labelReadDisk1.Location = new System.Drawing.Point(1, 53);
            this.labelReadDisk1.Name = "labelReadDisk1";
            this.labelReadDisk1.Size = new System.Drawing.Size(115, 25);
            this.labelReadDisk1.TabIndex = 8;
            this.labelReadDisk1.Text = "10.00MB/s";
            // 
            // labelWriteDisk1
            // 
            this.labelWriteDisk1.AutoSize = true;
            this.labelWriteDisk1.Location = new System.Drawing.Point(162, 53);
            this.labelWriteDisk1.Name = "labelWriteDisk1";
            this.labelWriteDisk1.Size = new System.Drawing.Size(115, 25);
            this.labelWriteDisk1.TabIndex = 6;
            this.labelWriteDisk1.Text = "10.00MB/s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Read:";
            // 
            // groupBoxDisk0
            // 
            this.groupBoxDisk0.Controls.Add(this.labelSpaceDisk0);
            this.groupBoxDisk0.Controls.Add(this.progressBarDisk0);
            this.groupBoxDisk0.Controls.Add(this.label7);
            this.groupBoxDisk0.Controls.Add(this.labelReadDisk0);
            this.groupBoxDisk0.Controls.Add(this.labelWriteDisk0);
            this.groupBoxDisk0.Controls.Add(this.label9);
            this.groupBoxDisk0.Location = new System.Drawing.Point(6, 30);
            this.groupBoxDisk0.Name = "groupBoxDisk0";
            this.groupBoxDisk0.Size = new System.Drawing.Size(283, 114);
            this.groupBoxDisk0.TabIndex = 10;
            this.groupBoxDisk0.TabStop = false;
            this.groupBoxDisk0.Text = "Disk 0";
            // 
            // progressBarDisk0
            // 
            this.progressBarDisk0.Location = new System.Drawing.Point(6, 81);
            this.progressBarDisk0.Name = "progressBarDisk0";
            this.progressBarDisk0.Size = new System.Drawing.Size(271, 23);
            this.progressBarDisk0.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Write:";
            // 
            // labelReadDisk0
            // 
            this.labelReadDisk0.AutoSize = true;
            this.labelReadDisk0.Location = new System.Drawing.Point(1, 53);
            this.labelReadDisk0.Name = "labelReadDisk0";
            this.labelReadDisk0.Size = new System.Drawing.Size(115, 25);
            this.labelReadDisk0.TabIndex = 8;
            this.labelReadDisk0.Text = "10.00MB/s";
            // 
            // labelWriteDisk0
            // 
            this.labelWriteDisk0.AutoSize = true;
            this.labelWriteDisk0.Location = new System.Drawing.Point(162, 53);
            this.labelWriteDisk0.Name = "labelWriteDisk0";
            this.labelWriteDisk0.Size = new System.Drawing.Size(115, 25);
            this.labelWriteDisk0.TabIndex = 6;
            this.labelWriteDisk0.Text = "10.00MB/s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Read:";
            // 
            // groupBoxRAM
            // 
            this.groupBoxRAM.Controls.Add(this.label8);
            this.groupBoxRAM.Controls.Add(this.Usage);
            this.groupBoxRAM.Controls.Add(this.circularProgressBarRAMLoad);
            this.groupBoxRAM.Controls.Add(this.circularProgressBarRAMUsage);
            this.groupBoxRAM.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRAM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRAM.Name = "groupBoxRAM";
            this.groupBoxRAM.Size = new System.Drawing.Size(165, 386);
            this.groupBoxRAM.TabIndex = 11;
            this.groupBoxRAM.TabStop = false;
            this.groupBoxRAM.Text = "RAM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Load";
            // 
            // Usage
            // 
            this.Usage.AutoSize = true;
            this.Usage.Location = new System.Drawing.Point(46, 67);
            this.Usage.Name = "Usage";
            this.Usage.Size = new System.Drawing.Size(74, 25);
            this.Usage.TabIndex = 3;
            this.Usage.Text = "Usage";
            // 
            // circularProgressBarRAMLoad
            // 
            this.circularProgressBarRAMLoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarRAMLoad.AnimationSpeed = 500;
            this.circularProgressBarRAMLoad.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarRAMLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarRAMLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarRAMLoad.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBarRAMLoad.InnerMargin = 2;
            this.circularProgressBarRAMLoad.InnerWidth = -1;
            this.circularProgressBarRAMLoad.Location = new System.Drawing.Point(6, 224);
            this.circularProgressBarRAMLoad.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarRAMLoad.Name = "circularProgressBarRAMLoad";
            this.circularProgressBarRAMLoad.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarRAMLoad.OuterMargin = -15;
            this.circularProgressBarRAMLoad.OuterWidth = 10;
            this.circularProgressBarRAMLoad.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBarRAMLoad.ProgressWidth = 17;
            this.circularProgressBarRAMLoad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarRAMLoad.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarRAMLoad.StartAngle = 270;
            this.circularProgressBarRAMLoad.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarRAMLoad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarRAMLoad.SubscriptText = "";
            this.circularProgressBarRAMLoad.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarRAMLoad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarRAMLoad.SuperscriptText = "";
            this.circularProgressBarRAMLoad.TabIndex = 1;
            this.circularProgressBarRAMLoad.Text = "0%";
            this.circularProgressBarRAMLoad.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarRAMLoad.Value = 68;
            // 
            // circularProgressBarRAMUsage
            // 
            this.circularProgressBarRAMUsage.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarRAMUsage.AnimationSpeed = 500;
            this.circularProgressBarRAMUsage.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarRAMUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarRAMUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarRAMUsage.InnerColor = System.Drawing.SystemColors.Control;
            this.circularProgressBarRAMUsage.InnerMargin = 2;
            this.circularProgressBarRAMUsage.InnerWidth = -1;
            this.circularProgressBarRAMUsage.Location = new System.Drawing.Point(6, 31);
            this.circularProgressBarRAMUsage.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarRAMUsage.Name = "circularProgressBarRAMUsage";
            this.circularProgressBarRAMUsage.OuterColor = System.Drawing.Color.LightGray;
            this.circularProgressBarRAMUsage.OuterMargin = -15;
            this.circularProgressBarRAMUsage.OuterWidth = 10;
            this.circularProgressBarRAMUsage.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBarRAMUsage.ProgressWidth = 17;
            this.circularProgressBarRAMUsage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarRAMUsage.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBarRAMUsage.StartAngle = 270;
            this.circularProgressBarRAMUsage.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarRAMUsage.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarRAMUsage.SubscriptText = "";
            this.circularProgressBarRAMUsage.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBarRAMUsage.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarRAMUsage.SuperscriptText = "";
            this.circularProgressBarRAMUsage.TabIndex = 0;
            this.circularProgressBarRAMUsage.Text = "0GB";
            this.circularProgressBarRAMUsage.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarRAMUsage.Value = 68;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 961);
            this.splitContainer1.SplitterDistance = 571;
            this.splitContainer1.TabIndex = 10;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 571);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.geckoWebBrowserCapital);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Capital FM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // geckoWebBrowserCapital
            // 
            this.geckoWebBrowserCapital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowserCapital.Location = new System.Drawing.Point(3, 3);
            this.geckoWebBrowserCapital.Name = "geckoWebBrowserCapital";
            this.geckoWebBrowserCapital.Size = new System.Drawing.Size(970, 532);
            this.geckoWebBrowserCapital.TabIndex = 1;
            this.geckoWebBrowserCapital.UseHttpActivityObserver = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.geckoWebBrowserCalc);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // geckoWebBrowserCalc
            // 
            this.geckoWebBrowserCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowserCalc.Location = new System.Drawing.Point(3, 3);
            this.geckoWebBrowserCalc.Name = "geckoWebBrowserCalc";
            this.geckoWebBrowserCalc.Size = new System.Drawing.Size(970, 532);
            this.geckoWebBrowserCalc.TabIndex = 0;
            this.geckoWebBrowserCalc.UseHttpActivityObserver = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.geckoWebBrowserYoutube);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 538);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "YouTube";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // geckoWebBrowserYoutube
            // 
            this.geckoWebBrowserYoutube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowserYoutube.Location = new System.Drawing.Point(3, 3);
            this.geckoWebBrowserYoutube.Name = "geckoWebBrowserYoutube";
            this.geckoWebBrowserYoutube.Size = new System.Drawing.Size(970, 532);
            this.geckoWebBrowserYoutube.TabIndex = 1;
            this.geckoWebBrowserYoutube.UseHttpActivityObserver = false;
            // 
            // labelSpaceDisk0
            // 
            this.labelSpaceDisk0.AutoSize = true;
            this.labelSpaceDisk0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpaceDisk0.Location = new System.Drawing.Point(102, 86);
            this.labelSpaceDisk0.Name = "labelSpaceDisk0";
            this.labelSpaceDisk0.Size = new System.Drawing.Size(78, 13);
            this.labelSpaceDisk0.TabIndex = 10;
            this.labelSpaceDisk0.Text = "1000/1000 GB";
            // 
            // labelSpaceDisk1
            // 
            this.labelSpaceDisk1.AutoSize = true;
            this.labelSpaceDisk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpaceDisk1.Location = new System.Drawing.Point(102, 87);
            this.labelSpaceDisk1.Name = "labelSpaceDisk1";
            this.labelSpaceDisk1.Size = new System.Drawing.Size(78, 13);
            this.labelSpaceDisk1.TabIndex = 11;
            this.labelSpaceDisk1.Text = "1000/1000 GB";
            // 
            // labelSpaceDisk2
            // 
            this.labelSpaceDisk2.AutoSize = true;
            this.labelSpaceDisk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpaceDisk2.Location = new System.Drawing.Point(105, 86);
            this.labelSpaceDisk2.Name = "labelSpaceDisk2";
            this.labelSpaceDisk2.Size = new System.Drawing.Size(75, 13);
            this.labelSpaceDisk2.TabIndex = 11;
            this.labelSpaceDisk2.Text = "1000/1000GB";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "PC Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxCPU.ResumeLayout(false);
            this.groupBoxCPU.PerformLayout();
            this.groupBoxGPU.ResumeLayout(false);
            this.groupBoxGPU.PerformLayout();
            this.groupBoxHDD.ResumeLayout(false);
            this.groupBoxDisk2.ResumeLayout(false);
            this.groupBoxDisk2.PerformLayout();
            this.groupBoxDisk1.ResumeLayout(false);
            this.groupBoxDisk1.PerformLayout();
            this.groupBoxDisk0.ResumeLayout(false);
            this.groupBoxDisk0.PerformLayout();
            this.groupBoxRAM.ResumeLayout(false);
            this.groupBoxRAM.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxHDD;
        private System.Windows.Forms.GroupBox groupBoxRAM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Usage;
        private CircularProgressBar.CircularProgressBar circularProgressBarRAMLoad;
        private CircularProgressBar.CircularProgressBar circularProgressBarRAMUsage;
        private System.Windows.Forms.GroupBox groupBoxGPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar circularProgressBarGPURPM;
        private CircularProgressBar.CircularProgressBar circularProgressBarGPULoad;
        private CircularProgressBar.CircularProgressBar circularProgressBarGPUTemp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxCPU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar circularProgressBarCPULoad;
        private CircularProgressBar.CircularProgressBar circularProgressBarCPURPM;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar circularProgressBarCPUTemp;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private Gecko.GeckoWebBrowser geckoWebBrowserCalc;
        private System.Windows.Forms.TabPage tabPage1;
        private Gecko.GeckoWebBrowser geckoWebBrowserCapital;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWriteDisk0;
        private System.Windows.Forms.Label labelReadDisk0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private Gecko.GeckoWebBrowser geckoWebBrowserYoutube;
        private System.Windows.Forms.GroupBox groupBoxDisk0;
        private System.Windows.Forms.ProgressBar progressBarDisk0;
        private System.Windows.Forms.GroupBox groupBoxDisk2;
        private System.Windows.Forms.ProgressBar progressBarDisk2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelReadDisk2;
        private System.Windows.Forms.Label labelWriteDisk2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBoxDisk1;
        private System.Windows.Forms.ProgressBar progressBarDisk1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelReadDisk1;
        private System.Windows.Forms.Label labelWriteDisk1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelSpaceDisk2;
        private System.Windows.Forms.Label labelSpaceDisk1;
        private System.Windows.Forms.Label labelSpaceDisk0;
    }
}

