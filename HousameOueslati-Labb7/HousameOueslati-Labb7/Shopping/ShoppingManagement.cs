using HousameOueslati_Labb7.DataStore;
using HousameOueslati_Labb7.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.Shopping
{
    class ShoppingManagement
    {
        #region KlassVariabler
        IBuyable sC = new ShoppingCart();
        Menus menus = new Menus();
        Client client = new Client();
        ClothesManager clothesManager = new ClothesManager();
        ElectronicsManager elect = new ElectronicsManager();
        FoodManager food = new FoodManager();
        #endregion

        public void ShoppingStart()
        {
            Console.Clear();
            menus.PrntShoppingStart();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    BuyFromFood();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    BuyFromElectronics();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    BuyFromClothes();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    ShowShoppingCart();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    client.Start();
                    break;
            }
        }

        private void ShowShoppingCart()
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("***  Shopping Cart  ***");
            Console.WriteLine("***********************\n");
            Console.WriteLine("You bought {0} items with a total amount: {1} SEK", sC.TotalQuantity(), sC.TotalPrice());
            Console.WriteLine("************************");
            int index = 0;
            foreach (var item in ListManager.ShoppingCart)
            {
                index++;
                Console.WriteLine(index + item.GetInformation());
            }
            Console.ReadKey();
        }

        private void BuyFromClothes()
        {
            var newClothes = Clothes.GetClothes();
            clothesManager.PrintClothesList();
            int index = InputController.IndexController(newClothes.Count);

            Console.WriteLine("You've chosen:");
            Console.WriteLine(newClothes[index].GetInformation());
            Console.WriteLine("\nAdd it? press 1 not? press 2");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    AddClothesToShopCart(newClothes[index]);

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    BuyFromClothes();
                    break;

            }
        }

        private void AddClothesToShopCart(Clothes newClothes)
        {
            var tempShoppingList = new ShoppingCart();
            tempShoppingList.Name = newClothes.ProductName;
            tempShoppingList.Quantity = InputController.QuantityController();
            tempShoppingList.Price = tempShoppingList.Quantity * newClothes.Price;
            sC.AddToCart(tempShoppingList);
            Console.WriteLine("The product {0} is successfully added to your cart!", tempShoppingList.Name);
            Console.WriteLine("Continue? Press 1! Shop another item from another categorie? press 2");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    BuyFromClothes();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    ShoppingStart();
                    break;
            }
        }

        private void BuyFromElectronics()
        {
            var newElect = Electronics.GetElectronic();
            elect.PrintElectronicsList();
            int index = InputController.IndexController(newElect.Count);

            Console.WriteLine("You've chosen:");
            Console.WriteLine(newElect[index].GetInformation());
            Console.WriteLine("\nAdd it? press 1 not? press 2");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    AddElectronicsToShopCart(newElect[index]);

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    BuyFromElectronics();
                    break;
            }
        }

        private void AddElectronicsToShopCart(Electronics newElectronics)
        {
            var tempShoppingList = new ShoppingCart();
            tempShoppingList.Name = newElectronics.ProductName;
            tempShoppingList.Quantity = InputController.QuantityController();
            tempShoppingList.Price = tempShoppingList.Quantity * newElectronics.Price;
            ListManager.ShoppingCart.Add(tempShoppingList);
            Console.WriteLine("The product {0} is successfully added to your cart!", tempShoppingList.Name);
            Client.Timer(2);
            Console.WriteLine("Continue? Press 1! Shop another item from another categorie? press 2");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    BuyFromElectronics();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    ShoppingStart();
                    break;
            }

        }

        private void BuyFromFood()
        {
            var newFood = Food.GetFood();
            food.PrintFoodList();
            int index = InputController.IndexController(newFood.Count);

            Console.WriteLine("You've chosen:");
            Console.WriteLine(newFood[index].GetInformation());
            Console.WriteLine("\nAdd it? press 1 not? press 2");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    AddFoodToShopCart(newFood[index]);

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    BuyFromFood();
                    break;
            }
        }

        private void AddFoodToShopCart(Food newFood)
        {

            var tempShoppingList = new ShoppingCart();
            tempShoppingList.Name = newFood.ProductName;
            tempShoppingList.Quantity = InputController.QuantityController();
            tempShoppingList.Price = tempShoppingList.Quantity * newFood.Price;
            ListManager.ShoppingCart.Add(tempShoppingList);
            Console.WriteLine("The product {0} is successfully added to your cart!", tempShoppingList.Name);
            Client.Timer(2);
            Console.WriteLine("Continue? Press 1! Shop another item from another categorie? press 2");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    BuyFromFood();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    ShoppingStart();
                    break;


            }
        }
    }
}
