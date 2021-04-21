using System;

namespace ReferneceTypeExample
{
    public class Car
    {
        public int YearOfProduction;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // It's a value type
            // Outside of main method, variable doesn't have meaning
            var number = 1;
            // When we pass variable as an argument
            // to the increment method, a copy of this
            // variable is taken and send to Increment method
            Increment(number);

            Console.WriteLine($"number: {number}"); // 1

            var car = new Car() {YearOfProduction = 1978};
            MakeOld(car);
            Console.WriteLine($"Car is produced in: {car.YearOfProduction}");
        }

        public static void Increment(int number)
        {
            // 
            Console.WriteLine($"Increment - pre: {number}"); // 1
            number += 10;
            Console.WriteLine($"Increment - post: {number}"); // 11
        }

        // type of this parameter is a reference type
        // both car will be pointing to the same object on the heap
        public static void MakeOld(Car car)
        {
            car.YearOfProduction -= 10;
        }
    }
}