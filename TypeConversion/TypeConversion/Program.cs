using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type Conversion 
            // ------------------------

            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            // Explicit Type Conversion
            // ------------------------

            // byte newB = i;
            // Cannot implicit convert "int" to a "byte"

            byte newByte = (byte)i;
            Console.WriteLine(newByte);

            // Non-Compatible Types
            // -------------------------

            string number = "1234";

            // int newNumber = (int)number;
            // CS0030 - Cannot convert "string" to "int"

            int conversion = Convert.ToInt32(number);
            int newNumber = int.Parse(number);

            Console.WriteLine("{0} {1}", "with convert class: " + conversion, "- with int parse: " + newNumber);

        }
    }
}
