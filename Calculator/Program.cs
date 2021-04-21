using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                var a = Console.ReadLine();
                
                Console.Write("Enter second number: ");
                var b = Console.ReadLine();
                
                Console.WriteLine($"{a} + {b} = {parse(a, b)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Operation could not be finished!");
            }
        }

        static int parse(string a, string b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }
    }
}