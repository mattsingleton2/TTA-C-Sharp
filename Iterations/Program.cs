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

            List<string> fruits = new List<string>();
            bool notFinished = false;
            do
            {
                // We'll start by asking what they want to add...
                Console.WriteLine("Let's add some fruit to a list. Please type the name of a fruit you'd like to add.");
                string user_fruit = Console.ReadLine();
                //  Lower casing to protect from cApS sEnSiTiViTy
                user_fruit = user_fruit.ToLower();

                //  We'll check if that's in the list already
                if (fruits.Contains(user_fruit))
                {
                    Console.WriteLine("You already added this one.");
                    //  Then we'll ask if they want to add more and do it again, updating our bool when we're ready to exit the loop.
                    Console.WriteLine("Would you like to add another? Please enter true or false to continue.");
                    notFinished = Convert.ToBoolean(Console.ReadLine());
                }
                else
                {
                    fruits.Add(user_fruit);
                    Console.WriteLine("Would you like to add another? Please enter true or false to continue.");
                    notFinished = Convert.ToBoolean(Console.ReadLine());
                }
            }
            while (notFinished);

            List<string> genres = new List<string>() { "rock", "opera", "classic", "rock", "country", "rap", "rock", "rock" };

            Console.WriteLine("Many users entered their favorite generes in our list. Most of them entered rock. Type your favorite genre to view the indeces they're at on the list.");
            string userSearch = Console.ReadLine();
            userSearch = userSearch.ToLower();
            foreach (string genre in genres)
            {
                if (genres.Contains(userSearch))
                {
                    if (genre == userSearch)
                    {
                        Console.WriteLine(genre);
                    }
                } else
                {
                    Console.WriteLine("This genre isn't in the list.");
                }
            }

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
