using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var ten = 10;
            var three = 3;

            Console.WriteLine((float)ten / (float)three);
            // if the float parses is not present, the result will be 3, because both 10 and 3 are integers.


            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b * c);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);

            var oneString = "1";
            var one = 1;

            // Console.WriteLine(oneString == one); 
            // Gives build error. It's not equal javascript, which try to converts

            Console.WriteLine(int.Parse(oneString) == one);

            Console.WriteLine(b < a || b < c);
        }
    }
}
