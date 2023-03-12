using NUnit.Framework;
using System;
using System.Linq;


namespace Array.diff
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
                
                Assert.AreEqual(new int[] { 1, 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
                Assert.AreEqual(new int[] { 2 }, Kata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
                Assert.AreEqual(new int[] { 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
                Assert.AreEqual(new int[] { 1 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
                Assert.AreEqual(new int[] { 1, 2, 2 }, Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
                Assert.AreEqual(new int[] { }, Kata.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
                Assert.AreEqual(new int[] { 3 }, Kata.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));

        }
    }
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {

            if (a.Length == 0 || b.Length == 0)
            {
                return a;
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    int x = a[i];
                    for (int j = 0; j < b.Length; j++)
                    {
                        int y = b[j];
                        if (x == y)
                        {
                            a[i] = -1;
                            break;
                        }
                    }
                }

                var intList = a.ToList();
                for (int i = 0; i < intList.Count; i++)
                {
                    if (intList[i] == -1)
                    {
                        intList.RemoveAt(i);
                        i--;
                    }
                }
                int[] a1 = intList.ToArray();
                return a1;
            }
        }
    }
}
