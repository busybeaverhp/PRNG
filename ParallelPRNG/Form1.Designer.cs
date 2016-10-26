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
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxU)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(12, 12);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(1011, 462);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(12, 480);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(224, 23);
            this.btnSeed.TabIndex = 1;
            this.btnSeed.Text = "Display Original Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // btnNextUInteger
            // 
            this.btnNextUInteger.Location = new System.Drawing.Point(836, 480);
            this.btnNextUInteger.Name = "btnNextUInteger";
            this.btnNextUInteger.Size = new System.Drawing.Size(147, 23);
            this.btnNextUInteger.TabIndex = 2;
            this.btnNextUInteger.Text = "Next UInteger";
            this.btnNextUInteger.UseVisualStyleBackColor = true;
            this.btnNextUInteger.Click += new System.EventHandler(this.btnNextUInteger_Click);
            // 
            // btnNextRanged
            // 
            this.btnNextRanged.Location = new System.Drawing.Point(462, 480);
            this.btnNextRanged.Name = "btnNextRanged";
            this.btnNextRanged.Size = new System.Drawing.Size(125, 52);
            this.btnNextRanged.TabIndex = 3;
            this.btnNextRanged.Text = "Next Ranged";
            this.btnNextRanged.UseVisualStyleBackColor = true;
            this.btnNextRanged.Click += new System.EventHandler(this.btnNextRanged_Click);
            // 
            // btnCurrentEntropy
            // 
            this.btnCurrentEntropy.Location = new System.Drawing.Point(12, 509);
            this.btnCurrentEntropy.Name = "btnCurrentEntropy";
            this.btnCurrentEntropy.Size = new System.Drawing.Size(224, 23);
            this.btnCurrentEntropy.TabIndex = 5;
            this.btnCurrentEntropy.Text = "Display Current Entropy Value";
            this.btnCurrentEntropy.UseVisualStyleBackColor = true;
            this.btnCurrentEntropy.Click += new System.EventHandler(this.btnCurrentEntropy_Click);
            // 
            // numUpDownMax
            // 
            this.numUpDownMax.Location = new System.Drawing.Point(336, 483);
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
            this.numUpDownMax.Size = new System.Drawing.Size(120, 20);
            this.numUpDownMax.TabIndex = 8;
            this.numUpDownMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numUpDownMin
            // 
            this.numUpDownMin.Location = new System.Drawing.Point(336, 509);
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
            this.numUpDownMin.Size = new System.Drawing.Size(120, 20);
            this.numUpDownMin.TabIndex = 9;
            // 
            // numUpDownMaxU
            // 
            this.numUpDownMaxU.Location = new System.Drawing.Point(710, 483);
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
            this.numUpDownMaxU.Size = new System.Drawing.Size(120, 20);
            this.numUpDownMaxU.TabIndex = 10;
            this.numUpDownMaxU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(266, 483);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(64, 20);
            this.btnMax.TabIndex = 11;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(266, 509);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(64, 20);
            this.btnMin.TabIndex = 12;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnUMax
            // 
            this.btnUMax.Location = new System.Drawing.Point(640, 483);
            this.btnUMax.Name = "btnUMax";
            this.btnUMax.Size = new System.Drawing.Size(64, 20);
            this.btnUMax.TabIndex = 13;
            this.btnUMax.Text = "Max";
            this.btnUMax.UseVisualStyleBackColor = true;
            this.btnUMax.Click += new System.EventHandler(this.btnUMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 601);
            this.Controls.Add(this.btnUMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.numUpDownMaxU);
            this.Controls.Add(this.numUpDownMin);
            this.Controls.Add(this.numUpDownMax);
            this.Controls.Add(this.btnCurrentEntropy);
            this.Controls.Add(this.btnNextRanged);
            this.Controls.Add(this.btnNextUInteger);
            this.Controls.Add(this.btnSeed);
            this.Controls.Add(this.txtConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxU)).EndInit();
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
    }
}

