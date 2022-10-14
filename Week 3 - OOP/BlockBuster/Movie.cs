using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster
{
//    //Create an abstract Movie class with the following (make a regular class if we haven’t covered that): 
//    A property for Title that’s a string
//    A property for Category that’s of Enum Genre - if we haven’t covered this yet, just use a string
//    An int property for RunTime (in minutes) 
//A list of strings called Scenes
//    A virtual method called PrintInfo() that prints all properties in the class to the console save for the scenes. (Feel free to use ToString here instead of print info)
//A method called PrintScenes() that prints all the scenes in the list along with their index.
//An abstract method with no return type called Play() (If we haven’t covered abstract yet, just make this method virtual instead) 

    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }

    public abstract class Movie
    {
        public string Title { get; set; }
        public int Runtime { get; set; }
        public Genre Category { get; set; }
        public List<string> Scenes { get; set; } = new List<string>();

        //Weird thing about abstract class constructors is that they may not be called, they exist only for their child
        //With any parent, the child must supply the parent constructor with values. 
        public Movie(string Title, int Runtime, Genre Category, List<string> Scenes)
        {
            this.Title = Title;
            this.Runtime = Runtime;
            this.Category = Category;
            this.Scenes = Scenes;
        }

        //Each child of Movie must supply their own version of this method 
        public abstract void Play();

        //Every child has the option to overide this, use it as is or use it and onto it
        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Run Time: "+ Runtime + " minutes");
            Console.WriteLine("Category: "+ Category);
        }

        //Every child gets a regular method as is 
        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i}: {Scenes[i]}");
            }
        } 
    }
}
