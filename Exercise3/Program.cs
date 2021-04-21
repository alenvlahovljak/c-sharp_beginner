using System;

namespace Exercise3
{
    class Program
        // Write a program and ask the user to enter the width and height of an image.
        // Then tell if the image is landscape or portrait.
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the width:");
                var width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the height:");
                var height = Convert.ToInt32(Console.ReadLine());
                
                if(height > width)
                    Console.WriteLine("It's portrait!");
                else if(height < width)
                    Console.WriteLine("It's landscape!");
                else
                    Console.WriteLine("Neither landscape or portrait!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot finish the action!");
            }
        }
    }
}