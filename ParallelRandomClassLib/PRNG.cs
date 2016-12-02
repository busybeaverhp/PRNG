using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelRandomClassLib
{
    public class PRNG
    {
        HashAlgorithm sha512 = new SHA512Managed();
        HashAlgorithm sha256 = new SHA256Managed();

        private byte[] _hashedSeedByte;
        private byte[] _currentEntropyBytes;

        public PRNG()
        {
            RNGCryptoServiceProvider rngcsp = new RNGCryptoServiceProvider();
            _currentEntropyBytes = new byte[64];

            // RNGCrypto provides the virtually random bytes.
            byte[] _systemEntropy64ByteSeed = new byte[64];
            rngcsp.GetBytes(_systemEntropy64ByteSeed);
            rngcsp.Dispose();

            // When initializing PRNG without an argument, a SHA-512("inputString") hash will be used.
            byte[] _inputEntropy64ByteSeed = sha512.ComputeHash(Encoding.ASCII.GetBytes("inputString"));

            // Concatenate both entropy seeds.
            var concatenatedSeed = new byte[_systemEntropy64ByteSeed.Length + _inputEntropy64ByteSeed.Length];
            _systemEntropy64ByteSeed.CopyTo(concatenatedSeed, 0);
            _inputEntropy64ByteSeed.CopyTo(concatenatedSeed, _inputEntropy64ByteSeed.Length);

            _hashedSeedByte = sha512.ComputeHash(concatenatedSeed);
            _currentEntropyBytes = _hashedSeedByte.ToArray();
        }

        public PRNG(string inputString)
        {
            RNGCryptoServiceProvider rngcsp = new RNGCryptoServiceProvider();
            _currentEntropyBytes = new byte[64];

            // RNGCrypto provides the virtually random bytes.
            byte[] _systemEntropy64ByteSeed = new byte[64];
            rngcsp.GetBytes(_systemEntropy64ByteSeed);
            rngcsp.Dispose();

            // Your input is to guarantee an additional source of entropy in case the entropy pool from RNGCSP fails.
            byte[] _inputEntropy64ByteSeed = sha512.ComputeHash(Encoding.ASCII.GetBytes(inputString));

            // Concatenate both entropy seeds.
            var concatenatedSeed = new byte[_systemEntropy64ByteSeed.Length + _inputEntropy64ByteSeed.Length];
            _systemEntropy64ByteSeed.CopyTo(concatenatedSeed, 0);
            _inputEntropy64ByteSeed.CopyTo(concatenatedSeed, _inputEntropy64ByteSeed.Length);

            _hashedSeedByte = sha512.ComputeHash(concatenatedSeed);
            _currentEntropyBytes = _hashedSeedByte.ToArray();
        }

        public byte[] NextEntropy32ByteArray()
        {
            byte[] entropy32ByteArray = sha256.ComputeHash(_currentEntropyBytes);

            // Hashes the current entropy value and stores the hash as the basis for the next psuedorandom value.
            _currentEntropyBytes = sha512.ComputeHash(_currentEntropyBytes);

            return entropy32ByteArray;
        }

        public List<byte[]> GenerateListOfEntropy32ByteArrays(int desiredQuantityOfArrays)
        {
            List<byte[]> listOfEntropy32ByteArray = new List<byte[]>();
            byte[] entropy32ByteArray = new byte[32];

            if (desiredQuantityOfArrays > 0)
                for (int i = 0; i < desiredQuantityOfArrays; i++)
                {
                    entropy32ByteArray = NextEntropy32ByteArray();
                    listOfEntropy32ByteArray.Add(entropy32ByteArray);
                }

            return listOfEntropy32ByteArray;
        }

        public BigInteger NextUInteger(BigInteger integerMaxExclusive)
        {
            BigInteger prn = new BigInteger(sha256.ComputeHash(_currentEntropyBytes));
            prn = BigInteger.Abs(prn);

            // Hashes the current entropy value and stores the hash as the basis for the next psuedorandom value.
            _currentEntropyBytes = sha512.ComputeHash(_currentEntropyBytes);

            prn = prn % integerMaxExclusive;
            return prn;
        }

        public BigInteger Next(BigInteger minIntValueInclusive, BigInteger maxIntValueExclusive)
        {
            BigInteger minMaxDifference = maxIntValueExclusive - minIntValueInclusive;
            BigInteger prn = new BigInteger(sha256.ComputeHash(_currentEntropyBytes));
            prn = BigInteger.Abs(prn);

            // Hashes the current entropy value and stores the hash as the basis for the next psuedorandom value.
            _currentEntropyBytes = sha512.ComputeHash(_currentEntropyBytes);

            prn = (prn % minMaxDifference) + minIntValueInclusive;
            return prn;
        }

        public List<BigInteger> GenerateListOfEntropyUValues(BigInteger integerMaxExclusive, int desiredQuantityOfValues)
        {
            List<BigInteger> listOfEntropyUValues = new List<BigInteger>();
            BigInteger generatedValue = 0;

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
            BigInteger generatedValue = 0;

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
