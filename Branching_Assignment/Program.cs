using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Grabbing some info...
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does the package weigh?");
            string package_weight = Console.ReadLine();
            decimal package_weight_converted = Convert.ToDecimal(package_weight);

            //  Check package weight, if over 50, decline order. Otherwise, keep goin'.
            if (package_weight_converted > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            //  Keep goin'.
            else
            {
                Console.WriteLine("How wide is the package?");
                string package_width = Console.ReadLine();
                decimal package_width_converted = Convert.ToDecimal(package_width);
                Console.WriteLine("How tall is the package?");
                string package_height = Console.ReadLine();
                decimal package_height_converted = Convert.ToDecimal(package_height);
                Console.WriteLine("How long is the package?");
                string package_length = Console.ReadLine();
                decimal package_length_converted = Convert.ToDecimal(package_length);
                //  Check to see if the package size is too big, otherwise, offer quote.
                if ((package_height_converted + package_length_converted + package_width_converted) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                } else
                {
                    //  Quote calculation = package area * weight / 100.
                    decimal quote = ((package_height_converted * package_length_converted * package_width_converted) * package_weight_converted) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is $" + quote +"\nThank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
