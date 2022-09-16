using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Calls
{
    internal class MultiMath
    {
        public int Operation(int num1)
        {
            return num1 + 1;
        }

        public int Operation(decimal num1)
        {
            //Converting the decimal input to an int since I have to return an int. Another way to do this is commented out below for a thorough submission.
            return Convert.ToInt32(num1) * 2; 

            //  Alternate way to handle this ... Instead of converting the input, I run the operation and convert the result of that operation's decimal to an integer instead.
            //  decimal answer = num1 * 2;
            //  return Convert.ToInt32(answer);
                     
        }

        public int Operation(string num1)
        {
            //  Try to convert the string to an integer if possible. Using a Try/Catch block to display the error message instead if the conversion fails.
            try
            {
               int modifiedStringAsInt = Convert.ToInt32(num1);
               return modifiedStringAsInt / 2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        

    }
}
