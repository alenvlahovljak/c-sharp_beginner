using System;

namespace TimeSpanObj
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);

            // var timeSpan1 = new TimeSpan(10, 0, 0);
            // timespan
            var timeSpan1 = TimeSpan.FromDays(10);
            Console.WriteLine(timeSpan1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(7);
            var duration = start - end;
            //this is timespan
            Console.WriteLine($"Duration: {duration}");

            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Total minutes: {timeSpan.TotalMinutes}");
            
            // Add
            Console.WriteLine($"Add example: {timeSpan.Add(TimeSpan.FromMinutes(8))}");
            // Subtract
            Console.WriteLine($"Add example: {timeSpan.Subtract(TimeSpan.FromMinutes(2))}");
            
            // ToString
            Console.WriteLine($"ToString: {timeSpan.ToString()}");
            
            // Parse
            Console.WriteLine($"Parse: {TimeSpan.Parse("01:02:03")}");
        }
    }
}