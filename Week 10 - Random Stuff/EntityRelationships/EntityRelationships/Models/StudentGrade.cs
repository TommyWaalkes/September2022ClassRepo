using System;
using System.Collections.Generic;

namespace EntityRelationships.Models;

public partial class StudentGrade
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? GradeId { get; set; }

    public string? Subject { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]

    public virtual Grade? Grade { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]

    public virtual Student? Student { get; set; }
}
