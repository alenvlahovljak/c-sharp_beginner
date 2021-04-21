using System;

namespace ProceduralProgramming1
{
    class Program
    {
        static void Main(string[] args)
            // Reverse the name that user input
        {
            Console.WriteLine("What's your name");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);

            Console.WriteLine($"Reversed name: {reversed}");
        }

        public static string ReverseName(string name)
        {
            var arr = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                arr[name.Length - i] = name[i - 1];
            }

            return new string(arr);
        }
    }
}