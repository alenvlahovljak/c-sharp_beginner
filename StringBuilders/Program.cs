using System;
using System.Text;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            // we won't get searching methods
            var builder = new StringBuilder("Hello World!");
            // it returns StringBuilder, so we can chain methods
            builder.Append('-', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('-', 10);
            Console.WriteLine($"Builder 1: \n{builder}");

            builder.Replace('-', '+');
            Console.WriteLine($"Builder 2: \n{builder}");

            builder.Remove(0, 10);
            Console.WriteLine($"Builder 3: \n{builder}");

            builder.Insert(0, new string('/', 10));
            Console.WriteLine($"Builder 4: \n{builder}");

            Console.WriteLine($"Builder 5 - first character: \n{builder[0]}");
        }
    }
}