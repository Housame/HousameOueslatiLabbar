using HousameOueslati_Labb5.DataStores;
using HousameOueslati_Labb5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb5
{
    class Menus
    {
        static IRepository bookRepository = new Books();
        static IRepository movieRepository = new Movies();
        public static void MainMenu()
        {

            var books = new BooksController();
            var movies = new MoviesController();
            Client client = new Client();
            bool loop = true;
            while (loop)
                
            {
                Menus.PrintStartMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        bookRepository.CreateGetFile();
                        books.MainMenu();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        movieRepository.CreateGetFile();
                        movies.MainMenu();
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        loop = false;
                        break;

                }
            }
        }

        public static void PrintStartMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Start Menu            *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Books                *");
            Console.WriteLine("*      2. Films                *");
            Console.WriteLine("*      3. Exit                 *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }

        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Main Menu             *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Add                  *");
            Console.WriteLine("*      2. Remove               *");
            Console.WriteLine("*      3. Edit                 *");
            Console.WriteLine("*      4. Show                 *");
            Console.WriteLine("*      5. Back to start menu   *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
    }
}
