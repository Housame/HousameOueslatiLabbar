using HousameOueslatiLabb13.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb13.GUI
{
    class Menus
    {
        CarManager carMgr = new CarManager();

        public void MainMenu()
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
                        carMgr.Add();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        carMgr.ShowPowerfulCars();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        carMgr.ShowExpensiveCars();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        carMgr.ShowNewCars();
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        carMgr.ShowElectricCars();
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        carMgr.ShowCars();
                        break;
                    case ConsoleKey.NumPad7:
                    case ConsoleKey.D7:
                        loop = false;
                        break;

                }
            }
        }

        public static void PowerfulCarsMenu()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("Powerful Cars with horse power more than 250hp");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n");
        }

        internal static void ExpensiveCarsMenu()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("Expensive Cars that costs more than 500.000 SEK");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n");
        }

        internal static void NewCarsMenu()
        {
            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("New Cars That are from 2016");
            Console.WriteLine("******************************");
            Console.WriteLine("\n");
        }

        internal static void ElectricCarsMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("Electric Cars that have electricity as fuel");
            Console.WriteLine("********************************************");
            Console.WriteLine("\n");
        }

        void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Main Menu             *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Add cars             *");
            Console.WriteLine("*      2. Powerful cars        *");
            Console.WriteLine("*      3. Expensive Cars       *");
            Console.WriteLine("*      4. New cars             *");
            Console.WriteLine("*      5. Electric cars        *");
            Console.WriteLine("*      6. WareHouse info       *");
            Console.WriteLine("*      7. Exit                 *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
            
        }
    }
}
