using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb3
{
    class BuyTickets : Event
    {
        public static int tempAgeAllowed;// För att lagra AllowedAge för att se till om användaren får boka evenemanget eller ej
        static ListManager manager = new ListManager();// instans för ListManager
        public static List<Tickets> AllTicket = new List<Tickets>();//Listan av Ticket
        static string info;//För att lagra evenemangets info och överföra det sen till Tickets--Info för att kuna visa den när man söker biljetterna

        internal static void FestivalTickets()
        {

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("**************************");
                    Console.WriteLine("  ****Rio De Janeiro****\n");
                    foreach (var item in manager.rioDeJaneiroList)
                    {
                        info = item.ToString();
                        Console.WriteLine(info);

                    }
                    Console.WriteLine("\n  ****Rio De Janeiro****");
                    Console.WriteLine("**************************");
                    tempAgeAllowed = 7;
                    BuyTicket();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("**************************");
                    Console.WriteLine("     ****New Orleans****\n");
                    foreach (var item in manager.newOrleansList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n     ****New Orleans****");
                    Console.WriteLine("**************************");
                    tempAgeAllowed = 16;
                    BuyTicket();
                    break;
            }
        }//Grafiska menyn för Festival som ropar BuyTicket

        internal static void CinemaTickets()
        {

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("****************");
                    Console.WriteLine("****Scarface****\n");
                    foreach (var item in manager.scarfaceList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n****Scarface****");
                    Console.WriteLine("****************");
                    tempAgeAllowed = 16;
                    BuyTicket();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("**************************");
                    Console.WriteLine("****Bllod in blood out****\n");
                    foreach (var item in manager.bloodInBloodOutList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n****Bllod in blood out****");
                    Console.WriteLine("**************************");
                    tempAgeAllowed = 16;
                    BuyTicket();
                    break;
            }
        }//Grafiska menyn för Cinema som ropar BuyTicket

        internal static void ConcertsTickets()
        {

            Console.Clear();
            Menus.PrintConcertsMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("****************");
                    Console.WriteLine("  ****Tupac****\n");
                    foreach (var item in manager.tupacList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n  ****Tupac****");
                    Console.WriteLine("****************");
                    tempAgeAllowed = 16;
                    BuyTicket();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("****************");
                    Console.WriteLine(" ****Biggie****\n");
                    foreach (var item in manager.biggieList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n ****Biggie****");
                    Console.WriteLine("****************");
                    tempAgeAllowed = 16;
                    BuyTicket();
                    break;
            }
        }//Grafiska menyn för Concerts som ropar BuyTicket


        private static void BuyTicket()
        {

            //User user = new User();
            Tickets newTickets = new Tickets();
            Console.WriteLine("**********************");
            Console.WriteLine("*****Buy Tickets******\n");

            newTickets.Name = InputController.NameController().ToUpper();
            newTickets.Age = InputController.AgeController();
            newTickets.UserId = InputController.UserIdController();
            newTickets.Info = info;

            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("**********************\n");
            Console.WriteLine("    Name: " + newTickets.Name);
            Console.WriteLine("    Age: " + newTickets.Age);
            Console.WriteLine("    UserId: " + newTickets.UserId);
            Console.WriteLine("\n**********************");
            Console.WriteLine("**********************\n");
            Console.WriteLine("Is it right? Press 1 else press 2");
            var tempInput = Console.ReadKey(true).Key;
            switch (tempInput)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    AllTicket.Add(newTickets);
                    Console.WriteLine("Your reservation is confirmed!");
                    Runtime.Timer(2);
                    Menus.MainMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.WriteLine("You´re heading back to Buy Ticket menu!!");
                    Runtime.Timer(1.5);
                    Console.Clear();
                    BuyTicket();
                    break;
            }

        }//Metoden för att boka biljetter, spara den i AllTicket listan
    }

}
