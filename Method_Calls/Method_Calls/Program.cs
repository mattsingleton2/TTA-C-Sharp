using System;

namespace Method_Calls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Can't use a class without instantiating an object for it, so let's do that.
            CustomMath cmathObject = new CustomMath();

            //  Take in some numbers.
            Console.WriteLine("Hello! Please pick a number and we'll do addition, division and multiplication on them.");
            try
            {
                //  Doing this because when I spammed my numbers to get through the program I hit a stack overflow exception, so just accounting for that.
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Here's the addition Result: " + cmathObject.Addition(num1));
                Console.WriteLine("Here's the division Result: " + cmathObject.Division(num1));
                Console.WriteLine("Here's the multiplication Result: " + cmathObject.Multiplication(num1));
            }
            catch (Exception e)
            {
                //  This will just log that error message whether it's a stack overflow or just failed.
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n------------BEGIN STEP 279------------\n");


            //  Main Method Submission Assignment Step 279 START
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


            Console.WriteLine("\n------------BEGIN STEP 280------------\n");

            //  Main Method Submission Assignment Step 280 START
            //  Begin by instantiating our new class object to handle optional parameter passing.
            OptionalArgumentPractice optArg = new OptionalArgumentPractice();

            //  Ask user to input 2 numbers, one at a time. Let them know the second number's optional.
            Console.WriteLine("We need at least one integer, but you can put two if you'd like. If you don't want to put the second one in, simply hit Enter...");
            int numOpt1 = Convert.ToInt32(Console.ReadLine());

            //  Attempt to see if we can convert the second entry (or lack thereof) to an integer. If not, we'll just call the method with one argument.
            try
            {
                int numOpt2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Here, I'm passing both numbers (Defaulting Value 5 if one wasn't entered for the second number: " + optArg.Multiplication(numOpt1, numOpt2));
            }
            catch
            {
                Console.WriteLine("Here, I'm only passing the first number and not even letting the method receive the second number or lack thereof: " + optArg.Multiplication(numOpt1));
            }


            Console.WriteLine("\n------------BEGIN STEP 281------------\n");

            //  Main Method Submission Assignment Step 281 START
            //  Begin by instantiating our new class object to handle parameters.
            VoidMethod voidObj = new VoidMethod();

            //  Pass two integers..
            Console.WriteLine("Passing the void method integers 100 and 200...");
            //  Requirement : Pass these parameters in as named arguments, so used num1 and num2 as described in the class Method.
            voidObj.VoidCalculation(num1: 100, num2: 200);
        }
    }
}
