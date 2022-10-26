using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRedone.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(25)]
        public string HomeTown { get; set; }

        [MaxLength(20)]
        public string FavoriteFood { get; set; }

        public float GPA { get; set; }
    }
}
