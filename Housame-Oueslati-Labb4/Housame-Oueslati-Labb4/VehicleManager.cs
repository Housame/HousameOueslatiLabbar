using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_Labb4
{
    class VehicleManager
    {
        public static List<Cars> CarList = new List<Cars>();
        public static List<Mc> McList = new List<Mc>();

        #region Add and Remove Cars and Mc
        public static void AddRemoveCars()
        {
            Menus.PrintAddRemoveMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Cars tempCars = new Cars();
                    Console.WriteLine("*************************\n");
                    tempCars.Make = InputController.MakeController();
                    tempCars.Variant = InputController.VariantController();
                    tempCars.ModelYear = InputController.ModelYearController();
                    tempCars.Power = InputController.PowerController();
                    tempCars.MileAge = InputController.MileAgeController();
                    tempCars.Fuel = InputController.FuelController();
                    tempCars.Price = InputController.PriceController();
                    tempCars.Used = InputController.UsedController();
                    tempCars.Quantity = InputController.QuantityController();
                    CarList.Add(tempCars);
                    Runtime.Timer(1);
                    Menus.MainMenu();

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    
                    for (int i = 0; i < CarList.Count; i++)
                    {

                        Console.WriteLine("*************************");
                        Console.WriteLine((i + 1) + " Make: {0}|| Variant: {1}|| ModelYear: {2}|| Power: {3}|| MileAge: {4}|| Fuel: {5}|| Price: {6} SEK||", CarList[i].Make, CarList[i].Variant, CarList[i].ModelYear, CarList[i].Power, CarList[i].MileAge, CarList[i].Fuel, CarList[i].Price);
                    }
                    int listCount = CarList.Count;
                    int index = InputController.IndexController(listCount);
                    CarList.RemoveAt(index - 1);
                    Console.WriteLine("The car number {0} is removed from your database!",index);
                    Runtime.Timer(1);
                    Menus.MainMenu();

                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Menus.MainMenu();
                    break;

            }
        }

        public static void AddRemoveMc()
        {
            Menus.PrintAddRemoveMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Mc tempMc= new Mc();
                    Console.WriteLine("*************************\n");
                    tempMc.Make = InputController.MakeController();
                    tempMc.Variant = InputController.VariantController();
                    tempMc.ModelYear = InputController.ModelYearController();
                    tempMc.Power = InputController.PowerController();
                    tempMc.MileAge = InputController.MileAgeController();
                    tempMc.Fuel = InputController.FuelController();
                    tempMc.Price = InputController.PriceController();
                    tempMc.Used = true;
                    McList.Add(tempMc);
                    Runtime.Timer(1);
                    Menus.MainMenu();

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:

                    for (int i = 0; i < McList.Count; i++)
                    {
                        Console.WriteLine("*************************");
                        Console.WriteLine((i + 1) + " Make: {0}|| Variant: {1}|| ModelYear: {2}|| Power: {3}|| MileAge: {4}|| Fuel: {5}|| Price: {6} SEK||", McList[i].Make, McList[i].Variant, McList[i].ModelYear, McList[i].Power, McList[i].MileAge, McList[i].Fuel, McList[i].Price);
                    }
                    int listCount = McList.Count;
                    int index = InputController.IndexController(listCount);
                    McList.RemoveAt(index - 1);
                    Console.WriteLine("The car number {0} is removed from your database!", index);
                    Runtime.Timer(1);
                    Menus.MainMenu();

                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Menus.MainMenu();
                    break;

            }
        }
        #endregion

        #region Warehouse info / search by variant / show quantity of all cars - mc
        public static void WarehouseInfo()
        {
            List<Cars> newCars = new List<Cars>();
            List<Mc> newMC = new List<Mc>();
            Menus.PrintWareHouseInfo();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    WareHouseShowAll();

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("****************************");
                    Console.WriteLine("******Search by variant*****");
                    string variantToSearch = InputController.VariantController().ToUpper();
                    newCars = CarList.FindAll(cars => string.Equals(cars.Variant.ToUpper(), variantToSearch));
                    newMC = McList.FindAll(mc => string.Equals(mc.Variant, variantToSearch));
                    
                    Console.WriteLine("*****************************\n");
                    if (newCars.Count >= 1)
                    { 
                        foreach (var item in newCars)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    else if (newMC.Count >= 1)
                    { foreach (var item in newMC)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    else Console.WriteLine("The Variant you search doesn´t exist in your database!!");
                    Runtime.Timer(1);
                    WarehouseInfo();
                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Menus.MainMenu();
                    break;

            }
        }

        private static void WareHouseShowAll()
        {
            Menus.PrintWareHouseShowAllMenu();
            int quantityOfAll=0;
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:                    
                    Console.WriteLine("*****************************\n");
                    for (int i = 0; i < CarList.Count; i++)
                    {
                        quantityOfAll += CarList[i].Quantity;
                    }
                    Console.WriteLine("You have {0} cars in total of all models!",quantityOfAll);
                    foreach (var item in CarList)
                    {
                        Console.WriteLine("*************************");
                        Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", item.Make, item.Variant, item.Quantity, item.ModelYear, item.Power, item.MileAge, item.Fuel, item.Price);

                    }
                    Console.WriteLine("\n*****************************");
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.WriteLine("*****************************\n");
                    for (int i = 0; i < McList.Count; i++)
                    {
                        quantityOfAll += McList[i].Quantity;
                    }
                    Console.WriteLine("You have {0} motorcycle in total of all models!", quantityOfAll);
                    foreach (var item in McList)
                    {

                        Console.WriteLine("*************************");
                        Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", item.Make, item.Variant, item.Quantity, item.ModelYear, item.Power, item.MileAge, item.Fuel, item.Price);

                    }
                    Console.WriteLine("\n*****************************");
                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Menus.MainMenu();
                    break;

            }
        }
        #endregion
    }
}
