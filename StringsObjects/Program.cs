using System;

namespace StringsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // string firstName = "Alen";
            // All primitive types in C# map to type in .NET
            int number;
            
            // Strings are classes
            var firstName = "John";
            String lastName = "Smith";
            // same as String
            string middleName = "Little";

            var fullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);
            
            // This can be simplified using Verbatum string
            var text = "Hi John!\nLook into the following path:\nc:\\desktop\\alen\\c#_examples";
            Console.WriteLine(text);
            
            // Verbatum string
            var verbatumText = @"Hi John!
Look into the following path:
                     c:\desktop\alen\c#_examples";
            Console.WriteLine(verbatumText);
        }
    }
}

