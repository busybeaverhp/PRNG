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
        ConcurrentBag<byte[]> _bagOfRandomBytes;
        ConcurrentBag<BigInteger> _bagOfRandomIntegers;

        public PPRNG() { }

        public void GenerateDesiredQuantityOfRandom32ByteArrays(string inputString, DesiredCPUUtilization desiredCPUUtilization, int quantityOfRandom32ByteArrays)
        {
            _bagOfRandomBytes = new ConcurrentBag<byte[]>();

            int threadUsage = ThreadUsage(desiredCPUUtilization);

            ParallelOptions maxDegreeOfParallelism = new ParallelOptions();
            maxDegreeOfParallelism.MaxDegreeOfParallelism = threadUsage;

            int iterationsPerThread = (quantityOfRandom32ByteArrays / threadUsage) + 1;

            Parallel.For(0, threadUsage, maxDegreeOfParallelism, (i, ParallelLoopState) =>
            {
                inputString += i;
                PRNG prng = new PRNG(inputString);

                var listOfEntropy32ByteArrays = prng.GenerateListOfEntropy32ByteArrays(iterationsPerThread);

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

        public void GenerateDesiredQuantityOfRandomIntegers(string inputString, DesiredCPUUtilization desiredCPUUtilization, int desiredQuantityOfValues, BigInteger minIntValueInclusive, BigInteger maxIntValueExclusive)
        {
            _bagOfRandomIntegers = new ConcurrentBag<BigInteger>();

            int threadUsage = ThreadUsage(desiredCPUUtilization);

            ParallelOptions maxDegreeOfParallelism = new ParallelOptions();
            maxDegreeOfParallelism.MaxDegreeOfParallelism = threadUsage;

            int iterationsPerThread = (desiredQuantityOfValues / threadUsage) + 1;

            Parallel.For(0, threadUsage, maxDegreeOfParallelism, (i) =>
            {
                inputString += i;
                PRNG prng = new PRNG(inputString);

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
