using EntityMovies.Models;

namespace EntityMovies
{
    internal class Program
    {
        //This variable is static so I can use it in static methods 
        public static Movies2Context db = new Movies2Context();
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a Genre you wish to search");
            string genre = Console.ReadLine();
            List<Movie> results = SearchByGenre(genre);

            PrintMovies(results);

            Console.WriteLine("Please input a title you wish to search for");
            string title = Console.ReadLine();
            List<Movie> results2 = SearchByTitle(title);
            PrintMovies(results2);

        }

        public static List<Movie> SearchByGenre(string genre)
        {
            List<Movie> searchResults = db.Movies.Where(m => m.Genre == genre).ToList();
            return searchResults;
        }

        public static List<Movie> SearchByTitle(string title)
        {
            return db.Movies.Where(m => m.Title.Contains(title)).ToList();
        }

        public static void PrintMovies(List<Movie> movies)
        {
            for(int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i} : {movies[i].Title}");
            }
        }
    }
}