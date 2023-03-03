using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;



namespace Jaden_Casing_Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
                Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real", 
                "How can mirrors be real if our eyes aren't real".ToJadenCase(), 
                "Strings didn't match.");
            Console.WriteLine("How can mirrors be real if our eyes aren't real".ToJadenCase());
            
        }
        
    }
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            return string.Join(' ', phrase.Split(' ').Select((x, i)=>char.ToUpper(x[0])+new string (x.Remove(0,1))));
        }
    }
}
