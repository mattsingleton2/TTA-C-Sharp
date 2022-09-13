using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
            // Create one dimensional array of strings and another of integers.
            // ask user to specify an index and read that back to the user.
            // Make sure to indicate if the user selects one out of range.

            string[] strings = { "Sword", "Bow", "Spear", "Shield" };
            int[] ints = { 10001, 10002, 10003, 10004 };

            // Got tired of typing the error message, saving it as a const.
            const string errorMessage = "You selected an index that's out of range. No information will be returned.";

            int stringsLength = Convert.ToInt32(strings.Length);
            int intsLength = Convert.ToInt32(ints.Length);

            //  Parse user input, convert it and display it.
            //  Give an error message and move on if they ignore the guide. 
            Console.WriteLine("Please choose a string index to display between 0 and " + (stringsLength - 1));
            int userSelection = Convert.ToInt32(Console.ReadLine());
            if (userSelection >= 0 && userSelection < stringsLength)
            {
                Console.WriteLine("You selected index " + userSelection + ".\nThe information at that index is: " + strings[userSelection]);
            } 
            else
            {
                Console.WriteLine(errorMessage);
            }

            //  Same thing here, for integer array.
            Console.WriteLine("Please choose an integer index to display between 0 and " + (intsLength - 1));
            int userIntSelection = Convert.ToInt32(Console.ReadLine());
            if (userIntSelection >= 0 && userIntSelection < intsLength)
            {
                Console.WriteLine("You selected index " + userIntSelection + ".\nThe information at that index is: " + ints[userIntSelection]);
            }
            else
            {
                Console.WriteLine(errorMessage);
            }

            // Now for the lists side of the requirements...
            //  Instantiate the list and do the same thing with it.
            List<string> stringsList = new List<string>() { "SWORD", "BOW", "SPEAR", "SHIELD" };
            int listLength = Convert.ToInt32(stringsList.Count);
            Console.WriteLine("Please choose an index for the Strings List between 0 and " + (listLength - 1));
            int userListSelection = Convert.ToInt32(Console.ReadLine());
            if (userListSelection >= 0 && userListSelection < listLength)
            {
                Console.WriteLine("You selected index " + userListSelection + ".\nThe information at that index is: " + stringsList[userListSelection]);
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
            Console.WriteLine("\nThanks for reviewing!");
            Console.ReadLine();
        }
    }
}
