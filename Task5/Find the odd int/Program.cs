using System;
using NUnit.Framework;
using System.Linq;

namespace Find_the_odd_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual(11, Kata.find_it(new[] {11}));
        }
    }

    class Kata
    {
        public static int find_it(int[] seq)
        {
            int c = seq[0];
            for (int i = 0; i < seq.Length; i++)
            {
                
                c = seq[i];
                if (seq.Count(x=> x == c) % 2 == 1) break;
            }
            return c;
        }
    }
}
