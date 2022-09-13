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
            string course_page = Console.ReadLine();
            int course_page_int = Convert.ToInt32(course_page);

            //  Console Feedback to show I parsed the Int.
            Console.WriteLine("You've indicated you're on page #" + course_page_int + ". Thank you!");

            //  Asking for a boolean return from the user, crashing the program otherwise.
            //  Same reason as above on the try catch method. 
            //  Created if fork to ask for more detail since it's not open-ended.
            //  I also check to ensure the user's answer can be converted to a boolean.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\". \n>>>");
            string user_answer = Console.ReadLine();
            bool user_answer_bool = Convert.ToBoolean(user_answer);
            Console.WriteLine("You gave us the following boolean answer: " + user_answer_bool);
            if (user_answer_bool)
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
            string user_hours = Console.ReadLine();
            int user_hours_int = Convert.ToInt32(user_hours);

            //  Thanks, user.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
