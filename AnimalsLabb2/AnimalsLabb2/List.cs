using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLabb2
{
    class List
    {
        public static void MainMenu()
        {
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("*                                         Main Menu                                                      *");
            Console.WriteLine("*                                  -----------------------------                                         *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                       1. Add an animal                                                 *");
            Console.WriteLine("*                                       2. Remove an animal                                              *");
            Console.WriteLine("*                                       3. Show a list// all lists                                       *");
            Console.WriteLine("*                                       4. Exit                                                          *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                  ------------------------------                                        *");
            Console.WriteLine("**********************************************************************************************************");

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                    AddAnimal();
                    break;
                case ConsoleKey.NumPad2:
                    RemoveAnimal();
                    break;
                case ConsoleKey.NumPad3:
                    ShowListLists();
                    break;
                case ConsoleKey.NumPad4:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.D1:
                    AddAnimal();
                    break;
                case ConsoleKey.D2:
                    RemoveAnimal();
                    break;
                case ConsoleKey.D3:
                    ShowListLists();
                    break;
                case ConsoleKey.D4:
                    Environment.Exit(0);
                    break;

            }

        }

        private static void ShowListLists()
        {
            ListManager.Show();
        }



        private static void RemoveAnimal()
        {
            ListManager.Remove();
        }

        private static void AddAnimal()
        {
            ListManager.Add();
        }
    }
}
