using ParallelRandomClassLib;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        PPRNG pprng;
        RichTextBox[] txtOutputArray = new RichTextBox[4];
        ConcurrentBag<BigInteger> concurrentBagOfIntegers;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prng = new PRNG("Huy's Parallel PRNG Class");
            pprng = new PPRNG();

            txtOutputArray[0] = (RichTextBox)txtOutput0;
            txtOutputArray[1] = (RichTextBox)txtOutput1;
            txtOutputArray[2] = (RichTextBox)txtOutput2;
            txtOutputArray[3] = (RichTextBox)txtOutput3;
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

        private void btnTimeSingleThread_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            List<BigInteger> singleList = new List<BigInteger>(prng.GenerateListOfEntropyValuesBigInteger(0, 100, 1000000));
            stopwatch.Stop();

            string output = "";

            //foreach (BigInteger number in singleList)
            //{
            //    output += number;
            //}

            txtOutput0.Text += output + "\n";
            txtOutput0.Text += stopwatch.Elapsed;

        }

        private void btnTimeFullThread_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            pprng.GenerateDesiredQuantityOfRandomIntegers(DesiredCPUUtilization.AllThreads, 1000000, 0, 100);
            stopwatch.Stop();

            ConcurrentBag<BigInteger> bagOfIntegers = pprng.GetBagOfRandomIntegers;

            string output = "";

            //foreach (BigInteger number in bagOfIntegers)
            //{
            //    output += number;
            //}

            txtOutput1.Text += output + "\n";
            txtOutput1.Text += stopwatch.Elapsed;
        }

        private void btnTimeHalf_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            pprng.GenerateDesiredQuantityOfRandomIntegers(DesiredCPUUtilization.HalfAvailThreads, 1000000, 0, 100);
            stopwatch.Stop();

            ConcurrentBag<BigInteger> bagOfIntegers = pprng.GetBagOfRandomIntegers;

            string output = "";

            //foreach (BigInteger number in bagOfIntegers)
            //{
            //    output += number;
            //}

            txtOutput2.Text += output + "\n";
            txtOutput2.Text += stopwatch.Elapsed;
        }
    }
}
