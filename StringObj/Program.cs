using System;
using System.Collections.Generic;

namespace StringObj
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "John Smith ";
            // Trim()
            Console.WriteLine($"Trim: '{fullName.Trim()}'");

            // ToUpper()
            Console.WriteLine($"Trim: '{fullName.ToUpper()}'");

            // var index = fullName.IndexOf(" ");
            // var firstName = fullName.Substring(0, index);
            // var lastName = fullName.Substring(index + 1);
            // Console.WriteLine($"First name: {firstName}, Last name: {lastName}");

            // Split()
            var names = fullName.Split(" ");
            Console.WriteLine($"First name: {names[0]}, Last name: {names[1]}");

            // Replace
            Console.WriteLine($"Replace: {fullName.Replace("John", "Adam")}");

            // if (String.IsNullOrEmpty(" ".Trim()))
            if (String.IsNullOrWhiteSpace(""))
            {
                Console.WriteLine("Invalid!");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine($"age: {age}");

            float price = 29.56f;
            Console.WriteLine($"Price: {price.ToString("C")}");
            Console.WriteLine($"{price}");

            var sentence =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam a urna et tortor scelerisque venenatis at a massa. Curabitur suscipit ante id nibh fringilla placerat.";
            var summary = StringUtility.SummerizeText(sentence, 28);
            Console.WriteLine($"Summerize: {summary}");
        }
        
    }
}