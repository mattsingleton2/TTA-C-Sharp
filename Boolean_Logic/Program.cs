using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Insurance Questions");
            
            //  Info collection
            Console.WriteLine("What is your age?");
            string user_age = Console.ReadLine();
            int user_age_converted = Convert.ToInt32(user_age);
            Console.WriteLine("Have you ever had a DUI? Please answer true or false:");
            string user_dui = Console.ReadLine();
            bool user_dui_converted = Convert.ToBoolean(user_dui);
            Console.WriteLine("How many speeding tickets have you received?");
            string user_tickets = Console.ReadLine();
            int user_tickets_converted = Convert.ToInt32(user_tickets);

            //  Stash the true false answer into a bool variable so our response to the user looks better.
            //  Uses the method I built below to simply check all the logic instead of writing it repeatedly.
            bool user_validity = IsEligible(user_age_converted, user_dui_converted, user_tickets_converted);

            //  If statement to give the appropriate response back.
            if (user_validity)
            {
                Console.WriteLine("Based on the answers given, this user is eligible for insurance coverage.");
            } else
            {
                Console.WriteLine("Based on the answers given, this user is NOT eligible for insurance coverage.");
            }
            Console.ReadLine();
        }

        private static bool IsEligible(int age, bool dui, int tickets)
        {
            if (age > 15 && dui != true && tickets <= 3){
                return true;
            } else
            {
                return false;
            }
        }
    }
}
