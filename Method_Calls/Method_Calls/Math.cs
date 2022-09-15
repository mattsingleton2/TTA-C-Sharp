using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Calls
{
    public class CustomMath
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public decimal Division(decimal num1, decimal num2)
        {
            try
            {
                decimal result = num1 / num2;
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
