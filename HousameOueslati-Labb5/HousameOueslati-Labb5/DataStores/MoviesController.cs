using HousameOueslati_Labb5.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb5.DataStores
{
    class MoviesController
    {
        private IRepository repository = new Movies();

        public void MainMenu()
        {

            Client client = new Client();
            Menus.PrintMainMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    AddToList();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    RemoveFromList();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    EditList();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    ShowList();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    client.Start();
                    break;

            }
        } // Menyn för att ändra, ta bort, lägga till och visa Movie listan

        private void ShowList()
        {
            Console.Clear();
            PrintMovieList();
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
        }// Metoden som anropar PrintMovieList som i sin tur Visar listans innehåll

        private void EditList()
        {
            Console.Clear();
            var movie = Movies.GetMovies();
            PrintMovieList();
            int index = InputController.IndexController(movie.Count);

            EditMovie(movie[index]);
            repository.Remove(index);
            Movies.AddMovie(movie[index]);

        } // tar emot valet, skickar den till EditBook för att ändra, tar bort gamla raden och sätter in den nya i listan

        private void EditMovie(Movies movies)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change Year");
            Console.WriteLine("3. Change Main artist");
            Console.WriteLine("4. Change genre");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Name: {0}, Publishing year: {1}, Main artist: {2}, Genre: {3}", movies.Name, movies.Year, movies.MainArtist, movies.Genre);

            switch (choice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Write("New name: ");
                    movies.Name = InputController.NameController();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Write("New year: ");
                    movies.Year = InputController.YearController();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.Write("New writer: ");
                    movies.MainArtist = InputController.NameController();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.WriteLine("Genre list");
                    PrintMovieGenre();
                    Console.Write("New genre: ");
                    int index = InputController.GenreChoice();
                    movies.Genre = (Movies.GenreType)index;
                    break;
            }
        }  //Tar emot raden som ska ändras och visar alternativen som kan ändras

        private void RemoveFromList()
        {
            var newMovie = Movies.GetMovies();
            Console.Clear();
            PrintMovieList();
            int index = InputController.IndexController(newMovie.Count);

            repository.Remove(index);
        } //Tar bort en rad från listan genom att anropa  remove funktionen från repository

        private void AddToList()
        {
            Console.Clear();
            Console.WriteLine("Add new movie:");
            var newMovie = CreateMovie();
            Movies.AddMovie(newMovie);
        }// Lägger till en rad i listan genom CreateBook metoden

        Movies CreateMovie()
        {
            Movies newMovie = new Movies();
            newMovie.Name = InputController.NameController();
            newMovie.MainArtist = InputController.MainArtistController();
            newMovie.Year = InputController.YearController();
            PrintMovieGenre();
            int choice = InputController.GenreChoice();
            newMovie.Genre = (Movies.GenreType)choice;
            return newMovie;
        } // metod för att ta emot inputs för list raden och returnera det

        private void PrintMovieGenre()
        {
            foreach (var genre in Enum.GetValues(typeof(Movies.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        } //Visar ut Genres

        void PrintMovieList()
        {
            int index = 0;
            var newMovies = Movies.GetMovies();
            foreach (var movie in newMovies)
            {
                index++;
                Console.WriteLine("{4}- Name: {0}, Publishing year: {1}, Main artist: {2}, Genre: {3}", movie.Name, movie.Year, movie.MainArtist, movie.Genre,index);
            }
        } //Visar listans innehåll
    }
}
