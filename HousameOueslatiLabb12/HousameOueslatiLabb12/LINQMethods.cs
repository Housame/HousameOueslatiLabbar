using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HousameOueslatiLabb12
{
    class LINQMethods
    {
        FilmManager mgr = new FilmManager();
        internal void SearchByTitle()
        {
            Console.Clear();
            Console.WriteLine("The title you wanna search");
            var input = Console.ReadLine();
            List<Film> newFilm = new List<Film>();
            newFilm = mgr.FilmList.FindAll(f => f.Title.Contains(input));
            foreach (var film in newFilm)
            {
                Console.WriteLine("Title: {0} # The year: {1} # Running time: {2} # Genre: {3}", film.Title, film.Year, film.RunningTime, film.Genre);
            }
            Console.ReadKey();
        }


        internal void SearchByGenre()
        {
            Console.Clear();
            Console.WriteLine("The genre you wanna search");
            var genre = GetGenre();
            List<Film> newFilm = new List<Film>();
            newFilm = mgr.FilmList.FindAll(f => f.Genre == genre);
            foreach (var film in newFilm)
            {
                Console.WriteLine("Title: {0} # The year: {1} # Running time: {2} # Genre: {3}", film.Title, film.Year, film.RunningTime, film.Genre);
            }
            Console.ReadKey();
        }

        private Film.Genres GetGenre()
        {
            Console.Clear();
            int gnr = 0;
            foreach (var genre in Enum.GetValues(typeof(Film.Genres)))
            {
                Console.WriteLine("{0}. {1}", (int)genre, genre);
            }
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    gnr = 1;
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    gnr = 2;
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    gnr = 3;
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    gnr = 4;
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    gnr = 5;
                    break;

            }
            return (Film.Genres)gnr;

        }


        internal void ShortFilms()
        {
            Console.Clear();
            Console.WriteLine("The films with running time less than 120");
            Console.WriteLine("\n");
            List<Film> newFilm = new List<Film>();
            newFilm = mgr.FilmList.FindAll(f => f.RunningTime < 120);
            foreach (var film in newFilm)
            {
                Console.WriteLine("Title: {0} # The year: {1} # Running time: {2} # Genre: {3}", film.Title, film.Year, film.RunningTime, film.Genre);
            }
            Console.ReadKey();
        }

        internal void AllTitlesInOne()
        {
            Console.Clear();
            var allTitles = mgr.FilmList.Select(f => f.Title).ToArray();
            for (int i = 0; i < mgr.FilmList.Count; i++)
            {
                Console.Write(allTitles[i]+" # ");
            }
            Console.WriteLine("\n");
            Console.ReadKey();


            //List<string> newFilm = new List<string>();
            //newFilm = mgr.FilmList.Select(f => f.Title).ToList();
            //var arr = newFilm.ToArray();
            //Console.WriteLine(arr);
        } 

        internal void FillMyString()
        {
            Console.Clear();
            string myString="";
            int length = mgr.FilmList.Count;
            ShowAllFilms();
            int index = FillMyStringInput(length);
            List<Film> myList = mgr.FilmList.Where(f => f.Title.Equals(mgr.FilmList[index].Title)).ToList();
            foreach (var item in myList)
            {
                myString = item.Title;
            }
            Console.WriteLine(myString);
            Console.ReadKey();

        } 

        private int FillMyStringInput(int lgt)
        {
            Console.Clear();
            int input = 0;
            do
            {
                Console.Write("Which Film: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that you choose between 1 and {0}",lgt+1);
                    Thread.Sleep(1000);

                };

                if (input >= 1 && input <= lgt)
                {
                    return input-1;
                }

                else
                {
                    Runtime.ClearOneLine();
                }
            } while (true);

        }

        public void ShowAllFilms()
        {
            Console.Clear();
            int index = 0;
            foreach (var film in mgr.FilmList)
            {
                index++;
                Console.WriteLine("{4}. Title: {0} # The year: {1} # Running time: {2} # Genre: {3}", film.Title, film.Year, film.RunningTime, film.Genre,index);
            }
            Console.ReadKey();
        }

        internal void SearchByFirstLetter() 
        {
            Console.Clear();
            Console.WriteLine("The first letter of movie title you wanna search");
            var input = Console.ReadLine();
            var genre = GetGenre();
            List<Film> newFilm = new List<Film>();
            newFilm = mgr.FilmList.FindAll(f => f.Title[0].ToString().Equals(input.ToUpper()))
                .FindAll(f => f.Genre == genre)
                .FindAll(f => f.RunningTime > 120);
            foreach (var film in newFilm)
            {
                Console.WriteLine("Title: {0} # The year: {1} # Running time: {2} # Genre: {3}", film.Title, film.Year, film.RunningTime, film.Genre);
            }
            Console.ReadKey();
        }
    }
}
