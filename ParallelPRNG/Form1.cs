using ParallelRandomClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelPRNG
{
    public partial class Form1 : Form
    {
        PRNG prng;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prng = new PRNG("Huy's Parallel PRNG Class");
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            BigInteger seed = new BigInteger(prng.HashedSeedByte);
            txtConsole.Text += "Original Seed: " + seed + "\n";
        }

        private void btnCurrentEntropy_Click(object sender, EventArgs e)
        {
            BigInteger currentEntropy = new BigInteger(prng.CurrentEntropyHash);
            txtConsole.Text += "Current Seed: " + currentEntropy + "\n";
        }

        private void btnNextUInteger_Click(object sender, EventArgs e)
        {
            BigInteger randomNext = prng.NextUInteger(new BigInteger(numUpDownMaxU.Value));
            txtConsole.Text += "Random Value: " + randomNext + "\n";
        }

        private void btnNextRanged_Click(object sender, EventArgs e)
        {
            BigInteger randomRange = prng.Next(new BigInteger(numUpDownMin.Value), new BigInteger(numUpDownMax.Value));
            txtConsole.Text += "Random Value: " + randomRange + "\n";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            numUpDownMax.Value = numUpDownMax.Maximum;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            numUpDownMin.Value = numUpDownMin.Minimum;
        }

        private void btnUMax_Click(object sender, EventArgs e)
        {
            numUpDownMaxU.Value = numUpDownMaxU.Maximum;
        }
    }
}
