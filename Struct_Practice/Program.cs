using System;

namespace Struct_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Create an object of data type Number and assign an amount to it
            Number userAmount = new Number
            {
                Amount = 1.50m
            };

            //  Print this amount to the console.
            Console.WriteLine(userAmount.Amount);
            Console.ReadLine();
        }
    }
}
