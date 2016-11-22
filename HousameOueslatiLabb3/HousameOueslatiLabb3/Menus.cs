using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb3
{
    class Menus
    {

        public static void MainMenu()
        {

            bool loop = true;
            while (loop)
            {
                PrintMainMenu();

                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        BuyTicket();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        ShowEvents();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Tickets.ShowMyTickets();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        loop = false;
                        break;

                }
            }
        } //Huvud Menyn

        private static void ShowEvents()
        {
            ListManager manager = new ListManager();
            PrintEventsMenu();


            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    manager.ShowFestivals();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    manager.ShowConcerts();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    manager.ShowCinema();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    MainMenu();
                    break;

            }
        } // Meny som visar events anropar under-metoder "för grafisk förbättring"

        private static void BuyTicket()
        {
            PrintEventsMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    PrintFestivalsMenu();
                    BuyTickets.FestivalTickets();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    PrintConcertsMenu();
                    BuyTickets.ConcertsTickets();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    PrintCinemaMenu();
                    BuyTickets.FestivalTickets();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    MainMenu();
                    break;
            }

        } //Meny för att köpa biljetter anropar några PrintMenu sen går den till klassen BuyTicket för mer specifikt

        //Menyer som är grafiskt optimiserat
        #region Printing Menus
        private static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Main Menu             *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Buy tickets          *");
            Console.WriteLine("*      2. Show events          *");
            Console.WriteLine("*      3. Show my tickets      *");
            Console.WriteLine("*      4. Exit                 *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        private static void PrintEventsMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*       Show Events            *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Festivals            *");
            Console.WriteLine("*      2. Concerts             *");
            Console.WriteLine("*      3. Cinema               *");
            Console.WriteLine("*      4. Back to Main menu    *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        internal static void PrintCinemaMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*           Cinema             *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. ScarFace             *");
            Console.WriteLine("*      2. Blood in Blood Out   *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        internal static void PrintConcertsMenu()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("*          Concert             *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Tupac                *");
            Console.WriteLine("*      2. Biggie               *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        internal static void PrintFestivalsMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*         Festivals            *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Rio De Janeiro       *");
            Console.WriteLine("*      2. New Orleans          *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }

        #endregion //

    }
}
