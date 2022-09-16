using System;

namespace Method_Calls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Take in some numbers.
            Console.WriteLine("Hello! Please pick a number and we'll do addition, division and multiplication on them.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            //  Can't use a class without instantiating an object for it, so let's do that.
            CustomMath cmathObject = new CustomMath();

            //  Let's give the user what they asked for.
            Console.WriteLine("Here's the addition Result: " + cmathObject.Addition(num1));
            Console.WriteLine("Here's the division Result: " + cmathObject.Division(num1));
            Console.WriteLine("Here's the multiplication Result: " + cmathObject.Multiplication(num1));
            Console.WriteLine("\n------------BEGIN STEP 279------------\n");


            // Main Method Submission Assingnment Step 279 START
            //  Begin by instantiating the class with an object...
            MultiMath mmathObject = new MultiMath();

            //  Overload # 1 gathering
            Console.WriteLine("Let's have an integer, please.");
            int numOverload1 = Convert.ToInt32(Console.ReadLine());

            //  Overload # 2 gathering
            Console.WriteLine("Pick a decimal. For example, maybe 10.50");
            decimal numOverload2 = Convert.ToDecimal(Console.ReadLine());

            //  Overload # 3 gathering. 
            Console.WriteLine("Finally, type a number as a string. For Example, Try using \"10\" and we won't modify it -- it will be left as a string.");
            string numOverload3 = Console.ReadLine();

            //  Overload # 1 method call. This is an int.
            Console.WriteLine("Overload Method One Returned...: " + mmathObject.Operation(numOverload1));

            //  Overload # 2 method call. This is a decimal.
            Console.WriteLine("Overload Method Two Returned...: " + mmathObject.Operation(numOverload2));

            //  Overload # 3 method call. This is a string.
            Console.WriteLine("Overload Method Three Returned...: " + mmathObject.Operation(numOverload3));

        }
    }
}
