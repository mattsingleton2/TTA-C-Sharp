using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Practice
{
    public abstract class Person
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public abstract void SayName();

    }
}
