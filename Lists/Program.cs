using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(5);
            
            // add on list array or another list
            numbers.AddRange(new int[4] {6, 7, 8, 7});
            foreach (var number in numbers)
            {
                Console.WriteLine($"numbers: {number}");
            }

            Console.WriteLine($"Index of 7: {numbers.IndexOf(7)}");
            Console.WriteLine($"Last index of 7: {numbers.LastIndexOf(7)}");
            // in array is .Length
            Console.WriteLine($"Count: {numbers.Count}");
        }
    }
}