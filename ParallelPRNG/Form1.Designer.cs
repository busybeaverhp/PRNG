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
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Location = new System.Drawing.Point(12, 12);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(971, 462);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(423, 480);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(75, 23);
            this.btnSeed.TabIndex = 1;
            this.btnSeed.Text = "Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnNextUInteger
            // 
            this.btnNextUInteger.Location = new System.Drawing.Point(504, 480);
            this.btnNextUInteger.Name = "btnNextUInteger";
            this.btnNextUInteger.Size = new System.Drawing.Size(147, 23);
            this.btnNextUInteger.TabIndex = 2;
            this.btnNextUInteger.Text = "Next UInteger";
            this.btnNextUInteger.UseVisualStyleBackColor = true;
            this.btnNextUInteger.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNextRanged
            // 
            this.btnNextRanged.Location = new System.Drawing.Point(12, 480);
            this.btnNextRanged.Name = "btnNextRanged";
            this.btnNextRanged.Size = new System.Drawing.Size(125, 23);
            this.btnNextRanged.TabIndex = 3;
            this.btnNextRanged.Text = "Next Ranged";
            this.btnNextRanged.UseVisualStyleBackColor = true;
            this.btnNextRanged.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 601);
            this.Controls.Add(this.btnNextRanged);
            this.Controls.Add(this.btnNextUInteger);
            this.Controls.Add(this.btnSeed);
            this.Controls.Add(this.txtConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.Button btnNextUInteger;
        private System.Windows.Forms.Button btnNextRanged;
    }
}

