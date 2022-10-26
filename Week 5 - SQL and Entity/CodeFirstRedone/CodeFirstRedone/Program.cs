using CodeFirstRedone.Models;

namespace CodeFirstRedone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This will use the exact methods regardless of whether we did DB or Code first 
            //So I can easily swap my connections out without impacting my code
            StudentContext db = new StudentContext();
        }
    }
}