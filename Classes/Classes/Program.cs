using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            // Simplified way
            // var person = new Person
            // {
            //     firstName = "Gabriel",
            //     lastName = "Santos"
            // };

            var person = new Person();
            person.firstName = "Gabriel";
            person.lastName = "Santos";

            person.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(5, 5);

            Console.WriteLine(result);
        }
    }
}
