using System;
using System.Collections.Generic;

namespace EntityRelationships.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string? LName { get; set; }
    [System.Text.Json.Serialization.JsonIgnore]

   public virtual List<Student> Students { get; set; } = new List<Student>();

}
