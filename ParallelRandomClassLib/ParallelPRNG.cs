using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelRandomClassLib
{
    public enum DesiredCPUUtilization {AllThreads, HalfPlusOneThread, HalfThread};

    public class ParallelPRNG
    {
        PRNG _prng;
        int _utilizedCPUThreads;
        List<byte[]> _listOfEntropyByteArrays;

        public ParallelPRNG()
        {
            _utilizedCPUThreads = (Environment.ProcessorCount / 2) + 1;
            _prng = new PRNG("New PRNG Instance");
        }

        public ParallelPRNG(DesiredCPUUtilization CPUUtilization, string inputSeed)
        {
            if (CPUUtilization == DesiredCPUUtilization.AllThreads)
                _utilizedCPUThreads = Environment.ProcessorCount;
            else if (CPUUtilization == DesiredCPUUtilization.HalfPlusOneThread)
                _utilizedCPUThreads = (Environment.ProcessorCount / 2) + 1;
            else if (CPUUtilization == DesiredCPUUtilization.HalfThread)
                _utilizedCPUThreads = (Environment.ProcessorCount / 2);

            _prng = new PRNG(inputSeed);
        }
    }
}
