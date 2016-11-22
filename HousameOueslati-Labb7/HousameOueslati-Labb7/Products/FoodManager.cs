using HousameOueslati_Labb7.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.Products
{
    class FoodManager
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

            PrintFoodList();
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }//// Metoden som anropar PrintFoodList som i sin tur Visar listans innehåll

        private void RemoveFromList()
        {
            var newFood = Food.GetFood();
            Console.Clear();
            PrintFoodList();
            int index = InputController.IndexController(newFood.Count);

            Food.Remove(index);


        }//Tar bort en rad från listan genom att anropa  remove funktionen 

        private void AddToList()
        {
            Console.Clear();
            Console.WriteLine("Add new Food:");
            var newFood = CreateFood();
            Food.AddFood(newFood);

        }// Lägger till en rad i listan genom CreateFood metoden

        Food CreateFood()
        {
            Food newFood = new Food();
            newFood.ProductName = InputController.NameController();
            newFood.Price = InputController.PriceController();
            newFood.ProductMake = InputController.MakeController();
            newFood.ProductionDate = InputController.YearController();
            newFood.ProductionLand = InputController.LandController();

            return newFood;
        } // metod för att ta emot inputs för list raden och returnera det

        public void PrintFoodList()
        {
            int index = 0; Console.WriteLine("************************");
            Console.WriteLine("********* Food *********");
            Console.WriteLine("************************\n");
            var newFood = Food.GetFood();
            foreach (var item in newFood)
            {
                index++;
                Console.WriteLine(index + ". " + item.GetInformation());
            }
            
        } //Visar listans innehåll
    }
}
