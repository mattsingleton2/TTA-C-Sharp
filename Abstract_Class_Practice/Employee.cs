using System;


namespace Abstract_Class_Practice
{
    public class Employee : Person, IQuittable
    {
        //  Only employees will have id's, not people, so I'm defining that parameter here instead of in the Person class...
        public int Id { get; set; }


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

        //  Create an overload on the == / != operands so that it checks if the Employee object is equal by comparing the ID property
        public static bool operator== (Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool operator!= (Employee employee, Employee employee2)
        {
            if (employee.Id != employee2.Id)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
