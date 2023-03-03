using System;
using NUnit.Framework;
using System.Linq;

namespace Complementary_DNA
{
    public class Program
    {

        static void Main(string[] args)
        {
            SampleTests("AAAA", "TTTT");
            SampleTests("ATTGC", "TAACG");
            SampleTests("GTAT", "CATA");
            SampleTests("AAGG", "TTCC");
            SampleTests("CGCG", "GCGC");
            SampleTests("ATTGC", "TAACG");
            SampleTests("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT");

            static void SampleTests(string dna, string expected)
            {
                Assert.AreEqual(expected, DnaStrand.MakeComplement(dna));
                Console.WriteLine($"{expected},  {DnaStrand.MakeComplement(dna)}");
            }
        }
    }

    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
             
            return string.Concat(dna.Select(x => x == 'A' ? x = 'T' : (x == 'T' ? x = 'A' : (x == 'C' ? x = 'G' : (x == 'G' ? x = 'C' : ' ')))));
        }
    }
}
