using System;
using System.Data.Entity;

namespace EF_CodeFirst_StudentApp
{
    // Define the Student class (Model)
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    // Define the DbContext (Database Context)
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Create a new student and add to the database
                var student = new Student { FirstName = "John", LastName = "Doe", Age = 21 };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.ReadKey();
            }
        }
    }
}