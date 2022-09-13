using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //  Person 1 details and gathering.
            Console.WriteLine("What's the first person's hourly rate? ");
            decimal p1_hourly = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("What's the first person's Hours Worked Per Week?");
            decimal p1_weekHours = Convert.ToDecimal(Console.ReadLine());
            
            //  Person 2 details and gathering.
            Console.WriteLine("What's the second person's hourly rate? ");
            decimal p2_hourly = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("What's the second person's Hours Worked Per Week?");
            decimal p2_weekHours = Convert.ToDecimal(Console.ReadLine());
            
            //  Salary Calculations. I wrote a Salary method below.
            Console.WriteLine("Annual Salary of Person 1: $" + Salary(p1_weekHours, p1_hourly) + "/yr");
            Console.WriteLine("Annual Salary of Person 2: $" + Salary(p2_weekHours, p2_hourly) + "/yr");

            //  Salary Comparisons
            //  Starting by instantiating easy reference variables so I type less...
            decimal p1_salary = Salary(p1_weekHours, p1_hourly);
            decimal p2_salary = Salary(p2_weekHours, p2_hourly);

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
