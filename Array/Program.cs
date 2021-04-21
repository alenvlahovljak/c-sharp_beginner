using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = new int[3];
            // or
            // var numbers = new int[3];
            // numbers[0] = 1;
            // Console.WriteLine(numbers[0]);
            // Console.WriteLine(numbers[1]);
            // Console.WriteLine(numbers[2]);

            // var flags = new bool[3];
            // flags[0] = true;
            //
            // Console.WriteLine(flags[0]);
            // Console.WriteLine(flags[1]);
            // Console.WriteLine(flags[2]);

            // var names = new string[3] {"Jack", "John", "Mary"};
            //
            // Console.WriteLine(names[0]);
            // Console.WriteLine(names[1]);
            // Console.WriteLine(names[2]);

            var numbers = new[] {3, 7, 9, 2, 14, 6};
            
            // Length
            Console.WriteLine($"Length: {numbers.Length}");
            
            // IndexOf()
            var index = System.Array.IndexOf(numbers, 9);
            Console.WriteLine($"Index of 9: {index}");
            
            // Clear()
            // set item to 0
            System.Array.Clear(numbers, 0, 2);
            foreach (var number in numbers)
            {
                Console.WriteLine($"number: {number}");
            }
            
            // Copy()
            var newNumbers = new int [3];
            System.Array.Copy(numbers, newNumbers, 3);
            foreach (var newNumber in newNumbers)
            {
                Console.WriteLine($"New number: {newNumber}");
            }
            
            // Sort()
            System.Array.Sort(numbers);
            foreach (var newNumber in numbers)
            {
                Console.WriteLine($"Sort number: {newNumber}");
            }
            
            // Reverse()
            System.Array.Reverse(newNumbers);
            foreach (var newNumber in newNumbers)
            {
                Console.WriteLine($"Reverse number: {newNumber}");
            }
        }
    }
}