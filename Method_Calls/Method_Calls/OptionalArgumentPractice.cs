using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Calls
{
    internal class OptionalArgumentPractice
    {
        //  Establishing a class with an optional parameter instead of requiring it.
        public int Multiplication(int num1, int num2 = 5)
        {
            try
            {
                return num1 * num2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

    }
}
