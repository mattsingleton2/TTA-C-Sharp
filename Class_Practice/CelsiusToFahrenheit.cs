using System;


namespace Class_Practice
{
    public static class TemperatureConversion
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            //  Convert string to double...
            double celsius = Convert.ToDouble(Convert.ToInt32(temperatureCelsius));

            //  Celsius to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(int currentTemp)
        {
            //  Convert int to double....
            double fahrenheit = Convert.ToDouble(Convert.ToInt32(currentTemp));

            //  Fahrenheit to Celsius
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }
}
