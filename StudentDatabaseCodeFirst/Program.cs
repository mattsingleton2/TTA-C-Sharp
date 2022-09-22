using StudentDatabaseCodeFirst;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                //  Create and save new student.
                Console.WriteLine("Enter the first name for a new student:");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter the last name for this student: ");
                var lastName = Console.ReadLine();
                Console.WriteLine("Pick an ID number for the student: ");
                int studentId = Convert.ToInt32(Console.ReadLine());
                var student = new Student { FirstName = firstName, LastName = lastName, Id = studentId };
                db.Students.Add(student);
                db.SaveChanges();

                //  Display all students:
                var query = from s in db.Students
                            orderby s.LastName
                            select s;

                Console.WriteLine("All students in this database:");
                Console.WriteLine(@"---------------------------------------------------------------");
                foreach (var item in query)
                {
                    Console.WriteLine($"\n{item.Id} -- {item.FirstName} {item.LastName}");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    
}