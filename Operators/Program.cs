using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 1;
            // int c = 2;
            // int b = a++;
            // a = c++;
            // // a: 2, b: 1, c: 3
            // Console.WriteLine($"{a} {b} {c}");

            var a = 1;
            var b = 2;
            var c = 3;

            // Console.WriteLine((float)a / (float)b);
            // Console.WriteLine(a + (b * c));
            // //this is the same as the next example
            // Console.WriteLine(!(a != b));
            // Console.WriteLine(a == b);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
            
        }
    }
}