using System;

namespace Abstract_Class_Practice
{
    internal class Program
    {
        static void Main()
        {
            //  Instantiating object
            Employee msingleton = new Employee() { FirstName = "Matthew", LastName = "Singleton", Id = 1 };
            Employee jsingleton = new Employee() { FirstName = "Jenna", LastName = "Singleton", Id = 2 };

            //  Instantiate Object of IQuittable Interface type
            IQuittable jtest = new Employee() { FirstName = "Joe", LastName = "Test", Id = 3 };

            //  Calling method. 
            msingleton.SayName();
            
            // jtest.SayName(); will not work due to polymorphism - the IQuittable interface doesn't have access to this Method.

            //  Calling method inherited by the interface.
            msingleton.Quit();

            //  Using my new comparison operators to see if this checks out... first let's just see if we can compare the objects...
            Console.WriteLine(msingleton == jsingleton);    //  Returns False!! :) 
            Console.WriteLine(msingleton == msingleton);    //  Returns True! :D Ok, this is pretty cool...

            //  Check the != operator.
            Console.WriteLine(msingleton != jsingleton);
            Console.WriteLine(msingleton != msingleton);
        }
    }
}
