using ParallelRandomClassLib;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        Bitmap bmap;
        Graphics g;

        List<BigInteger> bigIntegerList = new List<BigInteger>();
        int[,] histogramMatrix;

        List<int> currentListOfCardIndexes;
        
        public Form1()
        {
            InitializeComponent();

            bmap = new Bitmap(canvasTab3.Width, canvasTab3.Height);
            g = Graphics.FromImage(bmap);

            float dx = bmap.Width * 0F;
            float dy = bmap.Height * 1F;

            Matrix matrix = new Matrix(1, 0, 0, -1, dx, dy);
            g.Transform = matrix;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prng = new PRNG("Huy's Parallel PRNG Class");
            pprng = new PPRNG();

            txtOutputArray[0] = (RichTextBox)txtOutput0;
            txtOutputArray[1] = (RichTextBox)txtOutput1;
            txtOutputArray[2] = (RichTextBox)txtOutput2;
            txtOutputArray[3] = (RichTextBox)txtOutput3;

            IEnumerable<int> newCardDeck = Enumerable.Range(1, 52);
            currentListOfCardIndexes = new List<int>(newCardDeck);
            txtCardsRemaining.Text = "R: " + currentListOfCardIndexes.Count;

            int histogramDimension = Math.Min(canvasTab3.Width, canvasTab3.Height);
            numUpDownX.Value = histogramDimension;
            numUpDownX.Maximum = canvasTab3.Width;
            numUpDownY.Value = histogramDimension;
            numUpDownY.Maximum = canvasTab3.Height;
            numUpDownPoints.Value = histogramDimension * histogramDimension;

            DisplayAboutText();
        }

        #region TAB1 INDEX-TRIGGERS

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            txtConsole.SelectionStart = txtConsole.Text.Length;
            txtConsole.ScrollToCaret();
        }

        private void txtConsole_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtConsole.Clear();
        }

        #endregion

        #region TAB1 BUTTONS

        private void btnNextRanged_Click(object sender, EventArgs e)
        {
            BigInteger min = new BigInteger(numUpDownMin.Value);
            BigInteger max = new BigInteger(numUpDownMax.Value);

            if (min <= max)
            {
                int iterations = Int32.Parse(numUpDownIterations.Value.ToString());
                List<BigInteger> randomValuesList = new List<BigInteger>(prng.GenerateListOfEntropyValuesBigInteger(min, max, iterations));

                string[] stringArray = randomValuesList.Select(i => i.ToString()).ToArray();
                string delimiter;

                switch (cboDelimiter.Text)
                {
                    case "Comma Delimiter":
                        delimiter = ", ";
                        break;
                    case "Space Delimiter":
                        delimiter = " ";
                        break;
                    case "Semi-Colon Delimiter":
                        delimiter = "; ";
                        break;
                    default:
                        delimiter = " ";
                        break;
                }

                string blockOfValues;
                blockOfValues = String.Join(delimiter, stringArray.Select(i => i.ToString()));

                txtConsole.Text += blockOfValues + " ";
            }
            else
            {
                MessageBox.Show("You cannot set the min value higher than the max value. Try again.");
            } 
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            numUpDownMax.Value = numUpDownMax.Maximum;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            numUpDownMin.Value = numUpDownMin.Minimum;
        }

        private void btnMaxIterations_Click(object sender, EventArgs e)
        {
            numUpDownIterations.Value = numUpDownIterations.Maximum;
        }

        #endregion

        #region TAB2 INDEX-TRIGGERS

        private void txtOutput0_TextChanged(object sender, EventArgs e)
        {
            txtOutput0.SelectionStart = txtOutput0.Text.Length;
            txtOutput0.ScrollToCaret();
        }

        private void txtOutput1_TextChanged(object sender, EventArgs e)
        {
            txtOutput1.SelectionStart = txtOutput1.Text.Length;
            txtOutput1.ScrollToCaret();
        }

        private void txtOutput2_TextChanged(object sender, EventArgs e)
        {
            txtOutput2.SelectionStart = txtOutput2.Text.Length;
            txtOutput2.ScrollToCaret();
        }

        private void txtOutput3_TextChanged(object sender, EventArgs e)
        {
            txtOutput3.SelectionStart = txtOutput3.Text.Length;
            txtOutput3.ScrollToCaret();
        }

        #endregion

        #region TAB2 BUTTONS

        private void btnBenchMax_Click(object sender, EventArgs e)
        {
            numUpDownBenchMax.Value = numUpDownBenchMax.Maximum;
        }

        private void btnBenchMin_Click(object sender, EventArgs e)
        {
            numUpDownBenchMin.Value = numUpDownBenchMin.Minimum;
        }

        private void btnBenchIterations_Click(object sender, EventArgs e)
        {
            numUpDownBenchIterations.Value = numUpDownBenchIterations.Maximum;
        }

        private void btnTimeSingleThread_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            int iterations = (int)numUpDownBenchIterations.Value;
            BigInteger min = (BigInteger)numUpDownBenchMin.Value;
            BigInteger max = (BigInteger)numUpDownBenchMax.Value;

            stopwatch.Start();
            List<BigInteger> bigIntegerList = new List<BigInteger>(prng.GenerateListOfEntropyValuesBigInteger(min, max, iterations));
            stopwatch.Stop();

            stopwatch2.Start();
            List<byte[]> byteArraylist = new List<byte[]>(prng.GenerateListOfEntropy32ByteArrays(iterations));
            stopwatch2.Stop();

            decimal byteArraysPerSec = ((decimal)iterations * 1000m) / (decimal)stopwatch.ElapsedMilliseconds;
            decimal integersPerSec = ((decimal)iterations * 1000m) / (decimal)stopwatch2.ElapsedMilliseconds;

            txtOutput0.Text += "Single Threaded PRNG Finished" + "\n";
            txtOutput0.Text += "Maximum Threads: " + ThreadUsage(DesiredCPUUtilization.SingleThread) + "\n";
            txtOutput0.Text += "Iterations: " + bigIntegerList.Count.ToString("N0") + "\n";
            txtOutput0.Text += "Min Range: " + min.ToString("N0") + "\n";
            txtOutput0.Text += "Max Range: " + (max - 1).ToString("N0") + "\n\n";
            txtOutput0.Text += "32-Byte Array: " + stopwatch.Elapsed + "\n";
            txtOutput0.Text += "32-Byte Arrays per Sec: " + byteArraysPerSec.ToString("N0") + "\n\n";
            txtOutput0.Text += "BigInteger: " + stopwatch2.Elapsed + "\n";
            txtOutput0.Text += "BigIntegers per Sec: " + integersPerSec.ToString("N0") + "\n\n";
            txtOutput0.Text += "--- --- --- \n\n";
        }

        private void btnTimeHalfAvailThread_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            int iterations = (int)numUpDownBenchIterations.Value;
            BigInteger min = (BigInteger)numUpDownBenchMin.Value;
            BigInteger max = (BigInteger)numUpDownBenchMax.Value;

            stopwatch.Start();
            pprng.GenerateDesiredQuantityOfRandom32ByteArrays("Huy's PPRNG", DesiredCPUUtilization.HalfAvailThreads, iterations);
            stopwatch.Stop();

            stopwatch2.Start();
            pprng.GenerateDesiredQuantityOfRandomIntegers("Huy's PPRNG", DesiredCPUUtilization.HalfAvailThreads, iterations, min, max);
            stopwatch2.Stop();

            ConcurrentBag<BigInteger> bagOfBigIntegers = pprng.GetBagOfRandomIntegers;

            decimal byteArraysPerSec = ((decimal)iterations * 1000m) / (decimal)stopwatch.ElapsedMilliseconds;
            decimal integersPerSec = ((decimal)iterations * 1000m) / (decimal)stopwatch2.ElapsedMilliseconds;

            txtOutput1.Text += "Half-Available Threaded PRNG Finished" + "\n";
            txtOutput1.Text += "Maximum Threads: " + ThreadUsage(DesiredCPUUtilization.HalfAvailThreads) + "\n";
            txtOutput1.Text += "Iterations: " + bagOfBigIntegers.Count.ToString("N0") + "\n";
            txtOutput1.Text += "Min Range: " + min.ToString("N0") + "\n";
            txtOutput1.Text += "Max Range: " + (max - 1).ToString("N0") + "\n\n";
            txtOutput1.Text += "32-Byte Array: " + stopwatch.Elapsed + "\n";
            txtOutput1.Text += "32-Byte Arrays per Sec: " + byteArraysPerSec.ToString("N0") + "\n\n";
            txtOutput1.Text += "BigInteger: " + stopwatch2.Elapsed + "\n";
            txtOutput1.Text += "BigIntegers per Sec: " + integersPerSec.ToString("N0") + "\n\n";
            txtOutput1.Text += "--- --- --- \n\n";
        }

        private void btnTimeHalfPlusOneAvailThread_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            int iterations = (int)numUpDownBenchIterations.Value;
            BigInteger min = (BigInteger)numUpDownBenchMin.Value;
            BigInteger max = (BigInteger)numUpDownBenchMax.Value;

            stopwatch.Start();
            pprng.GenerateDesiredQuantityOfRandom32ByteArrays("Huy's PPRNG", DesiredCPUUtilization.HalfAvailPlusOneThread, iterations);
            stopwatch.Stop();

            stopwatch2.Start();
            pprng.GenerateDesiredQuantityOfRandomIntegers("Huy's PPRNG", DesiredCPUUtilization.HalfAvailPlusOneThread, iterations, min, max);
            stopwatch2.Stop();

            ConcurrentBag<BigInteger> bagOfBigIntegers = pprng.GetBagOfRandomIntegers;

            decimal byteArraysPerSec = ((decimal)iterations * 1000m) / (decimal)stopwatch.ElapsedMilliseconds;
            decimal integersPerSec = ((decimal)iterations * 1000m) / (decimal)stopwatch2.ElapsedMilliseconds;

            txtOutput2.Text += "Half-Available-Plus-One PRNG Finished" + "\n";
            txtOutput2.Text += "Maximum Threads: " + ThreadUsage(DesiredCPUUtilization.HalfAvailPlusOneThread) + "\n";
            txtOutput2.Text += "Iterations: " + bagOfBigIntegers.Count.ToString("N0") + "\n";
            txtOutput2.Text += "Min Range: " + min.ToString("N0") + "\n";
            txtOutput2.Text += "Max Range: " + (max - 1).ToString("N0") + "\n\n";
            txtOutput2.Text += "32-Byte Array: " + stopwatch.Elapsed + "\n";
            txtOutput2.Text += "32-Byte Arrays per Sec: " + byteArraysPerSec.ToString("N0") + "\n\n";
            txtOutput2.Text += "BigInteger: " + stopwatch2.Elapsed + "\n";
            txtOutput2.Text += "BigIntegers per Sec: " + integersPerSec.ToString("N0") + "\n\n";
            txtOutput2.Text += "--- --- --- \n\n";
        }

        private void btnTimeFullThread_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            int iterations = (int)numUpDownBenchIterations.Value;
            BigInteger min = (BigInteger)numUpDownBenchMin.Value;
            BigInteger max = (BigInteger)numUpDownBenchMax.Value;

            stopwatch.Start();
            pprng.GenerateDesiredQuantityOfRandom32ByteArrays("Huy's PPRNG", DesiredCPUUtilization.AllThreads, iterations);
            stopwatch.Stop();

            stopwatch2.Start();
            pprng.GenerateDesiredQuantityOfRandomIntegers("Huy's PPRNG", DesiredCPUUtilization.AllThreads, iterations, min, max);
            stopwatch2.Stop();

            ConcurrentBag<BigInteger> bagOfBigIntegers = pprng.GetBagOfRandomIntegers;

            decimal byteArraysPerSec = ((decimal)iterations * 1000m) / (decimal)stopwatch.ElapsedMilliseconds;
            decimal integersPerSec = ((decimal)iterations * 1000m) / (decimal)stopwatch2.ElapsedMilliseconds;

            txtOutput3.Text += "All-Threaded PRNG Finished" + "\n";
            txtOutput3.Text += "Maximum Threads: " + ThreadUsage(DesiredCPUUtilization.AllThreads) + "\n";
            txtOutput3.Text += "Iterations: " + bagOfBigIntegers.Count.ToString("N0") + "\n";
            txtOutput3.Text += "Min Range: " + min.ToString("N0") + "\n";
            txtOutput3.Text += "Max Range: " + (max - 1).ToString("N0") + "\n\n";
            txtOutput3.Text += "32-Byte Array: " + stopwatch.Elapsed + "\n";
            txtOutput3.Text += "32-Byte Arrays per Sec: " + byteArraysPerSec.ToString("N0") + "\n\n";
            txtOutput3.Text += "BigInteger: " + stopwatch2.Elapsed + "\n";
            txtOutput3.Text += "BigIntegers per Sec: " + integersPerSec.ToString("N0") + "\n\n";
            txtOutput3.Text += "--- --- --- \n\n";
        }

        #endregion

        #region TAB3 BUTTONS

        private void btnPQMax_Click(object sender, EventArgs e)
        {
            numUpDownPQMax.Value = numUpDownPQMax.Maximum;
        }

        private void btnPQMin_Click(object sender, EventArgs e)
        {
            numUpDownPQMin.Value = numUpDownPQMin.Minimum;
        }

        private void btnPQIterations_Click(object sender, EventArgs e)
        {
            numUpDownPQIterations.Value = numUpDownPQIterations.Maximum;
        }

        private void btnCreateNumberTable_Click(object sender, EventArgs e)
        {
            BigInteger max = BigInteger.Parse(numUpDownPQMax.Value.ToString());
            BigInteger min = BigInteger.Parse(numUpDownPQMin.Value.ToString());
            int iterations = (int)numUpDownPQIterations.Value;

            if (min <= max)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                PPRNG pprngQ = new PPRNG();
                pprngQ.GenerateDesiredQuantityOfRandomIntegers("Huy's PPRNG", DesiredCPUUtilization.AllThreads, iterations, min, max);
                bigIntegerList = new List<BigInteger>(pprngQ.GetBagOfRandomIntegers.ToArray());

                stopwatch.Stop();

                var uniqueValues = bigIntegerList.Distinct().ToArray();

                string tempString = "\n" + "--- --- ---" + "\n\n" +
                    "New Random Number Table Created: " + bigIntegerList.Count.ToString("N0") + " numbers, with " + uniqueValues.Count().ToString("N0") + " unique values ranging from " + bigIntegerList.Min().ToString("N0") + " (inclusive) to " + bigIntegerList.Max().ToString("N0") + " (inclusive), " +
                    Environment.ProcessorCount + " threads used, " + stopwatch.Elapsed.ToString();
                PQConsoleWriteLine(tempString);

                // The following tests the actual distribution of empty slots versus the theoretical poisson predictions. HQP 2016-12-03.

                double predictedEmptySlots = Math.Round(PoissonProbability(((double)iterations / (double)(max - min)), 0) * (double)(max - min));
                double actualEmptySlots = (double)(max - min) - uniqueValues.Count();
                double accuracy = 100 - Math.Abs((actualEmptySlots - predictedEmptySlots) / predictedEmptySlots) * 100;

                tempString = "Poisson Prediction of Empty Slots: " + predictedEmptySlots.ToString("N0") + "... " +
                                "Actual Empty Slots: " + actualEmptySlots.ToString("N0") + "... " +
                                "Accuracy to Prediction: " + accuracy + "%";

                PQConsoleWriteLine(tempString);

                // The following tests the actual non-colliding values versus the theoretical poisson predictions.

                List<double> doubleList = new List<double>();

                foreach (BigInteger number in bigIntegerList)
                    doubleList.Add((double)number);

                double predictionCollisionProbability = PoissonBirthdayCollisionProbablity((int)(max - min), bigIntegerList.Count()) * 100;

                double predictedCollisions = Math.Round(
                                                (1 - PoissonProbability(((double)iterations / (double)(max - min)), 0) 
                                                - PoissonProbability(((double)iterations / (double)(max - min)), 1))
                                                * (double)(max - min)
                                                );

                double actualCollisions = uniqueValues.Count() - CalculateSingularFrequencyCount(doubleList);

                double collisionAccuracy = 100 - Math.Abs((actualCollisions - predictedCollisions) / predictedCollisions) * 100;

                tempString = "Poisson Prediction of Colliding Values... Probability: " + predictionCollisionProbability.ToString() + 
                                "% with " + predictedCollisions.ToString("N0") + " Collisions... " +
                                "Actual Collision Count: " + actualCollisions.ToString("N0") + "... " +
                                "Accuracy to Prediction: " + collisionAccuracy + "%";

                PQConsoleWriteLine(tempString);

                // The following measures the mean, median, and standard deviation of the value set. HQP 2016-12-03.

                double avg = doubleList.Average();
                double median = CalculateMedian(doubleList);
                double standardDeviation = CalculateStandardDeviation(doubleList);

                // The following measure what I call non-zero modal frequency. 
                // Technical explanation above "CalculateNonZeroModalFrequency(IEnumerable<double> valueList)." HQP 2016-12-04.

                int nonZeroModalFrequency = 0;
                int nonZeroModalCount = 0;
                CalculateNonZeroModalFrequency(doubleList, out nonZeroModalFrequency, out nonZeroModalCount);

                tempString = "Non-Zero Modal Frequency: " + nonZeroModalCount.ToString() + " value(s) have occurence(s) of " + nonZeroModalFrequency.ToString();
                PQConsoleWriteLine(tempString);

                tempString = "Mean: " + avg.ToString("f") + ", Median: " + median.ToString("f") + ", Std.Dev.: " + standardDeviation.ToString("f");
                PQConsoleWriteLine(tempString);

                grpQueries.Visible = true;
            }
            else
            {
                MessageBox.Show("Min Range cannot be higher than Max Range. Try again.");
            }
        }

        private void btnQueryValue_Click(object sender, EventArgs e)
        {
            BigInteger value = BigInteger.Parse(numUpDownQueryValue.Value.ToString());

            var valuesQueried = (from num in bigIntegerList.AsParallel()
                                where num == value
                                select num);

            List<BigInteger> valuesFrequency = new List<BigInteger>(valuesQueried);
            valuesFrequency.TrimExcess();

            string tempString = "Query: The frequency of the value " + value.ToString() + " in the Random Number Table: " + valuesFrequency.Count().ToString("N0");
            PQConsoleWriteLine(tempString);
        }

        private void btnMaxQueryValue_Click(object sender, EventArgs e)
        {
            numUpDownMaxQueryValue.Value = numUpDownMaxQueryValue.Maximum;
        }

        private void btnMinQueryValue_Click(object sender, EventArgs e)
        {
            numUpDownMinQueryValue.Value = numUpDownMinQueryValue.Minimum;
        }

        private void btnQueryRange_Click(object sender, EventArgs e)
        {
            BigInteger maxRange = BigInteger.Parse(numUpDownMaxQueryValue.Value.ToString());
            BigInteger minRange = BigInteger.Parse(numUpDownMinQueryValue.Value.ToString());

            if (minRange <= maxRange)
            {
                var valuesQueried = (from num in bigIntegerList.AsParallel()
                                     where (num <= maxRange && num >= minRange)
                                     select num);

                List<BigInteger> valuesFrequency = new List<BigInteger>(valuesQueried);
                valuesFrequency.TrimExcess();

                string tempString = "Query: The frequency of values between " + minRange.ToString() + " (inclusive) and " + maxRange.ToString() + " (inclusive) " + "in the Random Number Table: " + valuesFrequency.Count().ToString("N0");
                PQConsoleWriteLine(tempString);
            }
            else
            {
                MessageBox.Show("Min Range cannot be higher than Max Range. Try again.");
            }
        }

        private void btnQryMostFrequent_Click(object sender, EventArgs e)
        {
            BigInteger number;
            int frequency;
            string tempString;

            var mostFrequentList = bigIntegerList.AsParallel().GroupBy(i => i)
                .OrderByDescending(grp => grp.Count())
                .Select(grp => new { Number = grp.Key, Frequency = grp.Count() }).ToArray();

            var distinctValuesInTable = mostFrequentList.Distinct().ToArray();
            decimal iMax = Math.Min(numUpDownTopFreq.Value, distinctValuesInTable.Count());
            tempString = "The top-" + iMax.ToString("N0") + " frequently occuring values are: ";

            for (int i = 0; i < iMax; i++)
            {
                number = mostFrequentList[i].Number;
                frequency = mostFrequentList[i].Frequency;
                tempString += "[ v" + number.ToString("N0") + ": " + frequency.ToString("N0") + "] ";
            }

            PQConsoleWriteLine(tempString);
        }

        private void btnQryLeastFrequent_Click(object sender, EventArgs e)
        {
            BigInteger number;
            int frequency;
            string tempString;

            var leastFrequentList = bigIntegerList.AsParallel().GroupBy(i => i)
                .OrderBy(grp => grp.Count())
                .Select(grp => new { Number = grp.Key, Frequency = grp.Count() }).ToArray();

            var distinctValuesInTable = leastFrequentList.Distinct().ToArray();
            decimal iMax = Math.Min(numUpDownBottomFreq.Value, distinctValuesInTable.Count());
            tempString = "The bottom-" + iMax.ToString("N0") + " frequently occuring values are: ";

            for (int i = 0; i < iMax; i++)
            {
                number = leastFrequentList[i].Number;
                frequency = leastFrequentList[i].Frequency;
                tempString += "[ v" + number.ToString("N0") + ": " + frequency.ToString("N0") + "] ";
            }

            PQConsoleWriteLine(tempString);
        }

        #endregion

        #region TAB3 METHODS

        public void PQConsoleWrite(string input)
        {
            txtPQConsole.Text += input;
        }

        public void PQConsoleWriteLine(string input)
        {
            txtPQConsole.Text += input + "\n";
        }

        private double CalculateStandardDeviation(IEnumerable<double> valueList)
        {
            double result = 0;

            if (valueList.Count() > 0)
            {
                double avg = valueList.Average();
                double sum = valueList.Sum(x => Math.Pow(x - avg, 2));

                result = Math.Sqrt((sum) / valueList.Count());
            }
            return result;
        }

        // Non-zero modal frequency is the most common frequency which values in a set will occur.
        // Example set: {0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 6}
        // Above set will have a modal frequency of 2, with count of 4.
        // Reasoning: there are four sets of values that has frequency of 2. The non-zero modal frequency is 2.
        private void CalculateNonZeroModalFrequency(IEnumerable<double> valueList, out int frequency, out int count)
        {
            frequency = 0;
            count = 0;

            if (valueList.Count() > 0)
            {
                var queryModalFrequency = valueList
                    .AsParallel()
                    .GroupBy(i => i)
                    .GroupBy(grp => grp.Count())
                    .OrderByDescending(frq => frq.Count())
                    .Select(frq => new { Frequency = frq.Key, Count = frq.Count() })
                    .ToArray();

                frequency = queryModalFrequency[0].Frequency;
                count = queryModalFrequency[0].Count;
            }
        }

        private int CalculateSingularFrequencyCount(IEnumerable<double> valueList)
        {
            int singularFrequencyCount = 0;

            if (valueList.Count() > 0)
            {
                var queryModalFrequency = valueList
                                            .AsParallel()
                                            .GroupBy(i => i)
                                            .GroupBy(grp => grp.Count())
                                            .OrderByDescending(frq => frq.Count())
                                            .Select(frq => new { Frequency = frq.Key, Count = frq.Count() })
                                            .ToArray();

                singularFrequencyCount = queryModalFrequency
                                            .AsParallel()
                                            .Where(i => i.Frequency == 1)
                                            .First()
                                            .Count;
            }

            return singularFrequencyCount;
        }

        private double CalculateMedian(IEnumerable<double> valueList)
        {
            double result = 0;

            if (valueList.Count() > 0)
            {
                var rankedList = valueList.OrderByDescending(i => i).ToArray();

                if (valueList.Count() % 2 == 1)
                    result = rankedList[rankedList.Count() / 2];
                else
                    result = (rankedList[rankedList.Count() / 2] + rankedList[(rankedList.Count() / 2) - 1]) / 2f;
            }

            return result;
        }

        private double PoissonEqualOrLessThan(double expectedFrequency, uint actualFrequency)
        {
            double result = 0;
            for (int i = 0; i <= actualFrequency; i++)
                result += PoissonProbability(expectedFrequency, (uint)i);
            return result;
        }

        private double PoissonEqualOrGreaterThan(double expectedFrequency, uint actualFrequency)
        {
            double result = 1;
            for (int i = 0; i < actualFrequency; i++)
                result -= PoissonProbability(expectedFrequency, (uint)i);
            return result;
        }

        private double PoissonProbability(double expectedFrequency, uint actualFrequency)
        {
            return Math.Exp(-expectedFrequency) * Math.Pow(expectedFrequency, actualFrequency) / Factorial(actualFrequency);
        }

        private double PoissonBirthdayCollisionProbablity(int setSize, int numbersOfActors)
        {
            double factor = -(double)(numbersOfActors * numbersOfActors) / (double)(2 * setSize);
            return (1 - Math.Exp(factor));
        }

        private double Factorial(uint x)
        {
            double num = 1;
            for (int i = 1; i <= x; i++)
                num *= i;
            return num;
        }

        #endregion

        #region TAB4 BUTTONS

        private void btnGenerateRGBNoise_Click(object sender, EventArgs e)
        {
            int integersNeeded = canvasTab3.Height * canvasTab3.Width * 3;
            pprng.GenerateDesiredQuantityOfRandomIntegers("Huy's PPRNG", DesiredCPUUtilization.AllThreads, integersNeeded, 0, 256);
            ConcurrentBag<BigInteger> bagOfIntegers = new ConcurrentBag<BigInteger>(pprng.GetBagOfRandomIntegers);

            ConcurrentBag<Bitmap> bagOfBitmaps = new ConcurrentBag<Bitmap>();
            int canvasHeight = canvasTab3.Height;

            Parallel.For(0, bmap.Width, i => 
            {
                Graphics x;
                Bitmap bmapx;
                bmapx = new Bitmap(1, canvasHeight);
                x = Graphics.FromImage(bmapx);

                for (int j = 0; j < canvasHeight; j++)
                {
                    BigInteger red, green, blue;
                    bool success1 = bagOfIntegers.TryTake(out red);
                    bool success2 = bagOfIntegers.TryTake(out green);
                    bool success3 = bagOfIntegers.TryTake(out blue);

                    Color randomColor = Color.FromArgb((int)red, (int)green, (int)blue);
                    SolidBrush randomSolidBrush = new SolidBrush(randomColor);
                    x.FillRectangle(randomSolidBrush, 0, j, 1, 1);
                }

                bagOfBitmaps.Add(bmapx);
                x.Dispose();
            });

            for (int i = 0; i < bmap.Width; i++)
            {
                Bitmap slice;
                bool success = bagOfBitmaps.TryTake(out slice);

                g.DrawImage(slice, i, 0);
                canvasTab3.Image = bmap;
            }
        }

        private void btnGenerateBWNoise_Click(object sender, EventArgs e)
        {
            int integersNeeded = canvasTab3.Height * canvasTab3.Width;
            pprng.GenerateDesiredQuantityOfRandomIntegers("Huy's PPRNG", DesiredCPUUtilization.AllThreads, integersNeeded, 0, 256);
            ConcurrentBag<BigInteger> bagOfIntegers = new ConcurrentBag<BigInteger>(pprng.GetBagOfRandomIntegers);

            ConcurrentBag<Bitmap> bagOfBitmaps = new ConcurrentBag<Bitmap>();
            int canvasHeight = canvasTab3.Height;

            Parallel.For(0, bmap.Width, i =>
            {
                Graphics x;
                Bitmap bmapx;
                bmapx = new Bitmap(1, canvasHeight);
                x = Graphics.FromImage(bmapx);

                for (int j = 0; j < canvasHeight; j++)
                {
                    BigInteger greyscale;
                    bool success = bagOfIntegers.TryTake(out greyscale);

                    Color randomColor = Color.FromArgb((int)greyscale, (int)greyscale, (int)greyscale);
                    SolidBrush randomSolidBrush = new SolidBrush(randomColor);
                    x.FillRectangle(randomSolidBrush, 0, j, 1, 1);
                }

                bagOfBitmaps.Add(bmapx);
                x.Dispose();
            });

            for (int i = 0; i < bmap.Width; i++)
            {
                Bitmap slice;
                bool success = bagOfBitmaps.TryTake(out slice);

                g.DrawImage(slice, i, 0);
                canvasTab3.Image = bmap;
            }
        }

        private void btnGenerateVerticalBars_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb((int)prng.NextUInteger(256), (int)prng.NextUInteger(256), (int)prng.NextUInteger(256));
            SolidBrush solidBrush = new SolidBrush(color);

            for (int i = 0; i < bmap.Width; i++)
            {
                g.FillRectangle(solidBrush, i, 0, 1, (int)prng.NextUInteger(bmap.Height));
            }

            canvasTab3.Image = bmap;
        }

        private void btnRandomWalk_Click(object sender, EventArgs e)
        {
            int iterations = 1000;
            
            Color color = Color.FromArgb((int)prng.NextUInteger(256), (int)prng.NextUInteger(256), (int)prng.NextUInteger(256));
            Pen pen = new Pen(color, 2);

            Point originPoint = new Point(canvasTab3.Width / 2, canvasTab3.Height / 2);

            for (int i = 0; i < iterations; i++)
            {
                Point point1 = originPoint;
                Point point2 = new Point((point1.X + (int)prng.Next(-4, 5)), (point1.Y + (int)prng.Next(-4, 5)));

                if (point2.X < 0 || point2.Y < 0 || point2.X > canvasTab3.Width - 1 || point2.Y > canvasTab3.Height - 1)
                {
                    originPoint = new Point(canvasTab3.Width / 2, canvasTab3.Height / 2);
                }
                else
                {
                    g.DrawLine(pen, point1, point2);
                    originPoint = point2;
                }
            }
 
            canvasTab3.Image = bmap;
        }

        private void btnGetNewDeck_Click(object sender, EventArgs e)
        {
            IEnumerable<int> newCardDeck = Enumerable.Range(1, 52);
            currentListOfCardIndexes = new List<int>(newCardDeck);

            int indexCounter = 0;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 13; j++)
                {
                    int cardIndex = currentListOfCardIndexes[indexCounter];
                    int offsetX = -15;
                    int offsetY = 159;
                    int spacing = 7;

                    Image newImage = Image.FromFile("..\\..\\bin\\Cards\\" + cardIndex.ToString() +".png", true);
                    newImage.RotateFlip(RotateFlipType.RotateNoneFlipY);

                    g.DrawImage(newImage, offsetX + (j*(60 + spacing)), offsetY + (i*(86 + spacing)), 106, 106);
                    canvasTab3.Image = bmap;

                    txtCardsRemaining.Text = "R: " + currentListOfCardIndexes.Count;

                    indexCounter++;
                }
        }

        private void btnShuffleDeck_Click(object sender, EventArgs e)
        {
            currentListOfCardIndexes = ShuffleListOfIntegers(currentListOfCardIndexes);
            List<int> appendedListOfCardIndexes = AppendZeroesToDeck(currentListOfCardIndexes); 

            int indexCounter = 0;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 13; j++)
                {
                    int cardIndex = appendedListOfCardIndexes[indexCounter];
                    int offsetX = -15;
                    int offsetY = 159;
                    int spacing = 7;

                    Image newImage = Image.FromFile("..\\..\\bin\\Cards\\" + cardIndex.ToString() + ".png", true);
                    newImage.RotateFlip(RotateFlipType.RotateNoneFlipY);

                    g.DrawImage(newImage, offsetX + (j * (60 + spacing)), offsetY + (i * (86 + spacing)), 106, 106);
                    canvasTab3.Image = bmap;

                    txtCardsRemaining.Text = "R: " + currentListOfCardIndexes.Count;

                    indexCounter++;
                }
        }

        private void btnThrowCard_Click(object sender, EventArgs e)
        {
            if (currentListOfCardIndexes.Count > 0)
            {
                int maxThrowRadius = (canvasTab3.Height / 2) - 54 - 8;
                int randomDistance = (int)prng.NextUInteger(maxThrowRadius);
                float randomAngle = ((float)prng.NextUInteger(36000) / 100f);

                int xRandomOffset = 0;
                int yRandomOffset = 0;

                ApproximatePolarToCartesian(randomDistance, randomAngle, out xRandomOffset, out yRandomOffset);

                Image newImage = Image.FromFile("..\\..\\bin\\Cards\\" + currentListOfCardIndexes[currentListOfCardIndexes.Count - 1].ToString() + ".png", true);
                Bitmap newBitmap = new Bitmap(newImage);

                float randomRotation = ((float)prng.NextUInteger(36000) / 100f);
                newBitmap = RotateBitmap(newBitmap, randomRotation);
                newBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

                g.DrawImage(newBitmap, (canvasTab3.Width / 2 - 53) + xRandomOffset, (canvasTab3.Height / 2 - 52) + yRandomOffset, 106, 106);
                canvasTab3.Image = bmap;

                currentListOfCardIndexes.RemoveAt(currentListOfCardIndexes.Count - 1);
                txtCardsRemaining.Text = "R: " + currentListOfCardIndexes.Count;
            }
        }

        private void btnThrowNewShuffedDeck_Click(object sender, EventArgs e)
        {
            IEnumerable<int> cardIndexes = Enumerable.Range(1, 52);
            List<int> newCardDeck = new List<int>(cardIndexes);
            List<int> newShuffledCardDeck = ShuffleListOfIntegers(newCardDeck);

            while (newShuffledCardDeck.Count > 0)
            {
                int maxThrowRadius = (canvasTab3.Height / 2) - 54 - 8;
                int randomDistance = (int)prng.NextUInteger(maxThrowRadius);
                float randomAngle = ((float)prng.NextUInteger(36000) / 100f);

                int xRandomOffset = 0;
                int yRandomOffset = 0;

                ApproximatePolarToCartesian(randomDistance, randomAngle, out xRandomOffset, out yRandomOffset);

                Image newImage = Image.FromFile("..\\..\\bin\\Cards\\" + newShuffledCardDeck[newShuffledCardDeck.Count - 1].ToString() + ".png", true);
                Bitmap newBitmap = new Bitmap(newImage);

                float randomRotation = ((float)prng.NextUInteger(360000) / 1000f);
                newBitmap = RotateBitmap(newBitmap, randomRotation);
                newBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

                g.DrawImage(newBitmap, (canvasTab3.Width / 2 - 53) + xRandomOffset, (canvasTab3.Height / 2 - 52) + yRandomOffset, 106, 106);
                canvasTab3.Image = bmap;

                newShuffledCardDeck.RemoveAt(newShuffledCardDeck.Count - 1);
            }  
        }

        private void btnCreateHistogram_Click(object sender, EventArgs e)
        {
            ConcurrentBag<Tuple<int, int>> bagOfTuples = new ConcurrentBag<Tuple<int, int>>();
            int tuplesNeeded = (int)numUpDownPoints.Value;

            ConcurrentBag<BigInteger> bagOfXIntegers;
            ConcurrentBag<BigInteger> bagOfYIntegers;

            int integerXMax = (int)numUpDownX.Value;
            int integerXNeeded = (int)numUpDownPoints.Value + ThreadUsage(DesiredCPUUtilization.AllThreads);

            int integerYMax = (int)numUpDownY.Value;
            int integerYNeeded = (int)numUpDownPoints.Value + ThreadUsage(DesiredCPUUtilization.AllThreads);
            
            pprng.GenerateDesiredQuantityOfRandomIntegers("Huy's PPRNG", DesiredCPUUtilization.AllThreads, integerXNeeded, 0, integerXMax);
            bagOfXIntegers = new ConcurrentBag<BigInteger>(pprng.GetBagOfRandomIntegers);

            pprng.GenerateDesiredQuantityOfRandomIntegers("Huy's PPRNG", DesiredCPUUtilization.AllThreads, integerYNeeded, 0, integerYMax);
            bagOfYIntegers = new ConcurrentBag<BigInteger>(pprng.GetBagOfRandomIntegers);

            ParallelOptions maxDegreeOfParallelism = new ParallelOptions();
            maxDegreeOfParallelism.MaxDegreeOfParallelism = ThreadUsage(DesiredCPUUtilization.AllThreads);

            Parallel.For(0, ThreadUsage(DesiredCPUUtilization.AllThreads), maxDegreeOfParallelism, i => 
            { 
                while (bagOfTuples.Count < tuplesNeeded)
                {
                    BigInteger randomX, randomY;
                    bagOfXIntegers.TryTake(out randomX);
                    bagOfYIntegers.TryTake(out randomY);

                    bagOfTuples.Add(Tuple.Create((int)randomX, (int)randomY));
                }
            });

            while (bagOfTuples.Count > tuplesNeeded)
            {
                Tuple<int, int> randomTuple;
                bagOfTuples.TryTake(out randomTuple);
            }

            List<int[,]> listOf2DMatrices = new List<int[,]>();
                
            Parallel.For(0, ThreadUsage(DesiredCPUUtilization.AllThreads), maxDegreeOfParallelism, i => 
            {
                int[,] matrix = new int[integerXMax, integerYMax];

                while (bagOfTuples.Count > 0)
                {
                    Tuple<int, int> randomTuple;
                    bool success = bagOfTuples.TryTake(out randomTuple);

                    if (success == false)
                        break;
                    else
                        matrix[randomTuple.Item1, randomTuple.Item2]++;
                }

                lock(listOf2DMatrices)
                    listOf2DMatrices.Add(matrix); 
            });

            int[,] resultMatrix = new int[integerXMax, integerYMax];

            foreach (int[,] matrix in listOf2DMatrices)
            {
                for (int i = 0; i < integerXMax; i++)
                    for (int j = 0; j < integerYMax; j++)
                        resultMatrix[i, j] += matrix[i, j];
            }

            histogramMatrix = new int[resultMatrix.GetLength(0), resultMatrix.GetLength(1)];
            Array.Copy(resultMatrix, histogramMatrix, resultMatrix.Length);

            Bitmap bmapTemp = new Bitmap(integerXMax, integerYMax);
            Graphics gTemp = Graphics.FromImage(bmap);
            Color color;

            int coordinateFrequency;
            int colorValue;

            SolidBrush solidBrush = new SolidBrush(Color.White);
            g.FillRectangle(solidBrush, 0, 0, integerXMax, integerYMax);

            for (int i = 0; i < integerXMax; i++)
                for (int j = 0; j < integerYMax; j++)
                    if (resultMatrix[i,j] > 0)
                    {
                        coordinateFrequency = resultMatrix[i,j];
                        colorValue = 255 - (coordinateFrequency * 30);    

                        if (coordinateFrequency <= 255 && colorValue >= 0)
                            color = Color.FromArgb(colorValue, colorValue, colorValue);
                        else
                            color = Color.Black;

                        solidBrush = new SolidBrush(color);
                        g.FillRectangle(solidBrush, i, j, 1, 1);
                    }

            gTemp.DrawImage(bmap, 0, 0);
            canvasTab3.Image = bmap;

            int maxFrequency = resultMatrix.Cast<int>().Max();
            int minFrequency = resultMatrix.Cast<int>().Min();

            numUpDownFilterMax.Value = maxFrequency;
            numUpDownFilterMin.Value = maxFrequency / 2;
            grpHistogramFilter.Visible = true;

            #region MESSAGEBOX ANALYSIS

            int totalPointsDrawn = resultMatrix.Cast<int>().Sum();
            double avgDensity = (double)numUpDownPoints.Value / (double)histogramMatrix.Length;

            string tempString = "2D Histogram Dimensions: " + resultMatrix.GetLength(0) + " by " + resultMatrix.GetLength(1) + "\n" +
                                "Total Points Generated: " + totalPointsDrawn.ToString("N0") + "\n" +
                                "Average Density (Point per Pixel): " + avgDensity.ToString() + "\n" + "\n";

            
            double emptySlotsTheoretical = Math.Round(PoissonProbability(avgDensity, 0) * resultMatrix.Length);

            var queryableMatrix = resultMatrix.Cast<int>();
            var zeroFrequencyList = (from int num in queryableMatrix
                                     where num == 0
                                     select num).ToArray();

            int emptySlotsActual = zeroFrequencyList.Count();

            double accuracy = 100 - Math.Abs((emptySlotsTheoretical - emptySlotsActual) / emptySlotsTheoretical) * 100;      

            tempString +=   "Thereotical Poisson Empty Slots: " + emptySlotsTheoretical.ToString("N0") + "\n" +
                            "Generated Empty Slots: " + emptySlotsActual.ToString("N0") + "\n" +
                            "Accuracy to Poisson Distribution: " + accuracy.ToString() + "%";
                                
            MessageBox.Show(tempString);

            #endregion
        }

        private void btnHistogramFilter_Click(object sender, EventArgs e)
        {
            int integerXMax = histogramMatrix.GetLength(0);
            int integerYMax = histogramMatrix.GetLength(1);

            Bitmap bmapTemp = new Bitmap(integerXMax, integerYMax);
            Graphics gTemp = Graphics.FromImage(bmap);
            Color color;

            int coordinateFrequency;
            int colorValue;

            if (numUpDownFilterMin.Value <= numUpDownFilterMax.Value)
            {
                SolidBrush solidBrush = new SolidBrush(Color.White);
                g.FillRectangle(solidBrush, 0, 0, integerXMax, integerYMax);

                for (int i = 0; i < integerXMax; i++)
                    for (int j = 0; j < integerYMax; j++)
                    {
                        if (histogramMatrix[i, j] > 0)
                        {
                            coordinateFrequency = histogramMatrix[i, j];
                            colorValue = 255 - (coordinateFrequency * 30);

                            if (coordinateFrequency >= (int)numUpDownFilterMin.Value && coordinateFrequency <= (int)numUpDownFilterMax.Value)
                            {
                                if (coordinateFrequency <= 255 && colorValue >= 0)
                                    color = Color.FromArgb(colorValue, colorValue, colorValue);
                                else
                                    color = Color.Black;

                                solidBrush = new SolidBrush(color);
                                g.FillRectangle(solidBrush, i, j, 1, 1);
                            }
                        } 
                    }
            }
            else
                MessageBox.Show("Filter Max cannot be smaller than Filter Min. Try again.");

            gTemp.DrawImage(bmap, 0, 0);
            canvasTab3.Image = bmap;
        }

        private void btnClearCanvas_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            canvasTab3.Image = bmap;
        }

        #endregion

        #region TAB4 METHODS

        private List<int> ShuffleListOfIntegers(List<int> listOfIntegers)
        {
            List<int> originalList = new List<int>(listOfIntegers);
            List<int> shuffledList = new List<int>();

            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                int randomIndex = (int)prng.NextUInteger(originalList.Count);

                shuffledList.Add(originalList[randomIndex]);
                originalList.RemoveAt(randomIndex);
            }

            return shuffledList;
        }

        private List<int> AppendZeroesToDeck(List<int> listOfIntegers)
        {
            List<int> listOfCardIndexes = new List<int>(listOfIntegers);

            while (listOfCardIndexes.Count < 52)
                listOfCardIndexes.Insert(0, 0);

            return listOfCardIndexes;
        }

        private Bitmap RotateBitmap(Bitmap bitmap, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            //make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(bitmap, new Point(0, 0));
            }
            return returnBitmap;
        }

        private void ApproximatePolarToCartesian(int radius, float angle, out int x, out int y)
        {
            float internalAngle = angle % 360;

            float floatX = (float)(radius * Math.Cos(internalAngle));
            float floatY = (float)(radius * Math.Sin(internalAngle));

            y = (int)floatX;
            x = (int)floatY;
        }

        #endregion

        #region TAB5 TEXT

        private void DisplayAboutText()
        {
            txtAbout.Text =
                "Huy Pham's Parallel Pseudorandom Random Number Generator" + "\n" + "\n" +

                "A SHA2-based pseudorandom number generator that uses System.Security.Cryptography.RNGCryptoServiceProvider as the seed." + "\n" +
                "512-bit internal state, 256-bit output." + "\n" + "\n" +

                "The seeding starts with 64 bytes of RNGCryptoServiceProvider, concatenated by the SHA512 hash of the user input, then both 64-byte arrays is SHA512'd, generating the initial internal state. Pseudocode: " + "\n" + "\n" +

                "InternalState-0 = SHA512(RNGCryptoServiceProvider + SHA512('ASCII user input'))" + "\n" + "\n" +

                "The random number requested by the user is a SHA256 digest of the internal state, followed by the next iteration of the internal state change. Pseudocode: " + "\n" + "\n" +

                "Output-0 = SHA256(InternalState-0)" + "\n" +
                "InternalState-1 = SHA512(InternalState-0)" + "\n" + "\n" +

                "Output-1 = SHA256(InternalState-1)" + "\n" +
                "InternalState-2 = SHA512(InternalState-1)" + "\n" + "\n" +

                "Output-2 = SHA256(InternalState-2)" + "\n" +
                "InternalState-3 = SHA512(InternalState-2)" + "\n" +
                "... and so on." + "\n" + "\n" +

                "The effects of segregating the algorithm of the internal state from the requested PRNG output, is that short of viewing the memory bytes, the user cannot predict the next pseudorandom value, even if the algorithm is known!"
                ;
        }

        #endregion

        #region METHODS

        private int ThreadUsage(DesiredCPUUtilization desiredCPUUtilization)
        {
            int threadUsage = 1;

            if (desiredCPUUtilization == DesiredCPUUtilization.AllThreads)
                threadUsage = Environment.ProcessorCount;
            else if (desiredCPUUtilization == DesiredCPUUtilization.HalfAvailPlusOneThread)
                threadUsage = (Environment.ProcessorCount / 2) + 1;
            else if (desiredCPUUtilization == DesiredCPUUtilization.HalfAvailThreads)
                threadUsage = (Environment.ProcessorCount / 2);
            else if (desiredCPUUtilization == DesiredCPUUtilization.SingleThread)
                threadUsage = 1;

            return threadUsage;
        }

        #endregion
    }
}
