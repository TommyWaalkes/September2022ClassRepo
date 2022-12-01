using System;
using System.Collections.Generic;

namespace EntityRelationships.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? FName { get; set; }

    public string? LName { get; set; }

    public int? TeacherId { get; set; }

    //This is our one to one 
    [System.Text.Json.Serialization.JsonIgnore]

    public virtual IdCard? IdCard { get; set; }

    //Many to Many 
    [System.Text.Json.Serialization.JsonIgnore]

    public virtual ICollection<StudentGrade> StudentGrades { get; } = new List<StudentGrade>();

    //One to Many - each student has one teacher, but each teacher has a list of students. 
    [System.Text.Json.Serialization.JsonIgnore]

    public virtual Teacher? Teacher { get; set; }
}
