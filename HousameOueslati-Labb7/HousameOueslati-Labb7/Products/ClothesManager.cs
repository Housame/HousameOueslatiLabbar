using HousameOueslati_Labb7.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.Products
{
    class ClothesManager
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
        } // Menyn för att ändra, ta bort, lägga till och visa Clothes listan

        private void ShowList()
        {
            Console.Clear();

            PrintClothesList();
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }//// Metoden som anropar PrintClothesList som i sin tur Visar listans innehåll

        private void RemoveFromList()
        {
            var newClothes = Clothes.GetClothes();
            Console.Clear();
            PrintClothesList();
            int index = InputController.IndexController(newClothes.Count);

            Clothes.Remove(index);


        }//Tar bort en rad från listan genom att anropa  remove funktionen 

        private void AddToList()
        {
            Console.Clear();
            Console.WriteLine("Add new Clothes:");
            var newClothes = CreateClothes();
            Clothes.AddClothes(newClothes);

        }// Lägger till en rad i listan genom CreateElectronics metoden

        Clothes CreateClothes()
        {
            Clothes newClothes = new Clothes();
            newClothes.ProductName = InputController.NameController();
            newClothes.Price = InputController.PriceController();
            newClothes.ProductMake = InputController.MakeController();
            newClothes.ProductionDate = InputController.YearController();
            newClothes.ProductionLand = InputController.LandController();

            return newClothes;
        } // metod för att ta emot inputs för list raden och returnera det

        public void PrintClothesList()
        {
            int index = 0;
            Console.WriteLine("************************");
            Console.WriteLine("******* Clothes ********");
            Console.WriteLine("************************\n");
            var newClothes = Clothes.GetClothes();
            foreach (var item in newClothes)
            {
                index++;
                Console.WriteLine(index+". "+item.GetInformation());
            }
        } //Visar listans innehåll
    }
}
