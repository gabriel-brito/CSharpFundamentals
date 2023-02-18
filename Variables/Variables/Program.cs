using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte number = 255;
            // int count = 10;
            // float totalPrice = 20.95f;
            // char character = 'A';
            // string firstName = "Gabriel";
            // bool isLearning = true;

            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Gabriel";
            var isLearning = true;
            
            // The keyword "var" identifies the type withtout the need to explic it.

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isLearning);

            // --- //

            Console.WriteLine("{0} {1} {2} {3} {4} {5}", number, count, totalPrice, character, firstName, isLearning);
        }
    }
}
