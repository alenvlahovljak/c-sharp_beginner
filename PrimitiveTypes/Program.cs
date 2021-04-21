using System;

namespace PrimitiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // var number = 2;
            // var count = 10;
            // var totalPrice = 20.95f;
            // // convert to char
            // var character = "A";
            // var str = "Helo World!";
            // var isWorking = true;
            //
            // Console.WriteLine(number);
            // // snippet: cw
            // Console.WriteLine(count);
            // Console.WriteLine(totalPrice);
            // Console.WriteLine(character);
            // Console.WriteLine(str);
            // Console.WriteLine(isWorking);
            // it will throw an error if we exceed the data type max possible value
            // checked
            // {
            //     byte num = 255;
            //     num += 1;
            //     Console.WriteLine("Hello World! " + num);
            // } 
            // template string
            // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            // Console.WriteLine($"{int.MaxValue} {int.MinValue}");

            // const float Pi = 3.14f;
            // explicit type conversion
            // int i = 1;
            // // byte is target type - this is called casting
            // byte b = (byte) i;
            //
            // float f = 1.0f;
            // int integer = (int) f;
            //
            // // Non-compatible types
            // string s = "str";
            // int newInteger = (int) s; // won't compile
            //
            // // If we want to convert string to the number
            // string str = "1";
            // int toInt = Convert.ToInt32(s);
            // int j = int.Parse(s);

            // byte b = 1;
            // int i = b;
            // Console.WriteLine(i);

            // int i = 1;
            // byte b = i; Cannot convert type 'int' to 'byte'
            // byte b = (byte) i;
            // byte b2 = Convert.ToByte(i);
            // Console.WriteLine($"{b} {b2}");

            // string number = "1234";
            // // int stringToNumber = (int) number; this won't work because we cannot convert type 'string' to 'int'
            // int stringToNumber = Convert.ToInt32(number);
            // Console.WriteLine($"{number} {stringToNumber}");
            // try
            // {
            //     var largeNumber = "123343";
            //     byte newByte = Convert.ToByte(largeNumber);
            //     Console.WriteLine(newByte);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("The number could not be converted to a byte.");
            //     // throw;
            // }
            // try
            // {
                // string str = "true";
                // it cannot handle castring in try/catch
                // bool strToBoolean = (bool) str;  //it won't work, they're not compatible so we cannot use explicit casting
                // bool strToBoolean = Convert.ToBoolean(str);
                // Console.WriteLine(strToBoolean);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Cannot convert to a boolean.");
            //     throw;
            // }
            
            
        }
    }
}