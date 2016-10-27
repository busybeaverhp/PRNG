using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParallelRandomClassLib
{
    public enum DesiredCPUUtilization {AllThreads, HalfAvailPlusOneThread, HalfAvailThreads, SingleThread};

    public class PPRNG
    {
        ConcurrentBag<byte[]> _bagOfRandomBytes = new ConcurrentBag<byte[]>();
        ConcurrentBag<BigInteger> _bagOfRandomIntegers = new ConcurrentBag<BigInteger>();

        public PPRNG() { }

        public void GenerateDesiredQuantityOfRandomByteArrays(DesiredCPUUtilization desiredCPUUtilization, int quantityOfRandomByteArrays)
        {
            int threadUsage = ThreadUsage(desiredCPUUtilization);

            ParallelOptions maxDegreeOfParallelism = new ParallelOptions();
            maxDegreeOfParallelism.MaxDegreeOfParallelism = threadUsage;

            int iterationsPerThread = (quantityOfRandomByteArrays / threadUsage) + 1;

            Parallel.For(0, threadUsage, maxDegreeOfParallelism, (i, ParallelLoopState) =>
            {
                string inputString = "New PRNG Instance" + i;
                PRNG prng = new PRNG(inputString);

                var listOfEntropy32ByteArrays = prng.GenerateListOfEntropy32ByteArrays(iterationsPerThread);

                // ConcurrentBag.Concat will turn the concurrent bag into IEnumrable, therefore each byte array must be added to the bag invidually.
                foreach (byte[] byteArray in listOfEntropy32ByteArrays)
                    _bagOfRandomBytes.Add(byteArray);
            });
        }

        public void GenerateDesiredQuantityOfRandomIntegers(DesiredCPUUtilization desiredCPUUtilization, int desiredQuantityOfValues, BigInteger minIntValueInclusive, BigInteger maxIntValueExclusive)
        {
            int threadUsage = ThreadUsage(desiredCPUUtilization);

            ParallelOptions maxDegreeOfParallelism = new ParallelOptions();
            maxDegreeOfParallelism.MaxDegreeOfParallelism = threadUsage;

            int iterationsPerThread = (desiredQuantityOfValues / threadUsage) + 1;

            Parallel.For(0, threadUsage, maxDegreeOfParallelism, (i) =>
            {
                string inputString = "New PRNG Instance" + i;
                PRNG prng = new PRNG(inputString);

                var listOfRandomIntegers = prng.GenerateListOfEntropyValuesBigInteger(minIntValueInclusive, maxIntValueExclusive, iterationsPerThread);

                // ConcurrentBag.Concat will turn the concurrent bag into IEnumrable, therefore each byte array must be added to the bag invidually.
                foreach (BigInteger randomValue in listOfRandomIntegers)
                    _bagOfRandomIntegers.Add(randomValue);
            });
        }

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

        public ConcurrentBag<byte[]> GetBagOfRandomBytes
        { get { return _bagOfRandomBytes; } }

        public ConcurrentBag<BigInteger> GetBagOfRandomIntegers
        { get { return _bagOfRandomIntegers; } }
    }
}
