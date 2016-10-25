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
        PRNG prng = new PRNG();

        HashAlgorithm sha512 = new SHA512Managed();
        HashAlgorithm sha256 = new SHA256Managed();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BigInteger seed = new BigInteger(prng.HashedSeedByte);

            txtConsole.Text += "Original Seed: " + seed + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger randomNext = prng.NextUInteger(1000000000);
            txtConsole.Text += "Random Value: " + randomNext + "\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BigInteger randomRange = prng.Next(-5, 5);
            txtConsole.Text += "Random Value: " + randomRange + "\n";
        }
    }
}
