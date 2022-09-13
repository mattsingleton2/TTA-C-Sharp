using System;
using System.Text.RegularExpressions;

namespace Boolean_Do_While
{
    internal class Program
    {
        static void Main()
        {
            // Boolean comparison on the nameValidation bool...
            bool nameValidation = false;
            do
            {
                Console.WriteLine("Enter your first name: ");
                string firstName = Console.ReadLine();
                //  A little regex to capture the name and make sure it looks like an actual name instead of xXLordDeath32Xx or something.
                if (Regex.IsMatch(firstName, @"^[a-zA-Z- ]+$"))
                {
                    Console.WriteLine("Hello, " + firstName + "!");
                    nameValidation = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid name...");
                    nameValidation = false;
                }

            } while (nameValidation == false);
            
            Console.ReadLine();
        }
    }
}
