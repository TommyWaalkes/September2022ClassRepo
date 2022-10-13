using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class MusicCD
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public string Band { get; set; }
        public MusicGenre Genre { get; set; }

        public MusicCD(string Title, int RunTime, string Band, MusicGenre Genre)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Band = Band;
            this.Genre = Genre;
        }
    }


    public enum MusicGenre
    {
        Rock, 
        Jazz, 
        Opera, 
        Blues, 
        Rap, 
        Dance, 
        Electronic,
        Vaporwave
    }
}
