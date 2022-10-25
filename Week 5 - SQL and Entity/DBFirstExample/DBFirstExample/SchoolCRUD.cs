using DBFirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstExample
{
    public class SchoolCRUD
    {
        public SchoolContext db { get; set; } = new SchoolContext();

        public void Add()
        {
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

        //Usually theres 2 flavors of read: 1) grab and display all rows 2) grab an individual entry usually by primary key
        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public List<Teacher> GetTeachers()
        {
            return db.Teachers.ToList();
        }

        public Student GetStudent(int id)
        {
            //Find takes in an id and returns the matching row if one is present, else it will throw an exception
            Student output = db.Students.Find(id);
            return output;
        }

        //Be Careful with this, as deletes done via Entity are permanent like in SQL 
        //Foreign keys - make deletion more complicated sice you have to worry multiple tables 
        public void DeleteStudent(int id)
        {
            Student s = db.Students.Find(id);
            db.Students.Remove(s);
            db.SaveChanges();
        }

        public void Update(Student newValues)
        {
            db.Students.Update(newValues);
            db.SaveChanges();
        }

        public void EditStudent(int id)
        {
            //When updating a student you'll need to account for each property even if it's a matter of leaving it unchanged 
            //I don't know what my user needs to edit so I give them the option to change or skip each property 

            //You shouldn't be allowed to edit the id, as it will confuse entity and possibly update the wrong entry 
            Student edit = GetStudent(id);

            Console.WriteLine($"Editing entry of {edit.Name}");
            Console.WriteLine("Please input the new values you wish for your student row");
            Console.WriteLine("Enter the empty string if you wish to leave the property as is");
            Console.WriteLine("What is the name of your student?");
           
            string nameInput = Console.ReadLine();

            if (nameInput != "")
            {
                edit.Name = nameInput;
            }
            Console.WriteLine("What is their GPA?");
            string GPAInput = Console.ReadLine();
            if (GPAInput != "")
            {
               
                edit.Gpa = double.Parse(GPAInput);
            }
            Console.WriteLine("What is their Major?");
            string majorInput = Console.ReadLine();

            if (majorInput != "")
            {
                edit.Major = majorInput;
            }

            Update(edit);
        }
    }
}
