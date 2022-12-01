using System;
using System.Collections.Generic;

namespace EntityRelationships.Models;

public partial class Grade
{
    public int Id { get; set; }

    public string? Grade1 { get; set; }

    //Navigation Property - represents a relationship in another table. 
    //When I pull up a grade, entity also pulls up a list of every row in studentsgrades with that grade it 
    //The same property will exist on the other side of this many to many 
    [System.Text.Json.Serialization.JsonIgnore]

    public virtual ICollection<StudentGrade> StudentGrades { get; } = new List<StudentGrade>();
}
