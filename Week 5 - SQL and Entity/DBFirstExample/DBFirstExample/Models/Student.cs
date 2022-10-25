using System;
using System.Collections.Generic;

namespace DBFirstExample.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Gpa { get; set; }
        public string? Major { get; set; }
    }
}
