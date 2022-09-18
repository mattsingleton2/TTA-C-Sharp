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

            //  Calling method. 
            msingleton.SayName();

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
