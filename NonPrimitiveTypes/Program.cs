using NonPrimitiveTypes.person; 

namespace NonPrimitiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            person1.FirstName = "John";
            person1.LastName = "Smith";
            person1.Introduce();
        }
    }
}