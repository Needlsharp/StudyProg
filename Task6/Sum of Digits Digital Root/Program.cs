using System;
using System.Linq;
using NUnit.Framework;

namespace Sum_of_Digits_Digital_Root
{

    public class Program
    {
        public static void Main(string[] args)
        {
            long n = 2984156454988465431;


            int[] arr = Calculate(n);

            while (arr.Length > 1)
            {
                n = arr.Sum();
                arr = Calculate(n);
            }

            Console.WriteLine(arr[0]);
            int[] Calculate(long n)
            {
                return n.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            }
        }

    }

}
