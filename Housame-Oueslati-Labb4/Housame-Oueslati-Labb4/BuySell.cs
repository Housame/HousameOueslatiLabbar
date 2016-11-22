using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_Labb4
{
    class BuySell
    {
        public static void BuyAndSell()
        {
            Menus.PrintBuySellCarMcMenu();
            
            
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    BuySellCars();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    BuySellMc();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
            }
        }

        //Alla metoder i stort sett har det samma algoritm bara variablerna som ändras

        private static void BuySellCars()
        {

            Menus.PrintNewUsedMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    BuySellNewCars();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    BuySellUsedCars();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
            }
        }

        #region Buy Sell/Buy New cars
        private static void BuySellNewCars()
        {
            Menus.PrintBuySellMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    BuyNewCars();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SellNewCars();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
            }
        }

        private static void SellNewCars()
        {
            List<Cars> newCars = new List<Cars>();
            newCars = VehicleManager.CarList.FindAll(cars => cars.Used == false);
            VehicleManager.CarList.RemoveAll(cars => cars.Used == false);
            for (int i = 0; i < newCars.Count; i++)
            {
                Console.WriteLine("*************************");
                Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", newCars[i].Make, newCars[i].Variant, newCars[i].Quantity, newCars[i].ModelYear, newCars[i].Power, newCars[i].MileAge, newCars[i].Fuel, newCars[i].Price);
            }
            int listCount = newCars.Count;
            Console.WriteLine("Pick out which car you want to sell!");
            int index = InputController.IndexController(listCount);
            int quantitySell = InputController.QuantityController();
            newCars[index - 1].Quantity = newCars[index - 1].Quantity - quantitySell;
            VehicleManager.CarList.AddRange(newCars);
        }

        private static void BuyNewCars()
        {
            List<Cars> newCars = new List<Cars>();
            newCars = VehicleManager.CarList.FindAll(cars => cars.Used == false);
            VehicleManager.CarList.RemoveAll(cars => cars.Used == false);
            for (int i = 0; i < newCars.Count; i++)
            {
                Console.WriteLine("*************************");
                Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", newCars[i].Make, newCars[i].Variant, newCars[i].Quantity, newCars[i].ModelYear, newCars[i].Power, newCars[i].MileAge, newCars[i].Fuel, newCars[i].Price);
            }
            int listCount = newCars.Count;
            Console.WriteLine("Pick out which car you want to buy!");
            int index = InputController.IndexController(listCount);
            int quantityBuy = InputController.QuantityController();
            newCars[index - 1].Quantity = newCars[index - 1].Quantity + quantityBuy;
            VehicleManager.CarList.AddRange(newCars);
        }
        #endregion 

        #region Buy Sell/Buy Use cars
        private static void BuySellUsedCars()
        {

            Menus.PrintBuySellMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    BuyUsedCars();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SellUsedCars();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
            }
        }

        private static void SellUsedCars()
        {
            List<Cars> usedCars = new List<Cars>();
            usedCars = VehicleManager.CarList.FindAll(cars => cars.Used == true);
            VehicleManager.CarList.RemoveAll(cars => cars.Used == true);
            for (int i = 0; i < usedCars.Count; i++)
            {
                Console.WriteLine("*************************");
                Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", usedCars[i].Make, usedCars[i].Variant, usedCars[i].Quantity, usedCars[i].ModelYear, usedCars[i].Power, usedCars[i].MileAge, usedCars[i].Fuel, usedCars[i].Price);
            }
            int listCount = usedCars.Count;
            Console.WriteLine("Pick out which car you want to sell!");
            int index = InputController.IndexController(listCount);
            int quantitySell = InputController.QuantityController();
            usedCars[index - 1].Quantity = usedCars[index - 1].Quantity - quantitySell;
            VehicleManager.CarList.AddRange(usedCars);
        }

        private static void BuyUsedCars()
        {
            List<Cars> usedCars = new List<Cars>();
            usedCars = VehicleManager.CarList.FindAll(cars => cars.Used == true);
            VehicleManager.CarList.RemoveAll(cars => cars.Used == true);
            for (int i = 0; i < usedCars.Count; i++)
            {
                Console.WriteLine("*************************");
                Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", usedCars[i].Make, usedCars[i].Variant, usedCars[i].Quantity, usedCars[i].ModelYear, usedCars[i].Power, usedCars[i].MileAge, usedCars[i].Fuel, usedCars[i].Price);
            }
            int listCount = usedCars.Count;
            Console.WriteLine("Pick out which car you want to Buy!");
            int index = InputController.IndexController(listCount);
            int quantityBuy = InputController.QuantityController();
            usedCars[index - 1].Quantity = usedCars[index - 1].Quantity + quantityBuy;
            VehicleManager.CarList.AddRange(usedCars);
        }
        #endregion

        private static void BuySellMc()
        {
            
            Menus.PrintNewUsedMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    BuySellNewMc();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    BuySellUsedMc();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
            }
        }

        #region Buy Sell/Buy Used cars
        private static void BuySellUsedMc()
        {
            
            Menus.PrintBuySellMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    BuyUsedMc();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SellUsedMc();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
            }
        }

        private static void SellUsedMc()
        {
            List<Mc> usedMc = new List<Mc>();
            usedMc = VehicleManager.McList.FindAll(mc => mc.Used == true);
            VehicleManager.McList.RemoveAll(mc => mc.Used == true);
            for (int i = 0; i < usedMc.Count; i++)
            {
                Console.WriteLine("*************************");
                Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", usedMc[i].Make, usedMc[i].Variant, usedMc[i].Quantity, usedMc[i].ModelYear, usedMc[i].Power, usedMc[i].MileAge, usedMc[i].Fuel, usedMc[i].Price);
            }
            int listCount = usedMc.Count;
            Console.WriteLine("Pick out which car you want to sell!");
            int index = InputController.IndexController(listCount);
            int quantitySell = InputController.QuantityController();
            usedMc[index - 1].Quantity = usedMc[index - 1].Quantity - quantitySell;
            VehicleManager.McList.AddRange(usedMc);
            

        }

        private static void BuyUsedMc()
        {
            List<Mc> usedMc = new List<Mc>();
            usedMc = VehicleManager.McList.FindAll(mc => mc.Used == true);
            VehicleManager.McList.RemoveAll(mc => mc.Used == true);
            for (int i = 0; i < usedMc.Count; i++)
            {
                Console.WriteLine("*************************");
                Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", usedMc[i].Make, usedMc[i].Variant, usedMc[i].Quantity, usedMc[i].ModelYear, usedMc[i].Power, usedMc[i].MileAge, usedMc[i].Fuel, usedMc[i].Price);
            }
            int listCount = usedMc.Count;
            Console.WriteLine("Pick out which car you want to Buy!");
            int index = InputController.IndexController(listCount);
            int quantityBuy = InputController.QuantityController();
            usedMc[index - 1].Quantity = usedMc[index - 1].Quantity + quantityBuy;
            VehicleManager.McList.AddRange(usedMc);
        }
        #endregion

        #region Buy Sell/Buy New Mc
        private static void BuySellNewMc()
        {

            Menus.PrintBuySellMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    BuyNewMc();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SellNewdMc();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
            }
        }

        private static void SellNewdMc()
        {
            List<Mc> newMc = new List<Mc>();
            newMc = VehicleManager.McList.FindAll(mc => mc.Used == false);
            VehicleManager.McList.RemoveAll(mc => mc.Used == false);
            for (int i = 0; i < newMc.Count; i++)
            {
                Console.WriteLine("*************************");
                Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", newMc[i].Make, newMc[i].Variant, newMc[i].Quantity, newMc[i].ModelYear, newMc[i].Power, newMc[i].MileAge, newMc[i].Fuel, newMc[i].Price);
            }
            int listCount = newMc.Count;
            Console.WriteLine("Pick out which car you want to sell!");
            int index = InputController.IndexController(listCount);
            int quantitySell = InputController.QuantityController();
            newMc[index - 1].Quantity = newMc[index - 1].Quantity - quantitySell;
            VehicleManager.McList.AddRange(newMc);
        }

        private static void BuyNewMc()
        {
            List<Mc> newMc = new List<Mc>();
            newMc = VehicleManager.McList.FindAll(mc => mc.Used == false);
            VehicleManager.McList.RemoveAll(mc => mc.Used == false);
            for (int i = 0; i < newMc.Count; i++)
            {
                Console.WriteLine("*************************");
                Console.WriteLine(" Make: {0}|| Variant: {1}|| Quantity: {2}||ModelYear: {3}|| Power: {4}|| MileAge: {5}|| Fuel: {6}|| Price: {7} SEK||", newMc[i].Make, newMc[i].Variant, newMc[i].Quantity, newMc[i].ModelYear, newMc[i].Power, newMc[i].MileAge, newMc[i].Fuel, newMc[i].Price);
            }
            int listCount = newMc.Count;
            Console.WriteLine("Pick out which car you want to sell!");
            int index = InputController.IndexController(listCount);
            int quantityBuy = InputController.QuantityController();
            newMc[index - 1].Quantity = newMc[index - 1].Quantity + quantityBuy;
            VehicleManager.McList.AddRange(newMc);
        }
        #endregion


    }
}
