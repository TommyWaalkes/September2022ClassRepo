using System;
using System.Collections.Generic;

namespace EntityRelationships.Models;

public partial class IdCard
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    //Each Id card is associated with only one student - this is part of our 1 to 1 relationship
    [System.Text.Json.Serialization.JsonIgnore]

    public virtual Student? Student { get; set; }
}
