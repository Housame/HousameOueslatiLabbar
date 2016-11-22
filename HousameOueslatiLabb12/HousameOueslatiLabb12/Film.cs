using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb12
{
    class Film
    {
        public enum Genres
        {
            thriller = 1,
            Romance,
            Biography,
            Action,
            Drama
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public Genres Genre { get; set; }
        public int RunningTime { get; set; }

    }
}
