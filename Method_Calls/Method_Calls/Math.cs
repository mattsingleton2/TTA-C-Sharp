using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Calls
{
    public class CustomMath
    {
        public int Addition(int num1)
        {
            return num1 + 2;
        }

        public int Division(int num1)
        {
            try
            {
                return num1 / 2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public int Multiplication(int num1)
        {
            return num1 * 2;
        }
    }
}
