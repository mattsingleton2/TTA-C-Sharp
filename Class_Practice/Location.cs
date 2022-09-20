using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice
{
    internal class Location
    {
        public Location(string city) : this(city, 72)
        {

        }
        public Location(string city, int temperatureOutside)
        {
            City = city;
            TemperatureOutside = temperatureOutside;
        }

        public string City { get; set; }
        public int TemperatureOutside { get; set; }
    }
}
