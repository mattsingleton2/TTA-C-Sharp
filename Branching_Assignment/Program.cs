using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main()
        {
            //  Grabbing some info...
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does the package weigh?");
            decimal package_weight = Convert.ToDecimal(Console.ReadLine());
            
            //  Check package weight, if over 50, decline order. Otherwise, keep goin'.
            if (package_weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            //  Keep goin'.
            else
            {
                Console.WriteLine("How wide is the package?");
                decimal package_width = Convert.ToDecimal(Console.ReadLine());
                
                Console.WriteLine("How tall is the package?");
                decimal package_height = Convert.ToDecimal(Console.ReadLine());
                
                Console.WriteLine("How long is the package?");
                decimal package_length = Convert.ToDecimal(Console.ReadLine());
                
                //  Check to see if the package size is too big, otherwise, offer quote.
                if ((package_height + package_length + package_width) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                } else
                {
                    //  Quote calculation = package area * weight / 100.
                    decimal quote = ((package_height * package_length * package_width) * package_weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is $" + quote +"\nThank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
