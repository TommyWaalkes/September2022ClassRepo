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
        [HttpPut("UpdateStudent/")]
        //This overrides what was in the database with values from the new object, old values will be lost 
        //so be careful with update it is not reversible
        public Student UpdateStudent( Student student)
        {
            List<Teacher> teachers = db.Teachers.ToList();
            int? tid = student.TeacherId;
            List<Teacher> filteredTeachers = teachers.Where(t => t.Id == tid).ToList();

            //Main wrinkle with updates is validating your foreign keys exist in the other tables 
            //Process looks the same no matter the relationship
            if (filteredTeachers.Count > 0)
            {
                db.Students.Update(student);
                db.SaveChanges();
            }
            else
            {
                student.FName = $"Invalid teacher id. No teacher found with id {tid}, entry not modified";
            }

            return student;
        }

        [HttpDelete("DeleteStudent/{id}")]

        public string DeleteStudent(int id)
        {
            try
            {
                //in one to one, the student should only appear once in the table. 
                List<IdCard> matchingCards = db.IdCards.Where(c => c.StudentId == id).ToList();
                if(matchingCards.Count > 0)
                {
                    db.IdCards.Remove(matchingCards.First());
                }

                //Keep in mind in many to many the student may appear in the overlap table more than once 
                List<StudentGrade> matchingGrades = db.StudentGrades.Where(sg => sg.StudentId == id).ToList();
                if(matchingGrades.Count > 0)
                {
                    foreach(StudentGrade g in matchingGrades)
                    {
                        db.StudentGrades.Remove(g);
                    }
                }


                Student s = db.Students.Find(id);
                db.Students.Remove(s);
                db.SaveChanges();
                return $"Student at id {id} was deleted";
            }
            catch (Exception e)
            {
                return $"ERROR: {e.Message}, {e.InnerException}, {e.StackTrace}";
            }
        }

        [HttpDelete("DeleteTeacher/{id}")]
        public string DeleteTeacher(int id)
        {
            try
            {
                //What you do depends on what you want for the dependant table rows, you may update to another teacher 
                //You may delete them, or you may set their teacherId to null, it'll be a judgement what needs to happen
               List<Student> filteredStudents = db.Students.Where(s => s.TeacherId== id).ToList();

                foreach(Student student in filteredStudents)
                {
                    //You need to address the fact that a teacherId will no longer be valid
                    student.TeacherId = null;
                    db.Students.Update(student);
                }
                
                Teacher t = db.Teachers.Find(id);

                db.Teachers.Remove(t);
                db.SaveChanges();
                return $"Teacher at id {id} was deleted";
            }
            catch (Exception e)
            {
                return $"ERROR: {e.Message}, {e.InnerException}, {e.StackTrace}";
            }

        }

        //To pass in a full object, you need to put it in the body of the HTTP request
        //In Angular, in your service, when you call http.put(URL, model); 
        [HttpPost("CreateStudent/{teacherId}")]
        //We return a string so we can return a message as to wheter the add worked correctly
        public string CreateStudent(Student student, int teacherId)
        {
            try
            {
                AddTeacherToStudent(teacherId, student);
                db.Students.Add(student);
                db.SaveChanges();

                Student personWithId = db.Students.Where(s =>s.FName == student.FName && s.LName == student.LName).First();
                CreateIdCard(personWithId.Id);

                return $"Student {student.LName} successfully added to the database"; 
            }
            catch(Exception ex)
            {
                return $"Could not add student to database. Error Details: {ex.Message}  {ex.StackTrace}";
            }
        }

        //This doesn't exist as an API endpoint, it's mainly is for the other endpoints to call
        //In older version of the API controller you could create non-endpoint methods, 
        //but it seems in this newest version only endpoint methods are allowed
        [HttpPut("AddTeacherToStudent/{teacherId}")]
        public string AddTeacherToStudent(int teacherId, Student student)
        {
            List<Teacher> teachers = db.Teachers.ToList();

            if(teachers.Count(t=> t.Id == teacherId) > 0)
            {
                student.TeacherId = teacherId;
                return "Teacher Successfully tied to a student";
            }
            else
            {
                return $"No teacher at {teacherId}";
            }
        }

        [HttpPost("MakeIdCard/{studentId}")]
        public string CreateIdCard(int studentId)
        {
            try
            {
                IdCard idCard = new IdCard();

                idCard.StudentId = studentId;

                db.IdCards.Add(idCard);
                db.SaveChanges();
                return $"Idcard with student id: {studentId} was succesfully added";
            }
            catch(Exception ex)
            {
                return $"Could not add IdCard to database. Error Details: {ex.Message}  {ex.StackTrace}";
            }
        }

        [HttpPost("CreateStudentGrade/student={studentId}/grade={gradeId}/subject={subject}")]
        public StudentGrade CreateStudentGrade(int studentId, int gradeId, string subject)
        {
            Student s = db.Students.Find(studentId);
            Grade g = db.Grades.Find(gradeId);

            StudentGrade studentGrade = new StudentGrade();
            studentGrade.StudentId = studentId;
            studentGrade.GradeId = gradeId;
            studentGrade.Subject = subject;

            db.StudentGrades.Add(studentGrade);
            db.SaveChanges();

            return studentGrade;
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
