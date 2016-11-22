using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb12
{
    class FilmManager
    {
        public List<Film> FilmList { get; set; }

        public FilmManager()
        {
            FilmList = new List<Film>
            {
            new Film { Title = "Fast and furious", Year = 2001, RunningTime = 120, Genre = Film.Genres.Action },
            new Film { Title = "Fast and furious2", Year = 2001, RunningTime = 130, Genre = Film.Genres.Action },
            new Film { Title = "Titanic", Year = 1997, RunningTime = 194, Genre = Film.Genres.Romance },
            new Film { Title = "The grudge", Year = 2004, RunningTime = 96, Genre = Film.Genres.thriller },
            new Film { Title = "The GodFather", Year = 1972, RunningTime = 177, Genre = Film.Genres.Drama },
            new Film { Title = "Catch me if you can", Year = 2003, RunningTime = 141, Genre = Film.Genres.Biography },
            new Film { Title = "Casablanca", Year = 1943, RunningTime = 102, Genre = Film.Genres.Romance },
            new Film { Title = "Halloween", Year = 1979, RunningTime = 87, Genre = Film.Genres.thriller },
            new Film { Title = "12 years a slave", Year = 2013, RunningTime = 134, Genre = Film.Genres.Biography },
            new Film { Title = "A beautiful mind", Year = 2001, RunningTime = 135, Genre = Film.Genres.Drama }
           };
        }
    }


}
