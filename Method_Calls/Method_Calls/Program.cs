using System;

namespace Method_Calls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Take in some numbers.
            Console.WriteLine("Hello! Please pick two numbers and we'll do addition, division and multiplication on them.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            //  Can't use a class without instantiating an object for it, so let's do that.
            CustomMath cmathObject = new CustomMath();

            //  Let's give the user what they asked for.
            Console.WriteLine("Here's the addition Result: " + cmathObject.Addition(num1, num2));
            Console.WriteLine("Here's the division Result: " + cmathObject.Division(num1, num2));
            Console.WriteLine("Here's the multiplication Result: " + cmathObject.Multiplication(num1, num2));
        }
    }
}
