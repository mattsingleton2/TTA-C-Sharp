using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Calls
{
    internal class VoidMethod
    {
        public void VoidCalculation (int num1, int num2)
        {
            int num3 = num1 * 10;
            Console.WriteLine("Returning the second argument anyway: " + num2);
        }
    }
}
