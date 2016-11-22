using HousameOueslati_Labb7.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.Products
{
    class ElectronicsManager
    {
        public void MainMenu()
        {
            Menus menus = new Menus();

            Client client = new Client();
            menus.PrintOptionMenu();
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
                    ShowList();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    client.MainMenu();
                    break;
                

            }
        } // Menyn för att ändra, ta bort, lägga till och visa Electronics listan

        private void ShowList()
        {
            Console.Clear();
            
            PrintElectronicsList();
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }//// Metoden som anropar PrintElectronicsList som i sin tur Visar listans innehåll

        private void RemoveFromList()
        {
            var newElect = Electronics.GetElectronic();
            Console.Clear();
            PrintElectronicsList();
            int index = InputController.IndexController(newElect.Count);

            Electronics.Remove(index);


        }//Tar bort en rad från listan genom att anropa  remove funktionen

        private void AddToList()
        {
            Console.Clear();
            Console.WriteLine("Add new Electronic:");
            var newElectronic = CreateElectronic();
            Electronics.AddElectronic(newElectronic);

        }// Lägger till en rad i listan genom CreateElectronics metoden

        Electronics CreateElectronic()
        {
            Electronics newElectronics = new Electronics();
            newElectronics.ProductName = InputController.NameController();
            newElectronics.Price = InputController.PriceController();
            newElectronics.ProductMake = InputController.MakeController();
            newElectronics.ProductionDate = InputController.YearController();
            newElectronics.ProductionLand = InputController.LandController();
            
            return newElectronics;
        } // metod för att ta emot inputs för list raden och returnera det

        public void PrintElectronicsList()
        {
            int index = 0;
            Console.WriteLine("************************");
            Console.WriteLine("***** Electronics ******");
            Console.WriteLine("************************\n");
            var newElect = Electronics.GetElectronic();
            foreach (var item in newElect)
            {
                index++;
                Console.WriteLine(index+". "+item.GetInformation());
            }
        } //Visar listans innehåll
    }
}
