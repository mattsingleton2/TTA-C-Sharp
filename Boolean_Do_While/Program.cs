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
            
            
            //  Separate while loop...
            bool numberValid = false;
            while (!numberValid)
            {
                Console.WriteLine("Pick a number between 1 and 10");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber > 0 && userNumber <= 10)
                {
                    Console.WriteLine("Great, we've saved your number as " + userNumber + ".");
                    numberValid = true;
                } else
                {
                    Console.WriteLine("Hey, it's gotta be between 1 and 10.");
                    numberValid = false;
                }
            }
            Console.ReadLine();

        }
    }
}
