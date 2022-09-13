using System;

namespace myConsoleProject.cs
{
    internal class Program
    {
        static void Main()
        {
            //  Making it cute, I guess.
            Console.WriteLine("*********************************");
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine("*********************************");

            //  Asking for name and storing it in a specific data-type because I can.
            Console.WriteLine("What is your name?\n>>>");
            string user_name = Console.ReadLine();

            //  Asking for a course name and storing it in a string data-type.
            Console.WriteLine("What course are you on?\n>>>");
            string user_course = Console.ReadLine();

            //  Asking for a page number and then making sure I can parse the string return to an int.
            //  Could do some fancy try/catch stuff here, but I think I'd have to write this all as a method and try/catch the method result.
            //  I'll stick with basics for now.
            Console.WriteLine("What page number?\n>>>");
            int course_page = Convert.ToInt32(Console.ReadLine());
            
            //  Console Feedback to show I parsed the Int.
            Console.WriteLine("You've indicated you're on page #" + course_page + ". Thank you!");

            //  Asking for a boolean return from the user, crashing the program otherwise.
            //  Same reason as above on the try catch method. 
            //  Created if fork to ask for more detail since it's not open-ended.
            //  I also check to ensure the user's answer can be converted to a boolean.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\". \n>>>");
            bool user_answer = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("You gave us the following boolean answer: " + user_answer);
            if (user_answer)
            {
                Console.WriteLine("What would you like extra help on?");
                string user_extra_help = Console.ReadLine();
            }

            //  Moving on...
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.\n>>>");
            string user_experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.\n>>>");
            string user_feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?\n>>>");
            int user_hours = Convert.ToInt32(Console.ReadLine());
            

            //  Thanks, user.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
