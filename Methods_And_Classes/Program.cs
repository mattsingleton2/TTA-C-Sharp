using System;

namespace Methods_And_Classes
{
    internal class Program
    {
        static void Main()
        {
            //  Instantiating and initializing in one line. Employee inherits from Person so it has access to the parameters within.
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student" };

            //  Calling Superclass method SayName() from the Person object.
            sample.SayName();
        }
    }
}
