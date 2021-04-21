using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number.
            // The number should be between 1 to 10. If the user enters
            // a valid number, display "Valid" on the console. Otherwise,
            // display "Invalid". (This logic is used a lot in applications where
            // values entered into input boxes need to be validated.)
            try
            {
                Console.WriteLine("Enter a number between 0 and 10: ");
                byte num = Convert.ToByte(Console.ReadLine());
                
                if (num == 0 || num > 10)
                {
                    Console.WriteLine("You entered an invalid number!");
                    return;
                }

                Console.WriteLine("Your number is valid!");
            }
            catch (Exception e)
            {
                Console.WriteLine("You enter either invalid number or a number outside of requested scope!");
            }
        }
    }
}