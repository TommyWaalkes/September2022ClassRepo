using System;
using System.Collections.Generic;

namespace MovieAPIDemo.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int? RunTime { get; set; }
    }
}
