using System;


namespace DateTime_Practice
{
    internal class Program
    {
        static void Main()
        {
            //  Use DateTime.Now to give the current datetime.
            Console.WriteLine($"The current date time is {DateTime.Now}.");
            Console.WriteLine("Give me a number of hours to calculate forward: ");

            //  Convert answer to int and feed that to DateTime.AddHours(answer); In this we can simply chain the methods...
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The new date time after adding {answer} hours is {DateTime.Now.AddHours(answer)}.");
        }
    }
}
