using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "this", "is", "an", "array", "of", "strings" };
            Console.WriteLine("Time to be goofy. What would you like to write at the end of each word in our hidden array? ");
            string userInput = Console.ReadLine();

            // Console App part 2 assignment : Make an infinite loop and comment how you fix it.
            //  This could be made infinite by simply removing the increment for i.
            //  Fix it by incrementing i. You could also infinitely loop by not setting a way for the increment to know when it's done
            //  Fix that by ensuring you have a finite ending point.

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i] + userInput;
            }

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }

            Console.WriteLine("Give me a number to count to.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= userNumber; i++)
            {
                Console.WriteLine(i);
            }

            //  Console App Part Four - List of unique strings

            //  Ask user to input text to search in list
            //  Iterate through that list and display the list index that contians the matching text.
            //  Indicate if text isn't in list.

            List<string> fruits = new List<string>() { "orange", "apple", "banana", "grape", "kiwi", "lemon", "lime", "mango", "jicama", "dragonfruit", "papaya", "berry", "kiwi"};
            Console.WriteLine("Search for a fruit! Hint: we have a kiwi in this list.");
            string userFruitSearch = Console.ReadLine().ToLower();
            bool fruitFound = false;
            do
            {
                if (fruits.Contains(userFruitSearch))
                {
                    Console.WriteLine("We have the " + userFruitSearch + " at index: " + fruits.IndexOf(userFruitSearch));
                    fruitFound = true;
                } 
                else
                {
                    Console.WriteLine("we don't have that fruit...");
                    fruitFound = true;
                }
            } while (!fruitFound);
             
            


            // Console App Part Five - Do it again, but with a unique value and keep going.

            List<string> names = new List<string>() { "matt", "james", "frank", "matt", "sean", "jordan", "kyle", "demaux"};
            Console.WriteLine("There's a list of names here - Search for one to see if there are multiple entries: Hint the name, Matt will return with more than one index.");
            string userNameSearch = Console.ReadLine().ToLower();
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == userNameSearch)
                {
                    Console.WriteLine("We found the name " + userNameSearch + " at index " + i);
                }
            }                


            //  Console App Part Six, Indicate Duplications.

            List<string> genres = new List<string>() { "rock", "opera", "classic", "rock", "country", "rap", "rock", "rock" };
                   
            // So now we need to indicate if something was a duplicate. The requirements show a screenshot where the first appearance counted as unique, but any thereafter counted as duplicates
            // So I'm setting up a list to use as a comparison operation.
            // We start by searching the comparison list for the genre, then if it does exist, it's a duplicate, but if it doesn't, we'll add it and spit out that it's unique (for now)!

            List<string> compareGenres = new List<string>();

            // foreach loop iterates through the strings in the genre list. 
            foreach (string genre in genres)
            {
                if (compareGenres.Contains(genre))
                {
                    Console.WriteLine(genre + " - this item is a duplicate");
                } else
                {
                    compareGenres.Add(genre);
                    Console.WriteLine(genre + " - this item is unique");
                }
            }
            Console.ReadLine();

        }
    }
}
