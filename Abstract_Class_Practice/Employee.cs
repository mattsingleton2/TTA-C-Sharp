using System;


namespace Abstract_Class_Practice
{
    public class Employee : Person, IQuittable
    {
        //  Defining the method that inheriting the Person class contracted us to define...
        public override void SayName()
        {
            Console.WriteLine($"Hello, {FirstName} {LastName}.");
        }

        //  Defining the method that inheriting the IQuittable Interface contracted us to define...
        public void Quit()
        {
            Console.WriteLine($"We're sorry to see you go, {FirstName} {LastName}...");
        }
    }
}
