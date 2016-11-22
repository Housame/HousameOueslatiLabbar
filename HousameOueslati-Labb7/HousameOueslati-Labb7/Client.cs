using HousameOueslati_Labb7.DataStore;
using HousameOueslati_Labb7.Products;
using HousameOueslati_Labb7.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7
{
    class Client
    {
        #region KlassVariabler
        Menus menus = new Menus();
        ElectronicsManager elect = new ElectronicsManager();
        FoodManager food = new FoodManager();
        ClothesManager clothes = new ClothesManager();
        #endregion
        public void MainMenu()
        {
            menus.PrintMainMenu();


            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    food.MainMenu();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    elect.MainMenu();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    clothes.MainMenu();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    Start();
                    break;

            }

        }

        public void Start()
        {
            ShoppingManagement shoppingManagement = new ShoppingManagement();
            menus.PrintStartMenu();
            var input = Console.ReadKey(true).Key;
            bool loop = true;
            while (loop)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        MainMenu();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        shoppingManagement.ShoppingStart();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        loop = false;
                        break;
                }
            }
        }

        public static void ClearOneLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public static void Timer(double seconds)
        {
            {
                double sec = seconds;
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(sec));
                    return;
                });
                t.Wait();

            }
        }



    }
}
