using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 3, 1);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.AddYears(4));
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToShortTimeString());
            Console.WriteLine(dateTime.ToString("dddd, yyyy"));
        }
    }
}