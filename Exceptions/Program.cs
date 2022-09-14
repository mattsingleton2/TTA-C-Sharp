using System;


namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two....");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please type a whole number. Don't use letters.");
                return;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
