using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Example Insurance Questions");
            
            //  Info collection
            Console.WriteLine("What is your age?");
            int user_age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Have you ever had a DUI? Please answer true or false:");
            bool user_dui = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("How many speeding tickets have you received?");
            int user_tickets = Convert.ToInt32(Console.ReadLine());
            
            //  Stash the true false answer into a bool variable so our response to the user looks better.
            //  Uses the method I built below to simply check all the logic instead of writing it repeatedly.
            bool user_validity = IsEligible(user_age, user_dui, user_tickets);

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
