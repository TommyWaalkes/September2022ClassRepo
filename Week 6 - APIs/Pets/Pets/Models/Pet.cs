using System;
using System.Collections.Generic;

namespace Pets.Models
{
    public partial class Pet
    {
        public Pet()
        {
            PetOwners = new HashSet<PetOwner>();
        }

        public int Id { get; set; }
        public string? Species { get; set; }

        public virtual ICollection<PetOwner> PetOwners { get; set; }
    }
}
