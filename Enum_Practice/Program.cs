using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Enum_Practice
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                //  Ask user for info..
                Console.WriteLine("Please enter the name of the current day: ");

                //  Store the response into data type Day (Enumerated in Days.cs)
                //  We need to parse the string response as a Day Data Type though
                //  So using (Day)Enum.Parse(typeof(Day) will take the string and attempt
                //  to convert it to one of our enumerables.
                Day userDay = (Day)Enum.Parse(typeof(Day), Console.ReadLine());
            } catch
            {
                //  If we got an exception, let's not get picky, just tell them to try to enter a real day.
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
}
