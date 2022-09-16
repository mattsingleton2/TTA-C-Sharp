using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice
{
    public class Operations
    {
        public void DivByTwo(int num1, out int result) => result = num1 / 2;

        public string Greeting(string name, out string greeting) => greeting = $"Hello, {name}!";

        public string Greeting(string name, string timeOfDay, out string greeting) => greeting = $"Hello, {name}! Good {timeOfDay}!";
    }
}
