using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BlockBuster
{
    internal class DVD : Movie
    {
        //Create a child of Movie named DVD with the following code: 
        //A method called Play() that takes no parameters and is void that will ask the user what
        //scene they’d like to watch, print all the available scenes, and allow the user to select a scene from the list and print it out.

        public DVD(string Title, int Runtime, Genre Category, List<string> Scenes) 
            : base(Title, Runtime, Category, Scenes)
        {
        }

        public override void Play()
        {
            try
            {
                PrintScenes();

                Console.WriteLine("Please select a scene to watch: ");
                string input = Console.ReadLine();

                int pick = int.Parse(input);

                string scene = Scenes[pick];
                Console.WriteLine(scene);
            }
            catch(FormatException e)
            {
                Console.WriteLine("That was not a valid number lets try again");
                Play();
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Please input a number between 0 and {Scenes.Count -1}, the input number was outside that range");
                Play();
            }
        }
    }
}
