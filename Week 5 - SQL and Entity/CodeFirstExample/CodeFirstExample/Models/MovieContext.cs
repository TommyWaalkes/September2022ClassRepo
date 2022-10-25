using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Models
{
    //DbContext is a built in class coming from Entity framework 
    public class MovieContext : DbContext
    {
        //This needs to be here to function
        //public MovieContext(DbContextOptions options)  : base(options){

        //}
        ////Again this constructor needs to be here to make Entity happy
        //public MovieContext()
        //{

        //}

        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Movies;Trusted_Connection=True;");
            }
        }

    }
}
