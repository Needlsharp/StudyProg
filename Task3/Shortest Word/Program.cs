using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace Shortest_Word
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Assert.AreEqual(3, Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, Kata.FindShort("turns out random test cases are easier than writing out basic ones"));
            Assert.AreEqual(2, Kata.FindShort("Let's travel abroad shall we"));
        }
    }

    public class Kata
    {
        public static int FindShort(string s)
        {
            return s.Split(' ').Select(x => Convert.ToInt32(x.Length)).Min();
        }
    }
}

