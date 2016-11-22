using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb3
{
    class ListManager
    {
        #region Lists declaration
        public List<Tupac> tupacList { get; set; }
        public List<Biggie> biggieList { get; set; }
        public List<RioDeJaneiro> rioDeJaneiroList { get; set; }
        public List<NewOrleans> newOrleansList { get; set; }
        public List<BloodInBlooadOut> bloodInBloodOutList { get; set; }
        public List<Scarface> scarfaceList { get; set; }
       
        #endregion//Listorna 

        public ListManager()
        {
            tupacList = new List<Tupac>() {
                new Tupac {
                AllowedAge = 16,
                Type = "Concert",
                Place = "House of blues Los Angeles",
                Date = new DateTime(2016, 10, 31, 19, 00, 0),
                EventName = "All eyes On me release",
                Price = 60
                }
            };
            biggieList = new List<Biggie>(){
                new Biggie {
                AllowedAge = 16,
                Type = "Concert",
                Place = "Brendan Byrne Arena, East Rutherford, NJ, USA",
                Date = new DateTime(2017, 03, 19, 19, 00, 0),
                EventName = "The Notorious B.I.G. at Hot 97 Summer Jam 1995",
                Price = 60
                }
            };
            rioDeJaneiroList = new List<RioDeJaneiro>(){
                new RioDeJaneiro {
                AllowedAge = 7,
                Type = "Festival",
                Place = "Sambadrome Marquês de Sapucaí, Rio de Janeiro",
                Date = new DateTime(2017, 02, 24, 09, 00, 0),
                EventName = "Rio De Janeiro Carnaval 2017",
                Price = 20
                }
            };
            newOrleansList = new List<NewOrleans>(){
                new NewOrleans {
                AllowedAge = 16,
                Type = "Festival",
                Place = "Fair Grounds Race Course & Slots, 1751 Gentilly Blvd., New Orleans, LA 70119",
                Date = new DateTime(2017, 04, 28, 09, 00, 0),
                EventName = "New Orleans Jazz Fest 2017",
                Price = 35
                }
            };
            bloodInBloodOutList = new List<BloodInBlooadOut>()
            {
                new BloodInBlooadOut { 
                AllowedAge = 16,
                Type = "Movie",
                Place = "ArcLight Hollywood",
                Date = new DateTime(2016, 11, 15, 21, 00, 0),
                EventName = "Blood in blood out Release",
                Price = 25
                }
            };
            scarfaceList = new List<Scarface>()
                {
                new Scarface {
                AllowedAge = 16,
                Type = "Movie",
                Place = "O Cinema Wynwood",
                Date = new DateTime(2016, 11, 28, 21, 00, 0),
                EventName = "Scarface Release",
                Price = 25
                }
            };

        } //Initialisering av listorna

        public void ShowCinema()
        {
            Menus.PrintCinemaMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("****************");
                    Console.WriteLine("****Scarface****\n");
                    foreach (var item in scarfaceList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n****Scarface****");
                    Console.WriteLine("****************");
                    Console.ReadKey();

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("**************************");
                    Console.WriteLine("****Bllod in blood out****\n");
                    foreach (var item in bloodInBloodOutList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n****Bllod in blood out****");
                    Console.WriteLine("**************************");
                    Console.ReadKey();
                    break;
            }
        } //Visar bio events filmerna som finns samt infon

        public void ShowConcerts()
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
                    foreach (var item in tupacList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n  ****Tupac****");
                    Console.WriteLine("****************");
                    Console.ReadKey();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("****************");
                    Console.WriteLine(" ****Biggie****\n");
                    foreach (var item in biggieList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n ****Biggie****");
                    Console.WriteLine("****************");
                    Console.ReadKey();
                    break;
            }
        } //Visar konserts events filmerna som finns samt infon

        public void ShowFestivals()
        {
            Menus.PrintFestivalsMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("**************************");
                    Console.WriteLine("  ****Rio De Janeiro****\n");
                    foreach (var item in rioDeJaneiroList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n  ****Rio De Janeiro****");
                    Console.WriteLine("**************************");
                    Console.ReadKey();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("**************************");
                    Console.WriteLine("     ****New Orleans****\n");
                    foreach (var item in newOrleansList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("\n     ****New Orleans****");
                    Console.WriteLine("**************************");
                    Console.ReadKey();
                    break;
            }
        } //Visar festivaler events filmerna som finns samt infon


    }
}
