using System;

namespace Exercise2
{
    // Write a program which takes two numbers from the console and
    // displays the maximum of the two.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                var a = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Enter second number: ");
                var b = Convert.ToInt32(Console.ReadLine());

                if(a < b)
                {
                    Console.WriteLine($"Largest number is: {b}.");
                } else if (a > b)
                {
                    Console.WriteLine($"Largest number is: {a}.");
                }
                else
                {
                    Console.WriteLine($"The're equal!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Operation could not be finished!");
            }
        }
    }
}