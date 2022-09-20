using System;
using System.Xml;

namespace Class_Practice
{
    internal class Program
    {
        static void Main()
        {
            //  Declaring a const
            const string conversion = "The conversion for Celsius to Fahrenheit is (Celsius * 9 / 5) + 32.";

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
            Console.WriteLine(conversion);
            Console.WriteLine($"20 degrees Celsius is {TemperatureConversion.CelsiusToFahrenheit("20")} degrees Fahrenheit.");

            //  New stuff from Step 385.
            Console.WriteLine("What city are you in?");
            //  C# allows var declarations -- I'm using this here since the type should be obvious as Console.ReadLine() only returns strings.
            var cityName = Console.ReadLine();
            Console.WriteLine("What's the current temperature in Fahrenheit there?");
            int currentTemp = Convert.ToInt32(Console.ReadLine());
            //  This is from an overloaded constructor but I pass both values instead of a default.
            Location userLocation = new Location(cityName, currentTemp);
            double celsisusAtLocation = TemperatureConversion.FahrenheitToCelsius(currentTemp);
            Console.WriteLine($"\nThe current temp in {userLocation.City} is {userLocation.TemperatureOutside} degrees Fahrenheit, or {celsisusAtLocation} degrees Celsius.");

            //  Keeping the console open.
            Console.ReadLine();
        }
    }
}
