using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BlockBuster
{
//    Next Create a child class of Movie called VHS and code the following:
//A property called CurrentTime
//A method called Play() that plays the scene at the current time and then increments CurrentTime.
//A method called Rewind() that returns nothing and sets CurrentTime to 0. 

    internal class VHS : Movie
    {
        public VHS(string Title, int Runtime, Genre Category, List<string> Scenes) 
            : base(Title, Runtime, Category, Scenes)
        {
        }

        public int CurrentTime { get; set; } = 0;

        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                Console.WriteLine("Plaing scene " + CurrentTime);
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
            }
            else
            {
                Console.WriteLine("Lets be kind and rewind!!");
                Rewind();
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
