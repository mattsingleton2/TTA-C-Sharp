using System;
using System.Collections.Generic;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setting up try/catch block to deal with exceptions as they occur.
            try
            {
                // Build a list of ints, ask the user for a divisor, and display a message showing the results.
                List<int> ints = new List<int> { 10, 100, 1000, 10000, 50, 500, 50000, 17032 };
                Console.WriteLine("We have a list of numbers - Please select a number and we'll divide all the list's numbers by your number.");
                int userDivisor = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < ints.Count; i++)
                {
                    Console.WriteLine("\nDividing " + ints[i] + " by " + userDivisor + ".\nThis evaluates to " + ints[i]/userDivisor + ".");
                    
                }
            }
            // Catch the first exception - receiving a string instead of an integer.
            catch (FormatException e)
            {
                Console.WriteLine("Please type a whole number. Don't use letters.");
                return;
            }
            // Catch the second exception - user dividing by zero.
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero...");
            }
            // Catch any other exceptions that we didn't expect and just spit out the "scary" message for the user.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Let's move on with life! 
            finally
            {
                Console.WriteLine("We've left our try/catch block.");
                Console.ReadLine();
            }
            
        }
    }
}
