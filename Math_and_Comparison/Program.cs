using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //  Person 1 details and gathering.
            Console.WriteLine("What's the first person's hourly rate? ");
            string p1_hourly = Console.ReadLine();
            decimal p1_hourly_converted = Convert.ToDecimal(p1_hourly);
            Console.WriteLine(p1_hourly_converted);
            Console.WriteLine("What's the first person's Hours Worked Per Week?");
            string p1_weekHours = Console.ReadLine();
            decimal p1_weekHours_converted = Convert.ToDecimal(p1_weekHours);

            //  Person 2 details and gathering.
            Console.WriteLine("What's the second person's hourly rate? ");
            string p2_hourly = Console.ReadLine();
            decimal p2_hourly_converted = Convert.ToDecimal(p2_hourly);
            Console.WriteLine(p1_hourly_converted);
            Console.WriteLine("What's the second person's Hours Worked Per Week?");
            string p2_weekHours = Console.ReadLine();
            decimal p2_weekHours_converted = Convert.ToDecimal(p2_weekHours);

            //  Salary Calculations. I wrote a Salary method below.
            Console.WriteLine("Annual Salary of Person 1: $" + Salary(p1_weekHours_converted, p1_hourly_converted) + "/yr");
            Console.WriteLine("Annual Salary of Person 2: $" + Salary(p2_weekHours_converted, p2_hourly_converted) + "/yr");

            //  Salary Comparisons
            //  Starting by instantiating easy reference variables so I type less...
            decimal p1_salary = Salary(p1_weekHours_converted, p1_hourly_converted);
            decimal p2_salary = Salary(p2_weekHours_converted, p2_hourly_converted);

            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.WriteLine(p1_salary > p2_salary);

            //  Just keeping the console open.
            Console.ReadLine();
        }

        private static decimal Salary(decimal hours, decimal rate)
        {
            //  52 weeks in a year. Hours per week * rate * 52 weeks = salary.
            decimal salary = (hours * rate) * 52;
            return salary;
        }
    }
}
