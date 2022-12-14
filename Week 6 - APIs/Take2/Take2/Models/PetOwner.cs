using System;
using System.Collections.Generic;

namespace Take2.Models
{
    public partial class PetOwner
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? PetId { get; set; }

        public virtual Pet? Pet { get; set; }
    }
}
