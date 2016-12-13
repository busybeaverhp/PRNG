using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelRandomClassLib
{
    public class Prng
    {
        readonly HashAlgorithm _sha512 = new SHA512Managed();
        readonly HashAlgorithm _sha256 = new SHA256Managed();

        private byte[] _currentEntropyBytes;

        public Prng()
        {
            RNGCryptoServiceProvider rngcsp = new RNGCryptoServiceProvider();
            _currentEntropyBytes = new byte[64];

            // RNGCrypto provides the virtually random bytes.
            byte[] systemEntropy64ByteSeed = new byte[64];
            rngcsp.GetBytes(systemEntropy64ByteSeed);
            rngcsp.Dispose();

            // When initializing PRNG without an argument, a SHA-512("inputString") hash will be used.
            byte[] inputEntropy64ByteSeed = _sha512.ComputeHash(Encoding.ASCII.GetBytes("inputString"));

            // Concatenate both entropy seeds.
            byte[] concatenatedSeed = new byte[systemEntropy64ByteSeed.Length + inputEntropy64ByteSeed.Length];
            systemEntropy64ByteSeed.CopyTo(concatenatedSeed, 0);
            inputEntropy64ByteSeed.CopyTo(concatenatedSeed, inputEntropy64ByteSeed.Length);

            byte[] hashedSeedByte = _sha512.ComputeHash(concatenatedSeed);
            _currentEntropyBytes = hashedSeedByte.ToArray();
        }

        public Prng(string inputString)
        {
            RNGCryptoServiceProvider rngcsp = new RNGCryptoServiceProvider();
            _currentEntropyBytes = new byte[64];

            // RNGCrypto provides the virtually random bytes.
            byte[] systemEntropy64ByteSeed = new byte[64];
            rngcsp.GetBytes(systemEntropy64ByteSeed);
            rngcsp.Dispose();

            // Your input is to guarantee an additional source of entropy in case the entropy pool from RNGCSP fails.
            byte[] inputEntropy64ByteSeed = _sha512.ComputeHash(Encoding.ASCII.GetBytes(inputString));

            // Concatenate both entropy seeds.
            byte[] concatenatedSeed = new byte[systemEntropy64ByteSeed.Length + inputEntropy64ByteSeed.Length];
            systemEntropy64ByteSeed.CopyTo(concatenatedSeed, 0);
            inputEntropy64ByteSeed.CopyTo(concatenatedSeed, inputEntropy64ByteSeed.Length);

            byte[] hashedSeedByte = _sha512.ComputeHash(concatenatedSeed);
            _currentEntropyBytes = hashedSeedByte.ToArray();
        }

        public byte[] Next32ByteArray()
        {
            byte[] entropy32ByteArray = _sha256.ComputeHash(_currentEntropyBytes);

            // Hashes the current entropy value and stores the hash as the basis for the next psuedorandom value.
            _currentEntropyBytes = _sha512.ComputeHash(_currentEntropyBytes);
            return entropy32ByteArray;
        }

        public List<byte[]> GenerateListOf32ByteArrays(int desiredQuantityOfArrays)
        {
            List<byte[]> listOfEntropy32ByteArray = new List<byte[]>();

            if (desiredQuantityOfArrays > 0)
                for (int i = 0; i < desiredQuantityOfArrays; i++)
                {
                    byte[] entropy32ByteArray = Next32ByteArray();
                    listOfEntropy32ByteArray.Add(entropy32ByteArray);
                }
            return listOfEntropy32ByteArray;
        }

        public BigInteger NextUInteger(BigInteger integerMaxExclusive)
        {
            BigInteger prn = new BigInteger(_sha256.ComputeHash(_currentEntropyBytes));
            prn = BigInteger.Abs(prn);

            // Hashes the current entropy value and stores the hash as the basis for the next psuedorandom value.
            _currentEntropyBytes = _sha512.ComputeHash(_currentEntropyBytes);

            prn = prn % integerMaxExclusive;
            return prn;
        }

        public BigInteger Next(BigInteger minIntValueInclusive, BigInteger maxIntValueExclusive)
        {
            BigInteger minMaxDifference = maxIntValueExclusive - minIntValueInclusive;
            BigInteger prn = new BigInteger(_sha256.ComputeHash(_currentEntropyBytes));
            prn = BigInteger.Abs(prn);

            // Hashes the current entropy value and stores the hash as the basis for the next psuedorandom value.
            _currentEntropyBytes = _sha512.ComputeHash(_currentEntropyBytes);

            prn = (prn % minMaxDifference) + minIntValueInclusive;
            return prn;
        }

        public List<BigInteger> GenerateListOfEntropyUValues(BigInteger integerMaxExclusive, int desiredQuantityOfValues)
        {
            List<BigInteger> listOfEntropyUValues = new List<BigInteger>();
            BigInteger generatedValue;

            if (desiredQuantityOfValues > 0)
                for (int i = 0; i < desiredQuantityOfValues; i++)
                {
                    generatedValue = NextUInteger(integerMaxExclusive);
                    listOfEntropyUValues.Add(generatedValue);
                }
            return listOfEntropyUValues;
        }

        public List<BigInteger> GenerateListOfEntropyValuesBigInteger(BigInteger minIntValueInclusive, BigInteger maxIntValueExclusive, int desiredQuantityOfValues)
        {
            List<BigInteger> listOfEntropyValues = new List<BigInteger>();
            BigInteger generatedValue;

            if (desiredQuantityOfValues > 0)
                for (int i = 0; i < desiredQuantityOfValues; i++)
                {
                    generatedValue = Next(minIntValueInclusive, maxIntValueExclusive);
                    listOfEntropyValues.Add(generatedValue);
                }
            return listOfEntropyValues;
        }
    }
}
