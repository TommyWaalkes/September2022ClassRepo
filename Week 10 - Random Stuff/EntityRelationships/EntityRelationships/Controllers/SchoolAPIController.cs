using EntityRelationships.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace EntityRelationships.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SchoolAPIController
    {
        School2Context db = new School2Context();

        [HttpGet("students")]
        public List<TaughtBy> GetStudents()
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true
            };
            List<Student> students = db.Students.ToList();
            List<IdCard> idCards = db.IdCards.ToList();
            List<Teacher> teachers= db.Teachers.ToList();
            List<StudentGrade> studentGrades= db.StudentGrades.ToList();

            //Foreach student grab the related properties from other tables
            //Linq and/or search algorithms are gonna come in handy here
            List<TaughtBy> studentsToTeacher = new List<TaughtBy>();
            foreach(Student s in students)
            {
                //Look up our Id card 
                //s.IdCard = idCards.Find(card => card.StudentId == s.Id);
                //s.IdCard.Student = s;
                TaughtBy t = new TaughtBy();
                t.Student = s;
                t.Teacher = teachers.Find(t => t.Id == s.TeacherId);
                t.IdCard = idCards.Find(card => card.StudentId == s.Id);
                t.grades = studentGrades.Where(g => g.StudentId == s.Id).ToList();
                studentsToTeacher.Add(t);
            }

            return studentsToTeacher;
        }
        //Angular needs to match the models returned by your API methods 
        [HttpGet("students/{id}")]
        public TaughtBy GetStudent(int id)
        {
            List<Student> students = db.Students.ToList();
            List<IdCard> idCards = db.IdCards.ToList();
            List<Teacher> teachers = db.Teachers.ToList();
            List<StudentGrade> studentGrades = db.StudentGrades.ToList();

            Student s = db.Students.Where( stu => stu.Id==id).FirstOrDefault();

            if(s!= null)
            {
                TaughtBy t = new TaughtBy();
                t.Student = s;
                t.Teacher = teachers.Find(t => t.Id == s.TeacherId);
                t.IdCard = idCards.Find(card => card.StudentId == s.Id);
                t.grades = studentGrades.Where(g => g.StudentId == s.Id).ToList();

                return t;
            }
            else
            {
                TaughtBy error = new TaughtBy();
                error.Student = new Student();

                error.Student.FName = "Error no student found at Id " + id;

                return error;
            }
        }

        [HttpGet("Teachers")]
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = db.Teachers.ToList();
            List<Student> students = db.Students.ToList();
     

            return teachers;
        }

        [HttpGet("GetStudentByTeacher/{TeacherId}")]
        public List<Student> GetStudentByTeacher(int TeacherId)
        {
            List<Teacher> teachers = db.Teachers.ToList();
            List<Student> students = db.Students.ToList();

            List<Student> output = students.Where(s => s.TeacherId == TeacherId).ToList();

            return output; 
        }

        [HttpGet("GetAllIdCards")]
        public List<IdCard> GetCards()
        {
            return db.IdCards.ToList();
        }

        [HttpGet("GetStudentByIdCard/{idCardId}")]
        public Student GetStudentByIdCard(int idCardId)
        {
            return db.Students.Where(s => s.IdCard.Id == idCardId).FirstOrDefault();
        }

        [HttpGet("GetCardsByStudentId/{studentId}")]
        public IdCard GetCardsById(int studentId)
        {
            return db.IdCards.Where(i => i.StudentId == studentId).FirstOrDefault();
        }
    }
}
