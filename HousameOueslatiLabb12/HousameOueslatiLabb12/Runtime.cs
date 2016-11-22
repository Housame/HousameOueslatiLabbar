using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb12
{
    class Runtime
    {
        Menus menus = new Menus();
        LINQMethods linq = new LINQMethods();
        public void Start()
        {
            do
            {
                menus.StartMenu();
                GetChoice();
            } while (true);
        }

        void GetChoice()
        {
            var input = Console.ReadKey(true).Key;
            switch(input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    linq.SearchByTitle();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    linq.SearchByGenre();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    linq.ShortFilms();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    linq.AllTitlesInOne();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    linq.FillMyString();
                    break;
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:
                    linq.SearchByFirstLetter();
                    break;
                case ConsoleKey.NumPad7:
                case ConsoleKey.D7:
                    linq.ShowAllFilms();
                    break;
                case ConsoleKey.NumPad8:
                case ConsoleKey.D8:
                    Environment.Exit(0);
                    break;
            }
        }
        public static void ClearOneLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

    }
}
