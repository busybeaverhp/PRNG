using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParallelRandomClassLib
{
    public enum DesiredCpuUtilization {AllThreads, HalfAvailPlusOneThread, HalfAvailThreads, SingleThread};

    public class ParallelPrng
    {
        ConcurrentBag<byte[]> _bagOfRandomBytes;
        ConcurrentBag<BigInteger> _bagOfRandomIntegers;

        public void GenerateDesiredQuantityOfRandom32ByteArrays(string inputString, DesiredCpuUtilization desiredCpuUtilization, int quantityOfRandom32ByteArrays)
        {
            _bagOfRandomBytes = new ConcurrentBag<byte[]>();

            int threadUsage = ThreadUsage(desiredCpuUtilization);
            ParallelOptions maxDegreeOfParallelism = new ParallelOptions {MaxDegreeOfParallelism = threadUsage};

            int iterationsPerThread = (quantityOfRandom32ByteArrays / threadUsage) + 1;

            Parallel.For(0, threadUsage, maxDegreeOfParallelism, (i, parallelLoopState) =>
            {
                inputString += i;
                Prng prng = new Prng(inputString);

                var listOfEntropy32ByteArrays = prng.GenerateListOf32ByteArrays(iterationsPerThread);

                // ConcurrentBag.Concat will turn the concurrent bag into IEnumrable, therefore each byte array must be added to the bag invidually.
                foreach (byte[] byteArray in listOfEntropy32ByteArrays)
                    _bagOfRandomBytes.Add(byteArray);
            });

            while (_bagOfRandomBytes.Count > quantityOfRandom32ByteArrays)
            {
                byte[] random32ByteArray;
                _bagOfRandomBytes.TryTake(out random32ByteArray);
            }
        }

        public void GenerateDesiredQuantityOfRandomIntegers(string inputString, DesiredCpuUtilization desiredCpuUtilization, int desiredQuantityOfValues, BigInteger minIntValueInclusive, BigInteger maxIntValueExclusive)
        {
            _bagOfRandomIntegers = new ConcurrentBag<BigInteger>();

            int threadUsage = ThreadUsage(desiredCpuUtilization);
            ParallelOptions maxDegreeOfParallelism = new ParallelOptions {MaxDegreeOfParallelism = threadUsage};

            int iterationsPerThread = (desiredQuantityOfValues / threadUsage) + 1;

            Parallel.For(0, threadUsage, maxDegreeOfParallelism, (i) =>
            {
                inputString += i;
                Prng prng = new Prng(inputString);

                var listOfRandomIntegers = prng.GenerateListOfEntropyValuesBigInteger(minIntValueInclusive, maxIntValueExclusive, iterationsPerThread);

                // ConcurrentBag.Concat will turn the concurrent bag into IEnumrable, therefore each byte array must be added to the bag invidually.
                foreach (BigInteger randomValue in listOfRandomIntegers)
                    _bagOfRandomIntegers.Add(randomValue);
            });

            while (_bagOfRandomIntegers.Count > desiredQuantityOfValues)
            {
                BigInteger randomValue;
                _bagOfRandomIntegers.TryTake(out randomValue);
            }
        }

        private int ThreadUsage(DesiredCpuUtilization desiredCpuUtilization)
        {
            int threadUsage = 1;

            if (desiredCpuUtilization == DesiredCpuUtilization.AllThreads)
                threadUsage = Environment.ProcessorCount;
            else if (desiredCpuUtilization == DesiredCpuUtilization.HalfAvailPlusOneThread)
                threadUsage = (Environment.ProcessorCount / 2) + 1;
            else if (desiredCpuUtilization == DesiredCpuUtilization.HalfAvailThreads)
                threadUsage = (Environment.ProcessorCount / 2);
            else if (desiredCpuUtilization == DesiredCpuUtilization.SingleThread)
                threadUsage = 1;

            return threadUsage;
        }

        public ConcurrentBag<byte[]> GetBagOfRandomBytes
        { get { return _bagOfRandomBytes; } }

        public ConcurrentBag<BigInteger> GetBagOfRandomIntegers
        { get { return _bagOfRandomIntegers; } }
    }
}
