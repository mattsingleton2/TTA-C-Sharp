using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Practice
{
    public interface IQuittable
    {
        //  Creates a contract for any inheriting classes -- this method must be defined since it's abstract here. If we'd defined it here, those classes 
        //  that inherit would just have access to it. 
        void Quit();
    }
}
