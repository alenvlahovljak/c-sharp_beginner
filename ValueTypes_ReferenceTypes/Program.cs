using System;

namespace ValueTypes_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a:{a}\nb:{b}");

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[1] = 0;
            Console.WriteLine($"array1: {String.Join(", ", array1)} | array2: {String.Join(", ", array2)}");
        }
    }
}