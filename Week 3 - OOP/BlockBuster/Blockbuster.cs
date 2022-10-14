using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster
{
    public class Blockbuster
    {
        //Lastly, create a class named Blockbuster that contains the following code: 
        //List<Movie> Movies - this should contain at least 6 movies, 3 DVDs, 3 VHS all your choice
        //PrintMovies() - this will print all the movie titles in the Movies list along with their indexes.
        //CheckOut() - this will call PrintMovies() and ask the user which movie they’d like to check out,
        //get an index from the user, select a movie from the list and PrintInfo() on that movie.The method should return the Movie object selected by the user.
        //Once a has been return call Play() on it to watch the movie.

        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            VHS v = new VHS("Shrek", 90, Genre.Comedy,
              new List<string>() { "Get out of my swamp", "You're a monster", "Final Wedding Scene" });

            DVD d = new DVD("Lord of the Rings", 180, Genre.Drama,
                new List<string>() { "Bilbos Birthday", "Keep it secret keep it safe", "Rivendell", "Mines of Moria" });

            Movies.Add(d);
            Movies.Add(v);
            Movies.Add(new DVD("Tremors", 90, Genre.Horror, 
                new List<string>() { "Sleeping in their truck", "Girl digging in the desert", "Trapped in store" }));

            Movies.Add(new DVD("Space Balls", 75, Genre.Comedy, 
                new List<string>() { "No one out pizzas the hut", "Merchdising Scene", "Final Battle" }));

            Movies.Add(new VHS("Land Before Time", 60, Genre.Drama,
                new List<string>() { "Dinosaurs Search a new home", "Tar pit scene", "Musical Numbers" }));
        }

        public void PrintMovies()
        {
            //This is an example of polymorphism in action
            for(int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine(i + " " + Movies[i].Title);
            }
        }

        public Movie Checkout()
        {
            try
            {
                Console.WriteLine("Which movie would you like to watch?");
                PrintMovies();
                string input = Console.ReadLine();
                int pick = int.Parse(input);
                Movie output = Movies[pick];
                output.PrintInfo();
                return output;
            }
            catch (FormatException e)
            {
                Console.WriteLine("That was not a valid number lets try again");
                return Checkout();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Please input a number between 0 and {Movies.Count - 1}, the input number was outside that range");
                return Checkout();
            }

        }

    }
}
