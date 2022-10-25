using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Models
{
    public class Movie
    {
        //This is meant to act as our primary key
        //I like to get all of my properties into the class first 
        //And then think about what data annotations I want to use second 
        [Key]
        //[Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }
        [Range(1,600)]
        public int Runtime { get; set; }
        [MaxLength(15)]
        public string Genre { get; set; }

    }
}
