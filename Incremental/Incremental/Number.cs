using System;
using System.Collections.Generic;
using System.Numerics;

namespace Incremental
{
    public class Number
    {
        public static Random random = new Random();
        public static BigInteger logBase = 2;

        public static BigInteger GetRandomBigInteger(BigInteger max)
        {
            if(max < int.MaxValue)
            {
                return random.Next((int) max) + 1;
            }
            byte[] data = max.ToByteArray();
            random.NextBytes(data);
            BigInteger r = (new BigInteger(data) % max) + 1;
            if (r > 0) return r;
            else return 1;
        }

        public static int clamp(int a, int min, int max)
        {
            return Math.Min(Math.Max(a, min), max);
        }
    }
}