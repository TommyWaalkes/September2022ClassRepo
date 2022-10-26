using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRedone.Models
{
    public class StudentContext :DbContext
    {
        //Make a DB set for each table you wish to
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Students;Trusted_Connection=True;");
            }
        }

    }
}
