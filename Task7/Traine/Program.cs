using System;

namespace Traine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            var age = checked((byte) int.Parse(Console.ReadLine()));
            
            var howItall = 162;
            var myshoe = 37.5;
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.WriteLine("What is my grouth? {0} sm", howItall);
            Console.WriteLine("What is my shoe size? {0}", myshoe);

            Console.ReadKey();
        }
    }
}
