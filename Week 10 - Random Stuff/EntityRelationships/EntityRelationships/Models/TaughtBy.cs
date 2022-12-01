namespace EntityRelationships.Models
{
    public class TaughtBy
    {
        //This model exists to carry around all relationship data for a particular student
        public Student Student { get; set; }

        public Teacher Teacher { get; set; }

        public IdCard IdCard { get; set; }

        public List<StudentGrade> grades { get; set; }
    }
}
