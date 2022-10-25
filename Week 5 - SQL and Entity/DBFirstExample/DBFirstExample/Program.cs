using DBFirstExample.Models;

namespace DBFirstExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SchoolContext db = new SchoolContext();

            //This is part of why I emphasize toList early on, Entity loves using ToList
            List<Student> students = db.Students.ToList();

            Console.WriteLine("Print Student Names: ");

            foreach(Student s in students)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine("Lets add a new student into our table");
            Student newS = new Student();

            Console.WriteLine("What is the name of your student?");
            newS.Name = Console.ReadLine();

            Console.WriteLine("What is their GPA?");
            newS.Gpa = double.Parse(Console.ReadLine());

            Console.WriteLine("What is their Major?");
            newS.Major = Console.ReadLine();

            db.Students.Add(newS);
            db.SaveChanges();
        }
    }
}