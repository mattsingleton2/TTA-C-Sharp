using System;

namespace Abstract_Class_Practice
{
    internal class Program
    {
        static void Main()
        {
            //  Instantiating object
            Employee msingleton = new Employee() { FirstName = "Matthew", LastName = "Singleton" };

            //  Calling method. 
            msingleton.SayName();
        }
    }
}
