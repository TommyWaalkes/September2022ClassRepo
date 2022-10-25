using System;
using System.Collections.Generic;

namespace DBFirstExample.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string SubjectTaught { get; set; } = null!;
        public int Rating { get; set; }
    }
}
