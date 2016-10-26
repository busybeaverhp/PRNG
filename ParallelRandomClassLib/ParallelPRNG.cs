using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelRandomClassLib
{
    public enum DesiredCPUUtilization {AllThreads, HalfPlusOneThread, HalfThread, SingleThread};

    public class ParallelPRNG
    {
        int _maxDegreeOfParallelism;
        ConcurrentBag<byte[]> _bagOfRandomBytes = new ConcurrentBag<byte[]>();

        public ParallelPRNG()
        {
            _maxDegreeOfParallelism = (Environment.ProcessorCount / 2);
        }

        public ParallelPRNG(DesiredCPUUtilization desiredCPUUtilization)
        {
            if (desiredCPUUtilization == DesiredCPUUtilization.AllThreads)
                _maxDegreeOfParallelism = Environment.ProcessorCount;
            else if (desiredCPUUtilization == DesiredCPUUtilization.HalfPlusOneThread)
                _maxDegreeOfParallelism = (Environment.ProcessorCount / 2) + 1;
            else if (desiredCPUUtilization == DesiredCPUUtilization.HalfThread)
                _maxDegreeOfParallelism = (Environment.ProcessorCount / 2);
            else if (desiredCPUUtilization == DesiredCPUUtilization.SingleThread)
                _maxDegreeOfParallelism = 1;
        }

        public void GenerateDesiredQuantityOfRandomByteArrays(int quantityOfRandomByteArrays)
        {
            ParallelOptions maxDegreeOfParallelism = new ParallelOptions();
            maxDegreeOfParallelism.MaxDegreeOfParallelism = _maxDegreeOfParallelism;

            int iterationsPerThread = (quantityOfRandomByteArrays / _maxDegreeOfParallelism) + 1;

            Parallel.For(0, _maxDegreeOfParallelism, maxDegreeOfParallelism, (i, ParallelLoopState) =>
            {
                string inputString = "New PRNG Instance" + i;
                PRNG prng = new PRNG(inputString);

                var listOfEntropy32ByteArrays = prng.GenerateListOfEntropy32ByteArrays(iterationsPerThread);

                // ConcurrentBag.Concat will turn the concurrent bag into IEnumrable, therefore each byte array must be added to the bag invidually.
                foreach (byte[] byteArray in listOfEntropy32ByteArrays)
                    _bagOfRandomBytes.Add(byteArray);
            });
        }
    }
}
