using System;

namespace NonPrimitiveTypes.person
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}.");
        }
    }
}