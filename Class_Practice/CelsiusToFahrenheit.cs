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
    }
}
