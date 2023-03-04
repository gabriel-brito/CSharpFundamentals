using System;

namespace Classes
{
    public class Person 
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("Hello, I am {0} {1}", firstName, lastName);
        }
    }
}
