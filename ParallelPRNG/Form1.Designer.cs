namespace ParallelPRNG
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
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.btnSeed = new System.Windows.Forms.Button();
            this.btnNextUInteger = new System.Windows.Forms.Button();
            this.btnNextRanged = new System.Windows.Forms.Button();
            this.btnCurrentEntropy = new System.Windows.Forms.Button();
            this.numUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMaxU = new System.Windows.Forms.NumericUpDown();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnUMax = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMaxIterations = new System.Windows.Forms.Button();
            this.numUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBenchIterations = new System.Windows.Forms.Button();
            this.numUpDownBenchIterations = new System.Windows.Forms.NumericUpDown();
            this.btnBenchMin = new System.Windows.Forms.Button();
            this.numUpDownBenchMin = new System.Windows.Forms.NumericUpDown();
            this.numUpDownBenchMax = new System.Windows.Forms.NumericUpDown();
            this.btnBenchMax = new System.Windows.Forms.Button();
            this.tableLayoutPanelTextBox = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimeFullThread = new System.Windows.Forms.Button();
            this.txtOutput3 = new System.Windows.Forms.RichTextBox();
            this.txtOutput2 = new System.Windows.Forms.RichTextBox();
            this.txtOutput1 = new System.Windows.Forms.RichTextBox();
            this.txtOutput0 = new System.Windows.Forms.RichTextBox();
            this.btnTimeHalfPlusOneAvailThread = new System.Windows.Forms.Button();
            this.btnTimeSingleThread = new System.Windows.Forms.Button();
            this.btnTimeHalfAvailThread = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnMinQueryValue = new System.Windows.Forms.Button();
            this.btnMaxQueryValue = new System.Windows.Forms.Button();
            this.btnQueryRange = new System.Windows.Forms.Button();
            this.numUpDownMinQueryValue = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMaxQueryValue = new System.Windows.Forms.NumericUpDown();
            this.btnQueryValue = new System.Windows.Forms.Button();
            this.numUpDownQueryValue = new System.Windows.Forms.NumericUpDown();
            this.btnPQMin = new System.Windows.Forms.Button();
            this.btnPQMax = new System.Windows.Forms.Button();
            this.btnPQIterations = new System.Windows.Forms.Button();
            this.btnCreateNumberTable = new System.Windows.Forms.Button();
            this.numUpDownPQIterations = new System.Windows.Forms.NumericUpDown();
            this.txtPQConsole = new System.Windows.Forms.RichTextBox();
            this.numUpDownPQMin = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPQMax = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpCards = new System.Windows.Forms.GroupBox();
            this.btnShuffleDeck = new System.Windows.Forms.Button();
            this.btnGetNewDeck = new System.Windows.Forms.Button();
            this.btnClearCanvas = new System.Windows.Forms.Button();
            this.btnRandomWalk = new System.Windows.Forms.Button();
            this.btnGenerateVerticalBars = new System.Windows.Forms.Button();
            this.btnGenerateBWNoise = new System.Windows.Forms.Button();
            this.btnGenerateRGBNoise = new System.Windows.Forms.Button();
            this.canvasTab3 = new System.Windows.Forms.PictureBox();
            this.btnThrowCard = new System.Windows.Forms.Button();
            this.txtCardsRemaining = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxU)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownIterations)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBenchIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBenchMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBenchMax)).BeginInit();
            this.tableLayoutPanelTextBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinQueryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxQueryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQueryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPQIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPQMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPQMax)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.grpCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasTab3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(5, 6);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(1024, 464);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            this.txtConsole.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtConsole_MouseDoubleClick);
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(657, 474);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(372, 20);
            this.btnSeed.TabIndex = 1;
            this.btnSeed.Text = "Display Original Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // btnNextUInteger
            // 
            this.btnNextUInteger.Location = new System.Drawing.Point(929, 526);
            this.btnNextUInteger.Name = "btnNextUInteger";
            this.btnNextUInteger.Size = new System.Drawing.Size(100, 20);
            this.btnNextUInteger.TabIndex = 2;
            this.btnNextUInteger.Text = "Next UInteger";
            this.btnNextUInteger.UseVisualStyleBackColor = true;
            this.btnNextUInteger.Click += new System.EventHandler(this.btnNextUInteger_Click);
            // 
            // btnNextRanged
            // 
            this.btnNextRanged.Location = new System.Drawing.Point(260, 476);
            this.btnNextRanged.Name = "btnNextRanged";
            this.btnNextRanged.Size = new System.Drawing.Size(125, 72);
            this.btnNextRanged.TabIndex = 3;
            this.btnNextRanged.Text = "Next Ranged";
            this.btnNextRanged.UseVisualStyleBackColor = true;
            this.btnNextRanged.Click += new System.EventHandler(this.btnNextRanged_Click);
            // 
            // btnCurrentEntropy
            // 
            this.btnCurrentEntropy.Location = new System.Drawing.Point(657, 500);
            this.btnCurrentEntropy.Name = "btnCurrentEntropy";
            this.btnCurrentEntropy.Size = new System.Drawing.Size(372, 20);
            this.btnCurrentEntropy.TabIndex = 5;
            this.btnCurrentEntropy.Text = "Display Current Entropy Value";
            this.btnCurrentEntropy.UseVisualStyleBackColor = true;
            this.btnCurrentEntropy.Click += new System.EventHandler(this.btnCurrentEntropy_Click);
            // 
            // numUpDownMax
            // 
            this.numUpDownMax.Location = new System.Drawing.Point(92, 476);
            this.numUpDownMax.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numUpDownMax.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.numUpDownMax.Name = "numUpDownMax";
            this.numUpDownMax.Size = new System.Drawing.Size(162, 20);
            this.numUpDownMax.TabIndex = 8;
            this.numUpDownMax.ThousandsSeparator = true;
            this.numUpDownMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numUpDownMin
            // 
            this.numUpDownMin.Location = new System.Drawing.Point(92, 502);
            this.numUpDownMin.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numUpDownMin.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.numUpDownMin.Name = "numUpDownMin";
            this.numUpDownMin.Size = new System.Drawing.Size(162, 20);
            this.numUpDownMin.TabIndex = 9;
            this.numUpDownMin.ThousandsSeparator = true;
            // 
            // numUpDownMaxU
            // 
            this.numUpDownMaxU.Location = new System.Drawing.Point(747, 526);
            this.numUpDownMaxU.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numUpDownMaxU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownMaxU.Name = "numUpDownMaxU";
            this.numUpDownMaxU.Size = new System.Drawing.Size(176, 20);
            this.numUpDownMaxU.TabIndex = 10;
            this.numUpDownMaxU.ThousandsSeparator = true;
            this.numUpDownMaxU.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(5, 476);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(81, 20);
            this.btnMax.TabIndex = 11;
            this.btnMax.Text = "MaxExclusive";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(5, 502);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(81, 20);
            this.btnMin.TabIndex = 12;
            this.btnMin.Text = "MinInclusive";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnUMax
            // 
            this.btnUMax.Location = new System.Drawing.Point(657, 526);
            this.btnUMax.Name = "btnUMax";
            this.btnUMax.Size = new System.Drawing.Size(84, 20);
            this.btnUMax.TabIndex = 13;
            this.btnUMax.Text = "MaxExclusive";
            this.btnUMax.UseVisualStyleBackColor = true;
            this.btnUMax.Click += new System.EventHandler(this.btnUMax_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 579);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMaxIterations);
            this.tabPage1.Controls.Add(this.numUpDownIterations);
            this.tabPage1.Controls.Add(this.txtConsole);
            this.tabPage1.Controls.Add(this.btnNextUInteger);
            this.tabPage1.Controls.Add(this.numUpDownMaxU);
            this.tabPage1.Controls.Add(this.btnUMax);
            this.tabPage1.Controls.Add(this.btnSeed);
            this.tabPage1.Controls.Add(this.btnMin);
            this.tabPage1.Controls.Add(this.btnNextRanged);
            this.tabPage1.Controls.Add(this.numUpDownMin);
            this.tabPage1.Controls.Add(this.btnCurrentEntropy);
            this.tabPage1.Controls.Add(this.numUpDownMax);
            this.tabPage1.Controls.Add(this.btnMax);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1034, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMaxIterations
            // 
            this.btnMaxIterations.Location = new System.Drawing.Point(5, 528);
            this.btnMaxIterations.Name = "btnMaxIterations";
            this.btnMaxIterations.Size = new System.Drawing.Size(81, 20);
            this.btnMaxIterations.TabIndex = 15;
            this.btnMaxIterations.Text = "Iterations";
            this.btnMaxIterations.UseVisualStyleBackColor = true;
            this.btnMaxIterations.Click += new System.EventHandler(this.btnMaxIterations_Click);
            // 
            // numUpDownIterations
            // 
            this.numUpDownIterations.Location = new System.Drawing.Point(92, 528);
            this.numUpDownIterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownIterations.Name = "numUpDownIterations";
            this.numUpDownIterations.Size = new System.Drawing.Size(162, 20);
            this.numUpDownIterations.TabIndex = 14;
            this.numUpDownIterations.ThousandsSeparator = true;
            this.numUpDownIterations.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBenchIterations);
            this.tabPage2.Controls.Add(this.numUpDownBenchIterations);
            this.tabPage2.Controls.Add(this.btnBenchMin);
            this.tabPage2.Controls.Add(this.numUpDownBenchMin);
            this.tabPage2.Controls.Add(this.numUpDownBenchMax);
            this.tabPage2.Controls.Add(this.btnBenchMax);
            this.tabPage2.Controls.Add(this.tableLayoutPanelTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1034, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Benchmarks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBenchIterations
            // 
            this.btnBenchIterations.Location = new System.Drawing.Point(578, 528);
            this.btnBenchIterations.Name = "btnBenchIterations";
            this.btnBenchIterations.Size = new System.Drawing.Size(81, 20);
            this.btnBenchIterations.TabIndex = 21;
            this.btnBenchIterations.Text = "Iterations";
            this.btnBenchIterations.UseVisualStyleBackColor = true;
            this.btnBenchIterations.Click += new System.EventHandler(this.btnBenchIterations_Click);
            // 
            // numUpDownBenchIterations
            // 
            this.numUpDownBenchIterations.Location = new System.Drawing.Point(665, 528);
            this.numUpDownBenchIterations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownBenchIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBenchIterations.Name = "numUpDownBenchIterations";
            this.numUpDownBenchIterations.Size = new System.Drawing.Size(183, 20);
            this.numUpDownBenchIterations.TabIndex = 20;
            this.numUpDownBenchIterations.ThousandsSeparator = true;
            this.numUpDownBenchIterations.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btnBenchMin
            // 
            this.btnBenchMin.Location = new System.Drawing.Point(6, 528);
            this.btnBenchMin.Name = "btnBenchMin";
            this.btnBenchMin.Size = new System.Drawing.Size(81, 20);
            this.btnBenchMin.TabIndex = 19;
            this.btnBenchMin.Text = "MinInclusive";
            this.btnBenchMin.UseVisualStyleBackColor = true;
            this.btnBenchMin.Click += new System.EventHandler(this.btnBenchMin_Click);
            // 
            // numUpDownBenchMin
            // 
            this.numUpDownBenchMin.Location = new System.Drawing.Point(93, 528);
            this.numUpDownBenchMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numUpDownBenchMin.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.numUpDownBenchMin.Name = "numUpDownBenchMin";
            this.numUpDownBenchMin.Size = new System.Drawing.Size(183, 20);
            this.numUpDownBenchMin.TabIndex = 17;
            this.numUpDownBenchMin.ThousandsSeparator = true;
            // 
            // numUpDownBenchMax
            // 
            this.numUpDownBenchMax.Location = new System.Drawing.Point(379, 528);
            this.numUpDownBenchMax.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numUpDownBenchMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBenchMax.Name = "numUpDownBenchMax";
            this.numUpDownBenchMax.Size = new System.Drawing.Size(183, 20);
            this.numUpDownBenchMax.TabIndex = 16;
            this.numUpDownBenchMax.ThousandsSeparator = true;
            this.numUpDownBenchMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnBenchMax
            // 
            this.btnBenchMax.Location = new System.Drawing.Point(292, 528);
            this.btnBenchMax.Name = "btnBenchMax";
            this.btnBenchMax.Size = new System.Drawing.Size(81, 20);
            this.btnBenchMax.TabIndex = 18;
            this.btnBenchMax.Text = "MaxExclusive";
            this.btnBenchMax.UseVisualStyleBackColor = true;
            this.btnBenchMax.Click += new System.EventHandler(this.btnBenchMax_Click);
            // 
            // tableLayoutPanelTextBox
            // 
            this.tableLayoutPanelTextBox.ColumnCount = 4;
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTextBox.Controls.Add(this.btnTimeFullThread, 3, 1);
            this.tableLayoutPanelTextBox.Controls.Add(this.txtOutput3, 3, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.txtOutput2, 2, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.txtOutput1, 1, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.txtOutput0, 0, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.btnTimeHalfPlusOneAvailThread, 2, 1);
            this.tableLayoutPanelTextBox.Controls.Add(this.btnTimeSingleThread, 0, 1);
            this.tableLayoutPanelTextBox.Controls.Add(this.btnTimeHalfAvailThread, 1, 1);
            this.tableLayoutPanelTextBox.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelTextBox.Name = "tableLayoutPanelTextBox";
            this.tableLayoutPanelTextBox.RowCount = 2;
            this.tableLayoutPanelTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanelTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelTextBox.Size = new System.Drawing.Size(1026, 518);
            this.tableLayoutPanelTextBox.TabIndex = 0;
            // 
            // btnTimeFullThread
            // 
            this.btnTimeFullThread.Location = new System.Drawing.Point(770, 483);
            this.btnTimeFullThread.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimeFullThread.Name = "btnTimeFullThread";
            this.btnTimeFullThread.Size = new System.Drawing.Size(254, 33);
            this.btnTimeFullThread.TabIndex = 5;
            this.btnTimeFullThread.Text = "Run Full-Threaded Benchmark";
            this.btnTimeFullThread.UseVisualStyleBackColor = true;
            this.btnTimeFullThread.Click += new System.EventHandler(this.btnTimeFullThread_Click);
            // 
            // txtOutput3
            // 
            this.txtOutput3.Location = new System.Drawing.Point(770, 2);
            this.txtOutput3.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput3.Name = "txtOutput3";
            this.txtOutput3.ReadOnly = true;
            this.txtOutput3.Size = new System.Drawing.Size(254, 477);
            this.txtOutput3.TabIndex = 3;
            this.txtOutput3.Text = "";
            this.txtOutput3.TextChanged += new System.EventHandler(this.txtOutput3_TextChanged);
            // 
            // txtOutput2
            // 
            this.txtOutput2.Location = new System.Drawing.Point(514, 2);
            this.txtOutput2.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.ReadOnly = true;
            this.txtOutput2.Size = new System.Drawing.Size(252, 477);
            this.txtOutput2.TabIndex = 2;
            this.txtOutput2.Text = "";
            this.txtOutput2.TextChanged += new System.EventHandler(this.txtOutput2_TextChanged);
            // 
            // txtOutput1
            // 
            this.txtOutput1.Location = new System.Drawing.Point(258, 2);
            this.txtOutput1.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput1.Name = "txtOutput1";
            this.txtOutput1.ReadOnly = true;
            this.txtOutput1.Size = new System.Drawing.Size(252, 477);
            this.txtOutput1.TabIndex = 1;
            this.txtOutput1.Text = "";
            this.txtOutput1.TextChanged += new System.EventHandler(this.txtOutput1_TextChanged);
            // 
            // txtOutput0
            // 
            this.txtOutput0.Location = new System.Drawing.Point(2, 2);
            this.txtOutput0.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput0.Name = "txtOutput0";
            this.txtOutput0.ReadOnly = true;
            this.txtOutput0.Size = new System.Drawing.Size(252, 477);
            this.txtOutput0.TabIndex = 0;
            this.txtOutput0.Text = "";
            this.txtOutput0.TextChanged += new System.EventHandler(this.txtOutput0_TextChanged);
            // 
            // btnTimeHalfPlusOneAvailThread
            // 
            this.btnTimeHalfPlusOneAvailThread.Location = new System.Drawing.Point(514, 483);
            this.btnTimeHalfPlusOneAvailThread.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimeHalfPlusOneAvailThread.Name = "btnTimeHalfPlusOneAvailThread";
            this.btnTimeHalfPlusOneAvailThread.Size = new System.Drawing.Size(252, 33);
            this.btnTimeHalfPlusOneAvailThread.TabIndex = 4;
            this.btnTimeHalfPlusOneAvailThread.Text = "Run Half-Avail-PlusOne Benchmark";
            this.btnTimeHalfPlusOneAvailThread.UseVisualStyleBackColor = true;
            this.btnTimeHalfPlusOneAvailThread.Click += new System.EventHandler(this.btnTimeHalfPlusOneAvailThread_Click);
            // 
            // btnTimeSingleThread
            // 
            this.btnTimeSingleThread.Location = new System.Drawing.Point(2, 483);
            this.btnTimeSingleThread.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimeSingleThread.Name = "btnTimeSingleThread";
            this.btnTimeSingleThread.Size = new System.Drawing.Size(252, 33);
            this.btnTimeSingleThread.TabIndex = 2;
            this.btnTimeSingleThread.Text = "Run Single-Threaded Benchmark";
            this.btnTimeSingleThread.UseVisualStyleBackColor = true;
            this.btnTimeSingleThread.Click += new System.EventHandler(this.btnTimeSingleThread_Click);
            // 
            // btnTimeHalfAvailThread
            // 
            this.btnTimeHalfAvailThread.Location = new System.Drawing.Point(258, 483);
            this.btnTimeHalfAvailThread.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimeHalfAvailThread.Name = "btnTimeHalfAvailThread";
            this.btnTimeHalfAvailThread.Size = new System.Drawing.Size(252, 33);
            this.btnTimeHalfAvailThread.TabIndex = 3;
            this.btnTimeHalfAvailThread.Text = "Run Half-Available Threaded Benchmark";
            this.btnTimeHalfAvailThread.UseVisualStyleBackColor = true;
            this.btnTimeHalfAvailThread.Click += new System.EventHandler(this.btnTimeHalfAvailThread_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMinQueryValue);
            this.tabPage3.Controls.Add(this.btnMaxQueryValue);
            this.tabPage3.Controls.Add(this.btnQueryRange);
            this.tabPage3.Controls.Add(this.numUpDownMinQueryValue);
            this.tabPage3.Controls.Add(this.numUpDownMaxQueryValue);
            this.tabPage3.Controls.Add(this.btnQueryValue);
            this.tabPage3.Controls.Add(this.numUpDownQueryValue);
            this.tabPage3.Controls.Add(this.btnPQMin);
            this.tabPage3.Controls.Add(this.btnPQMax);
            this.tabPage3.Controls.Add(this.btnPQIterations);
            this.tabPage3.Controls.Add(this.btnCreateNumberTable);
            this.tabPage3.Controls.Add(this.numUpDownPQIterations);
            this.tabPage3.Controls.Add(this.txtPQConsole);
            this.tabPage3.Controls.Add(this.numUpDownPQMin);
            this.tabPage3.Controls.Add(this.numUpDownPQMax);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1034, 553);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Probability Queries";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnMinQueryValue
            // 
            this.btnMinQueryValue.Location = new System.Drawing.Point(375, 501);
            this.btnMinQueryValue.Name = "btnMinQueryValue";
            this.btnMinQueryValue.Size = new System.Drawing.Size(81, 22);
            this.btnMinQueryValue.TabIndex = 14;
            this.btnMinQueryValue.Text = "MinInclusive";
            this.btnMinQueryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinQueryValue.UseVisualStyleBackColor = true;
            this.btnMinQueryValue.Click += new System.EventHandler(this.btnMinQueryValue_Click);
            // 
            // btnMaxQueryValue
            // 
            this.btnMaxQueryValue.Location = new System.Drawing.Point(375, 475);
            this.btnMaxQueryValue.Name = "btnMaxQueryValue";
            this.btnMaxQueryValue.Size = new System.Drawing.Size(81, 20);
            this.btnMaxQueryValue.TabIndex = 13;
            this.btnMaxQueryValue.Text = "MaxInclusive";
            this.btnMaxQueryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaxQueryValue.UseVisualStyleBackColor = true;
            this.btnMaxQueryValue.Click += new System.EventHandler(this.btnMaxQueryValue_Click);
            // 
            // btnQueryRange
            // 
            this.btnQueryRange.Location = new System.Drawing.Point(375, 529);
            this.btnQueryRange.Name = "btnQueryRange";
            this.btnQueryRange.Size = new System.Drawing.Size(196, 20);
            this.btnQueryRange.TabIndex = 12;
            this.btnQueryRange.Text = "Query Frequency of Values in Range";
            this.btnQueryRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueryRange.UseVisualStyleBackColor = true;
            this.btnQueryRange.Click += new System.EventHandler(this.btnQueryRange_Click);
            // 
            // numUpDownMinQueryValue
            // 
            this.numUpDownMinQueryValue.Location = new System.Drawing.Point(462, 503);
            this.numUpDownMinQueryValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownMinQueryValue.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numUpDownMinQueryValue.Name = "numUpDownMinQueryValue";
            this.numUpDownMinQueryValue.Size = new System.Drawing.Size(109, 20);
            this.numUpDownMinQueryValue.TabIndex = 11;
            this.numUpDownMinQueryValue.ThousandsSeparator = true;
            this.numUpDownMinQueryValue.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numUpDownMaxQueryValue
            // 
            this.numUpDownMaxQueryValue.Location = new System.Drawing.Point(462, 477);
            this.numUpDownMaxQueryValue.Maximum = new decimal(new int[] {
            1000001,
            0,
            0,
            0});
            this.numUpDownMaxQueryValue.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numUpDownMaxQueryValue.Name = "numUpDownMaxQueryValue";
            this.numUpDownMaxQueryValue.Size = new System.Drawing.Size(109, 20);
            this.numUpDownMaxQueryValue.TabIndex = 10;
            this.numUpDownMaxQueryValue.ThousandsSeparator = true;
            this.numUpDownMaxQueryValue.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // btnQueryValue
            // 
            this.btnQueryValue.Location = new System.Drawing.Point(675, 501);
            this.btnQueryValue.Name = "btnQueryValue";
            this.btnQueryValue.Size = new System.Drawing.Size(108, 46);
            this.btnQueryValue.TabIndex = 9;
            this.btnQueryValue.Text = "Query Table for \r\nThis Value";
            this.btnQueryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueryValue.UseVisualStyleBackColor = true;
            this.btnQueryValue.Click += new System.EventHandler(this.btnQueryValue_Click);
            // 
            // numUpDownQueryValue
            // 
            this.numUpDownQueryValue.Location = new System.Drawing.Point(675, 475);
            this.numUpDownQueryValue.Maximum = new decimal(new int[] {
            1000001,
            0,
            0,
            0});
            this.numUpDownQueryValue.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numUpDownQueryValue.Name = "numUpDownQueryValue";
            this.numUpDownQueryValue.Size = new System.Drawing.Size(108, 20);
            this.numUpDownQueryValue.TabIndex = 8;
            this.numUpDownQueryValue.ThousandsSeparator = true;
            this.numUpDownQueryValue.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            // 
            // btnPQMin
            // 
            this.btnPQMin.Location = new System.Drawing.Point(6, 501);
            this.btnPQMin.Name = "btnPQMin";
            this.btnPQMin.Size = new System.Drawing.Size(81, 20);
            this.btnPQMin.TabIndex = 7;
            this.btnPQMin.Text = "MinInclusive";
            this.btnPQMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPQMin.UseVisualStyleBackColor = true;
            this.btnPQMin.Click += new System.EventHandler(this.btnPQMin_Click);
            // 
            // btnPQMax
            // 
            this.btnPQMax.Location = new System.Drawing.Point(6, 475);
            this.btnPQMax.Name = "btnPQMax";
            this.btnPQMax.Size = new System.Drawing.Size(81, 20);
            this.btnPQMax.TabIndex = 6;
            this.btnPQMax.Text = "MaxExclusive";
            this.btnPQMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPQMax.UseVisualStyleBackColor = true;
            this.btnPQMax.Click += new System.EventHandler(this.btnPQMax_Click);
            // 
            // btnPQIterations
            // 
            this.btnPQIterations.Location = new System.Drawing.Point(6, 527);
            this.btnPQIterations.Name = "btnPQIterations";
            this.btnPQIterations.Size = new System.Drawing.Size(81, 20);
            this.btnPQIterations.TabIndex = 5;
            this.btnPQIterations.Text = "Iterations";
            this.btnPQIterations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPQIterations.UseVisualStyleBackColor = true;
            this.btnPQIterations.Click += new System.EventHandler(this.btnPQIterations_Click);
            // 
            // btnCreateNumberTable
            // 
            this.btnCreateNumberTable.Location = new System.Drawing.Point(204, 475);
            this.btnCreateNumberTable.Name = "btnCreateNumberTable";
            this.btnCreateNumberTable.Size = new System.Drawing.Size(64, 72);
            this.btnCreateNumberTable.TabIndex = 4;
            this.btnCreateNumberTable.Text = "Create Random Number Table";
            this.btnCreateNumberTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNumberTable.UseVisualStyleBackColor = true;
            this.btnCreateNumberTable.Click += new System.EventHandler(this.btnCreateNumberTable_Click);
            // 
            // numUpDownPQIterations
            // 
            this.numUpDownPQIterations.Location = new System.Drawing.Point(93, 527);
            this.numUpDownPQIterations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownPQIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownPQIterations.Name = "numUpDownPQIterations";
            this.numUpDownPQIterations.Size = new System.Drawing.Size(105, 20);
            this.numUpDownPQIterations.TabIndex = 3;
            this.numUpDownPQIterations.ThousandsSeparator = true;
            this.numUpDownPQIterations.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // txtPQConsole
            // 
            this.txtPQConsole.Location = new System.Drawing.Point(6, 6);
            this.txtPQConsole.Name = "txtPQConsole";
            this.txtPQConsole.ReadOnly = true;
            this.txtPQConsole.Size = new System.Drawing.Size(1022, 463);
            this.txtPQConsole.TabIndex = 2;
            this.txtPQConsole.Text = "";
            // 
            // numUpDownPQMin
            // 
            this.numUpDownPQMin.Location = new System.Drawing.Point(93, 501);
            this.numUpDownPQMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownPQMin.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numUpDownPQMin.Name = "numUpDownPQMin";
            this.numUpDownPQMin.Size = new System.Drawing.Size(105, 20);
            this.numUpDownPQMin.TabIndex = 1;
            this.numUpDownPQMin.ThousandsSeparator = true;
            this.numUpDownPQMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownPQMax
            // 
            this.numUpDownPQMax.Location = new System.Drawing.Point(93, 475);
            this.numUpDownPQMax.Maximum = new decimal(new int[] {
            1000001,
            0,
            0,
            0});
            this.numUpDownPQMax.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numUpDownPQMax.Name = "numUpDownPQMax";
            this.numUpDownPQMax.Size = new System.Drawing.Size(105, 20);
            this.numUpDownPQMax.TabIndex = 0;
            this.numUpDownPQMax.ThousandsSeparator = true;
            this.numUpDownPQMax.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grpCards);
            this.tabPage4.Controls.Add(this.btnClearCanvas);
            this.tabPage4.Controls.Add(this.btnRandomWalk);
            this.tabPage4.Controls.Add(this.btnGenerateVerticalBars);
            this.tabPage4.Controls.Add(this.btnGenerateBWNoise);
            this.tabPage4.Controls.Add(this.btnGenerateRGBNoise);
            this.tabPage4.Controls.Add(this.canvasTab3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1034, 553);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Visual Representation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grpCards
            // 
            this.grpCards.Controls.Add(this.txtCardsRemaining);
            this.grpCards.Controls.Add(this.btnThrowCard);
            this.grpCards.Controls.Add(this.btnShuffleDeck);
            this.grpCards.Controls.Add(this.btnGetNewDeck);
            this.grpCards.Location = new System.Drawing.Point(6, 122);
            this.grpCards.Name = "grpCards";
            this.grpCards.Size = new System.Drawing.Size(136, 106);
            this.grpCards.TabIndex = 6;
            this.grpCards.TabStop = false;
            this.grpCards.Text = "Cards Shuffler";
            // 
            // btnShuffleDeck
            // 
            this.btnShuffleDeck.Location = new System.Drawing.Point(6, 48);
            this.btnShuffleDeck.Name = "btnShuffleDeck";
            this.btnShuffleDeck.Size = new System.Drawing.Size(124, 23);
            this.btnShuffleDeck.TabIndex = 8;
            this.btnShuffleDeck.Text = "Shuffle Current Deck";
            this.btnShuffleDeck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShuffleDeck.UseVisualStyleBackColor = true;
            this.btnShuffleDeck.Click += new System.EventHandler(this.btnShuffleDeck_Click);
            // 
            // btnGetNewDeck
            // 
            this.btnGetNewDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGetNewDeck.Location = new System.Drawing.Point(6, 19);
            this.btnGetNewDeck.Name = "btnGetNewDeck";
            this.btnGetNewDeck.Size = new System.Drawing.Size(124, 23);
            this.btnGetNewDeck.TabIndex = 7;
            this.btnGetNewDeck.Text = "New Ordered Deck";
            this.btnGetNewDeck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetNewDeck.UseVisualStyleBackColor = true;
            this.btnGetNewDeck.Click += new System.EventHandler(this.btnGetNewDeck_Click);
            // 
            // btnClearCanvas
            // 
            this.btnClearCanvas.Location = new System.Drawing.Point(6, 524);
            this.btnClearCanvas.Name = "btnClearCanvas";
            this.btnClearCanvas.Size = new System.Drawing.Size(136, 23);
            this.btnClearCanvas.TabIndex = 5;
            this.btnClearCanvas.Text = "Clear Canvas";
            this.btnClearCanvas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCanvas.UseVisualStyleBackColor = true;
            this.btnClearCanvas.Click += new System.EventHandler(this.btnClearCanvas_Click);
            // 
            // btnRandomWalk
            // 
            this.btnRandomWalk.Location = new System.Drawing.Point(6, 93);
            this.btnRandomWalk.Name = "btnRandomWalk";
            this.btnRandomWalk.Size = new System.Drawing.Size(136, 23);
            this.btnRandomWalk.TabIndex = 4;
            this.btnRandomWalk.Text = "Draw Random Walk";
            this.btnRandomWalk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandomWalk.UseVisualStyleBackColor = true;
            this.btnRandomWalk.Click += new System.EventHandler(this.btnRandomWalk_Click);
            // 
            // btnGenerateVerticalBars
            // 
            this.btnGenerateVerticalBars.Location = new System.Drawing.Point(6, 64);
            this.btnGenerateVerticalBars.Name = "btnGenerateVerticalBars";
            this.btnGenerateVerticalBars.Size = new System.Drawing.Size(136, 23);
            this.btnGenerateVerticalBars.TabIndex = 3;
            this.btnGenerateVerticalBars.Text = "Generate Vertical Bars";
            this.btnGenerateVerticalBars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateVerticalBars.UseVisualStyleBackColor = true;
            this.btnGenerateVerticalBars.Click += new System.EventHandler(this.btnGenerateVerticalBars_Click);
            // 
            // btnGenerateBWNoise
            // 
            this.btnGenerateBWNoise.Location = new System.Drawing.Point(6, 35);
            this.btnGenerateBWNoise.Name = "btnGenerateBWNoise";
            this.btnGenerateBWNoise.Size = new System.Drawing.Size(136, 23);
            this.btnGenerateBWNoise.TabIndex = 2;
            this.btnGenerateBWNoise.Text = "Generate BW Noise";
            this.btnGenerateBWNoise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateBWNoise.UseVisualStyleBackColor = true;
            this.btnGenerateBWNoise.Click += new System.EventHandler(this.btnGenerateBWNoise_Click);
            // 
            // btnGenerateRGBNoise
            // 
            this.btnGenerateRGBNoise.Location = new System.Drawing.Point(6, 6);
            this.btnGenerateRGBNoise.Name = "btnGenerateRGBNoise";
            this.btnGenerateRGBNoise.Size = new System.Drawing.Size(136, 23);
            this.btnGenerateRGBNoise.TabIndex = 1;
            this.btnGenerateRGBNoise.Text = "Generate RGB Noise";
            this.btnGenerateRGBNoise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateRGBNoise.UseVisualStyleBackColor = true;
            this.btnGenerateRGBNoise.Click += new System.EventHandler(this.btnGenerateRGBNoise_Click);
            // 
            // canvasTab3
            // 
            this.canvasTab3.Location = new System.Drawing.Point(148, 6);
            this.canvasTab3.Name = "canvasTab3";
            this.canvasTab3.Size = new System.Drawing.Size(880, 541);
            this.canvasTab3.TabIndex = 0;
            this.canvasTab3.TabStop = false;
            // 
            // btnThrowCard
            // 
            this.btnThrowCard.Location = new System.Drawing.Point(51, 77);
            this.btnThrowCard.Name = "btnThrowCard";
            this.btnThrowCard.Size = new System.Drawing.Size(79, 23);
            this.btnThrowCard.TabIndex = 9;
            this.btnThrowCard.Text = "Throw a Card";
            this.btnThrowCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThrowCard.UseVisualStyleBackColor = true;
            // 
            // txtCardsRemaining
            // 
            this.txtCardsRemaining.Location = new System.Drawing.Point(6, 79);
            this.txtCardsRemaining.Name = "txtCardsRemaining";
            this.txtCardsRemaining.ReadOnly = true;
            this.txtCardsRemaining.Size = new System.Drawing.Size(39, 20);
            this.txtCardsRemaining.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Huy Pham\'s Parallel Pseudorandom Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxU)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownIterations)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBenchIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBenchMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBenchMax)).EndInit();
            this.tableLayoutPanelTextBox.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinQueryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxQueryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQueryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPQIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPQMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPQMax)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.grpCards.ResumeLayout(false);
            this.grpCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasTab3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.Button btnNextUInteger;
        private System.Windows.Forms.Button btnNextRanged;
        private System.Windows.Forms.Button btnCurrentEntropy;
        private System.Windows.Forms.NumericUpDown numUpDownMax;
        private System.Windows.Forms.NumericUpDown numUpDownMin;
        private System.Windows.Forms.NumericUpDown numUpDownMaxU;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnUMax;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTextBox;
        private System.Windows.Forms.RichTextBox txtOutput3;
        private System.Windows.Forms.RichTextBox txtOutput2;
        private System.Windows.Forms.RichTextBox txtOutput1;
        private System.Windows.Forms.RichTextBox txtOutput0;
        private System.Windows.Forms.Button btnTimeHalfAvailThread;
        private System.Windows.Forms.Button btnTimeSingleThread;
        private System.Windows.Forms.Button btnTimeFullThread;
        private System.Windows.Forms.Button btnTimeHalfPlusOneAvailThread;
        private System.Windows.Forms.Button btnMaxIterations;
        private System.Windows.Forms.NumericUpDown numUpDownIterations;
        private System.Windows.Forms.Button btnBenchIterations;
        private System.Windows.Forms.NumericUpDown numUpDownBenchIterations;
        private System.Windows.Forms.Button btnBenchMin;
        private System.Windows.Forms.NumericUpDown numUpDownBenchMin;
        private System.Windows.Forms.NumericUpDown numUpDownBenchMax;
        private System.Windows.Forms.Button btnBenchMax;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox canvasTab3;
        private System.Windows.Forms.Button btnGenerateRGBNoise;
        private System.Windows.Forms.Button btnGenerateBWNoise;
        private System.Windows.Forms.Button btnGenerateVerticalBars;
        private System.Windows.Forms.Button btnRandomWalk;
        private System.Windows.Forms.Button btnClearCanvas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numUpDownPQMax;
        private System.Windows.Forms.Button btnPQMin;
        private System.Windows.Forms.Button btnPQMax;
        private System.Windows.Forms.Button btnPQIterations;
        private System.Windows.Forms.Button btnCreateNumberTable;
        private System.Windows.Forms.NumericUpDown numUpDownPQIterations;
        private System.Windows.Forms.RichTextBox txtPQConsole;
        private System.Windows.Forms.NumericUpDown numUpDownPQMin;
        private System.Windows.Forms.Button btnQueryRange;
        private System.Windows.Forms.NumericUpDown numUpDownMinQueryValue;
        private System.Windows.Forms.NumericUpDown numUpDownMaxQueryValue;
        private System.Windows.Forms.Button btnQueryValue;
        private System.Windows.Forms.NumericUpDown numUpDownQueryValue;
        private System.Windows.Forms.Button btnMinQueryValue;
        private System.Windows.Forms.Button btnMaxQueryValue;
        private System.Windows.Forms.GroupBox grpCards;
        private System.Windows.Forms.Button btnShuffleDeck;
        private System.Windows.Forms.Button btnGetNewDeck;
        private System.Windows.Forms.Button btnThrowCard;
        private System.Windows.Forms.TextBox txtCardsRemaining;
    }
}

