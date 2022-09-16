using System;

namespace Class_Practice
{
    internal class Program
    {
        static void Main()
        {
            //  Instantiating the class object.
            Operations operations = new Operations();

            //  Asking for input and handling the data type conversion.
            Console.WriteLine("Enter a number: ");
            int result = Convert.ToInt32(Console.ReadLine());

            //  Calling the method by passing in the user's result variable and letting the method update it.
            operations.DivByTwo(result, out result);

            //  Showing that it worked.
            Console.WriteLine($"Your number divided by two is: {result}.");

            //  Starting requirement #4 : Create a method with output parameters.
            string greeting;
            Console.WriteLine(operations.Greeting("Matt", out greeting));

            //  Requirement #5 : Create overload on method -- same thing, this one requires a time of day as well.
            greeting = "";
            Console.WriteLine(operations.Greeting("Matt", "morning", out greeting));

            //   Requirement #6 : Declare a class to be static. I should likely prove it works...
            Console.WriteLine($"20 degrees Celsius is {TemperatureConversion.CelsiusToFahrenheit("20")} degrees Fahrenheit.");
           
            //  Keeping the console open.
            Console.ReadLine();
        }
    }
}
