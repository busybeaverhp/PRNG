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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTextBox = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTimeFullThread = new System.Windows.Forms.Button();
            this.txtOutput0 = new System.Windows.Forms.RichTextBox();
            this.btnTimeSingleThread = new System.Windows.Forms.Button();
            this.txtOutput1 = new System.Windows.Forms.RichTextBox();
            this.txtOutput3 = new System.Windows.Forms.RichTextBox();
            this.txtOutput2 = new System.Windows.Forms.RichTextBox();
            this.btnTimeHalf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxU)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanelTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(7, 7);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(1356, 506);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(7, 616);
            this.btnSeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(299, 28);
            this.btnSeed.TabIndex = 1;
            this.btnSeed.Text = "Display Original Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // btnNextUInteger
            // 
            this.btnNextUInteger.Location = new System.Drawing.Point(1116, 616);
            this.btnNextUInteger.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextUInteger.Name = "btnNextUInteger";
            this.btnNextUInteger.Size = new System.Drawing.Size(196, 28);
            this.btnNextUInteger.TabIndex = 2;
            this.btnNextUInteger.Text = "Next UInteger";
            this.btnNextUInteger.UseVisualStyleBackColor = true;
            this.btnNextUInteger.Click += new System.EventHandler(this.btnNextUInteger_Click);
            // 
            // btnNextRanged
            // 
            this.btnNextRanged.Location = new System.Drawing.Point(643, 616);
            this.btnNextRanged.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextRanged.Name = "btnNextRanged";
            this.btnNextRanged.Size = new System.Drawing.Size(167, 64);
            this.btnNextRanged.TabIndex = 3;
            this.btnNextRanged.Text = "Next Ranged";
            this.btnNextRanged.UseVisualStyleBackColor = true;
            this.btnNextRanged.Click += new System.EventHandler(this.btnNextRanged_Click);
            // 
            // btnCurrentEntropy
            // 
            this.btnCurrentEntropy.Location = new System.Drawing.Point(7, 652);
            this.btnCurrentEntropy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCurrentEntropy.Name = "btnCurrentEntropy";
            this.btnCurrentEntropy.Size = new System.Drawing.Size(299, 28);
            this.btnCurrentEntropy.TabIndex = 5;
            this.btnCurrentEntropy.Text = "Display Current Entropy Value";
            this.btnCurrentEntropy.UseVisualStyleBackColor = true;
            this.btnCurrentEntropy.Click += new System.EventHandler(this.btnCurrentEntropy_Click);
            // 
            // numUpDownMax
            // 
            this.numUpDownMax.Location = new System.Drawing.Point(475, 631);
            this.numUpDownMax.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownMax.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownMax.Name = "numUpDownMax";
            this.numUpDownMax.Size = new System.Drawing.Size(160, 22);
            this.numUpDownMax.TabIndex = 8;
            this.numUpDownMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numUpDownMin
            // 
            this.numUpDownMin.Location = new System.Drawing.Point(475, 661);
            this.numUpDownMin.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numUpDownMin.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.numUpDownMin.Name = "numUpDownMin";
            this.numUpDownMin.Size = new System.Drawing.Size(160, 22);
            this.numUpDownMin.TabIndex = 9;
            // 
            // numUpDownMaxU
            // 
            this.numUpDownMaxU.Location = new System.Drawing.Point(926, 629);
            this.numUpDownMaxU.Margin = new System.Windows.Forms.Padding(4);
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
            this.numUpDownMaxU.Size = new System.Drawing.Size(160, 22);
            this.numUpDownMaxU.TabIndex = 10;
            this.numUpDownMaxU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(371, 601);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(85, 25);
            this.btnMax.TabIndex = 11;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(371, 652);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(85, 25);
            this.btnMin.TabIndex = 12;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnUMax
            // 
            this.btnUMax.Location = new System.Drawing.Point(833, 629);
            this.btnUMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnUMax.Name = "btnUMax";
            this.btnUMax.Size = new System.Drawing.Size(85, 25);
            this.btnUMax.TabIndex = 13;
            this.btnUMax.Text = "Max";
            this.btnUMax.UseVisualStyleBackColor = true;
            this.btnUMax.Click += new System.EventHandler(this.btnUMax_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1378, 716);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1370, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanelTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1370, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTextBox
            // 
            this.tableLayoutPanelTextBox.ColumnCount = 4;
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTextBox.Controls.Add(this.button2, 3, 1);
            this.tableLayoutPanelTextBox.Controls.Add(this.txtOutput3, 3, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.txtOutput2, 2, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.txtOutput1, 1, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.txtOutput0, 0, 0);
            this.tableLayoutPanelTextBox.Controls.Add(this.btnTimeHalf, 2, 1);
            this.tableLayoutPanelTextBox.Controls.Add(this.btnTimeFullThread, 1, 1);
            this.tableLayoutPanelTextBox.Controls.Add(this.btnTimeSingleThread, 0, 1);
            this.tableLayoutPanelTextBox.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanelTextBox.Name = "tableLayoutPanelTextBox";
            this.tableLayoutPanelTextBox.RowCount = 2;
            this.tableLayoutPanelTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTextBox.Size = new System.Drawing.Size(1358, 486);
            this.tableLayoutPanelTextBox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1020, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 237);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnTimeFullThread
            // 
            this.btnTimeFullThread.Location = new System.Drawing.Point(342, 246);
            this.btnTimeFullThread.Name = "btnTimeFullThread";
            this.btnTimeFullThread.Size = new System.Drawing.Size(333, 237);
            this.btnTimeFullThread.TabIndex = 3;
            this.btnTimeFullThread.Text = "button2";
            this.btnTimeFullThread.UseVisualStyleBackColor = true;
            this.btnTimeFullThread.Click += new System.EventHandler(this.btnTimeFullThread_Click);
            // 
            // txtOutput0
            // 
            this.txtOutput0.Location = new System.Drawing.Point(3, 3);
            this.txtOutput0.Name = "txtOutput0";
            this.txtOutput0.Size = new System.Drawing.Size(333, 237);
            this.txtOutput0.TabIndex = 0;
            this.txtOutput0.Text = "";
            // 
            // btnTimeSingleThread
            // 
            this.btnTimeSingleThread.Location = new System.Drawing.Point(3, 246);
            this.btnTimeSingleThread.Name = "btnTimeSingleThread";
            this.btnTimeSingleThread.Size = new System.Drawing.Size(333, 237);
            this.btnTimeSingleThread.TabIndex = 2;
            this.btnTimeSingleThread.Text = "button1";
            this.btnTimeSingleThread.UseVisualStyleBackColor = true;
            this.btnTimeSingleThread.Click += new System.EventHandler(this.btnTimeSingleThread_Click);
            // 
            // txtOutput1
            // 
            this.txtOutput1.Location = new System.Drawing.Point(342, 3);
            this.txtOutput1.Name = "txtOutput1";
            this.txtOutput1.Size = new System.Drawing.Size(333, 237);
            this.txtOutput1.TabIndex = 1;
            this.txtOutput1.Text = "";
            // 
            // txtOutput3
            // 
            this.txtOutput3.Location = new System.Drawing.Point(1020, 3);
            this.txtOutput3.Name = "txtOutput3";
            this.txtOutput3.Size = new System.Drawing.Size(335, 237);
            this.txtOutput3.TabIndex = 3;
            this.txtOutput3.Text = "";
            // 
            // txtOutput2
            // 
            this.txtOutput2.Location = new System.Drawing.Point(681, 3);
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.Size = new System.Drawing.Size(333, 237);
            this.txtOutput2.TabIndex = 2;
            this.txtOutput2.Text = "";
            // 
            // btnTimeHalf
            // 
            this.btnTimeHalf.Location = new System.Drawing.Point(681, 246);
            this.btnTimeHalf.Name = "btnTimeHalf";
            this.btnTimeHalf.Size = new System.Drawing.Size(333, 237);
            this.btnTimeHalf.TabIndex = 4;
            this.btnTimeHalf.Text = "btnTimeHalfThread";
            this.btnTimeHalf.UseVisualStyleBackColor = true;
            this.btnTimeHalf.Click += new System.EventHandler(this.btnTimeHalf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 740);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxU)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanelTextBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnTimeFullThread;
        private System.Windows.Forms.Button btnTimeSingleThread;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTimeHalf;
    }
}

