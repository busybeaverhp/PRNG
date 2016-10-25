﻿using System;
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
        private List<byte[]> _listOfEntropyByteArrays;

        public PRNG()
        {
            RNGCryptoServiceProvider rngcsp = new RNGCryptoServiceProvider();
            _listOfEntropyByteArrays = new List<byte[]>();

            byte[] _systemEntropy64ByteSeed = new byte[64];
            rngcsp.GetBytes(_systemEntropy64ByteSeed);
            rngcsp.Dispose();

            byte[] _inputEntropy64ByteSeed = sha512.ComputeHash(Encoding.ASCII.GetBytes("inputString"));

            var concatenatedSeed = new byte[_systemEntropy64ByteSeed.Length + _inputEntropy64ByteSeed.Length];
            _systemEntropy64ByteSeed.CopyTo(concatenatedSeed, 0);
            _inputEntropy64ByteSeed.CopyTo(concatenatedSeed, _inputEntropy64ByteSeed.Length);

            _hashedSeedByte = sha512.ComputeHash(concatenatedSeed);
            _listOfEntropyByteArrays.Add(_hashedSeedByte);
        }

        public PRNG(string inputString)
        {
            RNGCryptoServiceProvider rngcsp = new RNGCryptoServiceProvider();
            _listOfEntropyByteArrays = new List<byte[]>();

            byte[] _systemEntropy64ByteSeed = new byte[64];
            rngcsp.GetBytes(_systemEntropy64ByteSeed);
            rngcsp.Dispose();

            byte[] _inputEntropy64ByteSeed = sha512.ComputeHash(Encoding.ASCII.GetBytes(inputString));

            var concatenatedSeed = new byte[_systemEntropy64ByteSeed.Length + _inputEntropy64ByteSeed.Length];
            _systemEntropy64ByteSeed.CopyTo(concatenatedSeed, 0);
            _inputEntropy64ByteSeed.CopyTo(concatenatedSeed, _inputEntropy64ByteSeed.Length);

            _hashedSeedByte = sha512.ComputeHash(concatenatedSeed);
            _listOfEntropyByteArrays.Add(_hashedSeedByte);
        }

        public BigInteger NextUInteger(BigInteger integerMaxExclusive)
        {
            BigInteger prn = new BigInteger(sha256.ComputeHash(_listOfEntropyByteArrays[0]));
            prn = BigInteger.Abs(prn);

            // Hashes the current entropy value and stores the hash as the basis for the next psuedorandom value.
            _listOfEntropyByteArrays.Add(sha512.ComputeHash(_listOfEntropyByteArrays[0]));
            _listOfEntropyByteArrays.RemoveAt(0);
            _listOfEntropyByteArrays.TrimExcess();

            prn = prn % integerMaxExclusive;
            return prn;
        }

        public BigInteger Next(BigInteger minIntValueInclusive, BigInteger maxIntValueExclusive)
        {
            BigInteger minMaxDifference = maxIntValueExclusive - minIntValueInclusive;
            BigInteger prn = new BigInteger(sha256.ComputeHash(_listOfEntropyByteArrays[0]));
            prn = BigInteger.Abs(prn);
            
            // Hashes the current entropy value and stores the hash as the basis for the next psuedorandom value.
            _listOfEntropyByteArrays.Add(sha512.ComputeHash(_listOfEntropyByteArrays[0]));
            _listOfEntropyByteArrays.RemoveAt(0);
            _listOfEntropyByteArrays.TrimExcess();

            prn = (prn % minMaxDifference) + minIntValueInclusive;
            return prn;
        }

        public byte[] HashedSeedByte
        { get { return _hashedSeedByte; } }
    }
}
