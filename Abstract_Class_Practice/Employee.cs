using System;


namespace Abstract_Class_Practice
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello, {FirstName} {LastName}.");
        }
    }
}
