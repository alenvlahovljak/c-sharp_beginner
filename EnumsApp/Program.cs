using System;

namespace EnumsApp
{
    // public enum ShippingMethod
    // {
    //     // always explicitly set enum values
    //     RegularAirMail,
    //     RegisteredAirMail,
    //     Express
    // }

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.RegisteredAirMail;
            // we have to cast to the integer to get integer,
            //otherwise it will write name
            Console.WriteLine(method);
            Console.WriteLine((int) method);

            // convert a number to a enum's shipping method
            // we can use casting
            var methodId = 3;
            Console.WriteLine((ShippingMethod) methodId);
            
            // convert to a string
            // if we didn't call ToString()
            // Console.WriteLine would still convert that with ToString() method
            Console.WriteLine($"{method.ToString()}");
            
            // string to enum
            var methodName = "RegularAirMail";
            // when we have Type as an argument we use typeof()
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}