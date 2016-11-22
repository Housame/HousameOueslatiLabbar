using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_Labb4
{
    class Menus
    {

        //****************************************************
        //    Menus to shows up just for grafic optimizing
        //****************************************************

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
                        Edit();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        BuySell.BuyAndSell();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        VehicleManager.WarehouseInfo();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        loop = false;
                        break;

                }
            }
        }

        internal static void PrintNewUsedMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*      Choose New/Used         *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. New                  *");
            Console.WriteLine("*      2. Used                 *");
            Console.WriteLine("*      3. Back to main menu    *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }

        private static void Edit()
        {
            PrintVehicleEditMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    VehicleManager.AddRemoveCars();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    VehicleManager.AddRemoveMc();
                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    MainMenu();
                    break;
            }
        }


        #region PrintMenus
        static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Main Menu             *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Add/Remove           *");
            Console.WriteLine("*      2. Buy/Sell             *");
            Console.WriteLine("*      3. WareHouse info       *");
            Console.WriteLine("*      4. Exit                 *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        static void PrintVehicleEditMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*      Edit Vehicle list       *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Cars                 *");
            Console.WriteLine("*      2. MC                   *");
            Console.WriteLine("*      3. Back to main menu    *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        public static void PrintAddRemoveMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*          Add / Remove        *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Add                  *");
            Console.WriteLine("*      2. Remove               *");
            Console.WriteLine("*      3. Back to main menu    *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        public static void PrintWareHouseInfo()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*          Warehouse           *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Show all             *");
            Console.WriteLine("*      2. Searck by variant    *");
            Console.WriteLine("*      3. Back to main menu    *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        public static void PrintBuySellMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*          Buy / Sell          *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Buy                  *");
            Console.WriteLine("*      2. Sell                 *");
            Console.WriteLine("*      3. Back to main menu    *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        public static void PrintBuySellCarMcMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*      Buy/Sell Vehicle        *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Cars                 *");
            Console.WriteLine("*      2. MC                   *");
            Console.WriteLine("*      3. Back to main menu    *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        public static void PrintWareHouseShowAllMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*          Warehouse           *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Show Cars            *");
            Console.WriteLine("*      2. Show Mc              *");
            Console.WriteLine("*      3. Back to main menu    *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
        #endregion 
    }
}
