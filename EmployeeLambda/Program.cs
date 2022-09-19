using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeLambda
{
    internal class Program
    {
        static void Main()
        {
            // In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            Employee employee1 = new Employee() { FirstName = "Matt", LastName = "Singleton", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "Schmoe", Id = 2 };
            Employee employee3 = new Employee() { FirstName = "Kyle", LastName = "Frame", Id = 3 };
            Employee employee4 = new Employee() { FirstName = "Joe", LastName = "Tallis", Id = 4 };
            Employee employee5 = new Employee() { FirstName = "Nathan", LastName = "Ripple", Id = 5 };
            Employee employee6 = new Employee() { FirstName = "Kalani", LastName = "Man", Id = 6 };
            Employee employee7 = new Employee() { FirstName = "Henry", LastName = "Lum", Id = 7 };
            Employee employee8 = new Employee() { FirstName = "Joe", LastName = "Fouraine", Id = 8 };
            Employee employee9 = new Employee() { FirstName = "Colin", LastName = "Tipp", Id = 9 };
            Employee employee10 = new Employee() { FirstName = "Joe", LastName = "Barston", Id = 10 };

            List<Employee> employees = new List<Employee>() { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };

            //  Using a foreach loop, create a new list of all employees with the first name “Joe”
            List<Employee> employeesJoe = new List<Employee>();

            foreach (Employee e in employees)
            {
                if (e.FirstName == "Joe")
                {
                    employeesJoe.Add(e);
                    Console.WriteLine($"Added {e.FirstName} {e.LastName} to the Joe list.");
                }
            }

            //  Perform the same action again, but this time with a lamda expression.
            List<Employee> employeesJoeLambda = employees.Where(e => e.FirstName == "Joe").ToList();
            foreach(Employee e in employeesJoeLambda)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} has the first name of Joe.");
            }

            //  Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> newEmployee = employees.Where(e => e.Id > 5).ToList();
            foreach(Employee e in newEmployee)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} has an ID of {e.Id}.");
            }
        }
    }
}
