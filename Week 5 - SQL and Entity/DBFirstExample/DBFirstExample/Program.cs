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
            PrintStudents(students);

            //PrintStudent();

            //Console.WriteLine("Please select a student you wish to edit:");

            //int id = int.Parse(Console.ReadLine());

            //SchoolCRUD sc = new SchoolCRUD();
           // sc.EditStudent(id);

           

            PrintStudent();

        }

        public static void PrintStudents(List<Student> students)
        {
            Console.WriteLine("Print Student Names: ");
            //int i = 1;
            foreach (Student stu in students)
            {
                Console.WriteLine(stu.Id + " " + stu.Name);
               // i++;
            }
        }

        public static void PrintStudent()
        {
            SchoolCRUD sc = new SchoolCRUD();
            Console.WriteLine("Please select an id to learn about that student");
            int pick = int.Parse(Console.ReadLine());

            Student s = sc.GetStudent(pick);

            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine($"Major: {s.Major}");
            Console.WriteLine($"GPA: {s.Gpa}");
            Console.WriteLine($"DB id: {s.Id}");
        }
    }
}