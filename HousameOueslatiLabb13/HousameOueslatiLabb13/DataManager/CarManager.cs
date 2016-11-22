using HousameOueslatiLabb13.Filters;
using HousameOueslatiLabb13.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HousameOueslatiLabb13.Delegates;

namespace HousameOueslatiLabb13.DataManager
{
    class CarManager
    {
        Cars car = new Cars();
        
        
        public void Add()
        {
            Console.Clear();
            Console.WriteLine("Add new car:");
            var newCar = CreateCars();
            
            car.AddCars(newCar);

        }// Lägger till en rad i listan genom CreateCars metoden

        Cars CreateCars()
        {
            InputControllers inputController = new InputControllers();
            Cars tempCars = new Cars();
            Console.WriteLine("*************************\n");
            tempCars.Make = inputController.MakeController();
            tempCars.Variant = inputController.VariantController();
            tempCars.ModelYear = inputController.ModelYearController();
            tempCars.Power = inputController.PowerController();
            tempCars.Fuel = inputController.FuelController();
            tempCars.Price = inputController.PriceController();
            return tempCars;
        } // metod för att ta emot inputs för list raden och returnera det

        public void ShowPowerfulCars()
        {
            CarManager carMgr = new CarManager();
            CarFilter isPowerful = CarFilters.IsPowerful;
            Menus.PowerfulCarsMenu();
            carMgr.PrintWhere(isPowerful);
            Console.ReadKey();
        }

        public void ShowExpensiveCars()
        {
            CarManager carMgr = new CarManager();
            CarFilter isExpensive = CarFilters.IsExpensive;
            Menus.ExpensiveCarsMenu();
            carMgr.PrintWhere(isExpensive);
            Console.ReadKey();
        }

        public void ShowElectricCars()
        {
            CarManager carMgr = new CarManager();
            CarFilter isElectric = CarFilters.IsElectric;
            Menus.ElectricCarsMenu();
            carMgr.PrintWhere(isElectric);
            Console.ReadKey();
        }

        public void ShowNewCars()
       {
            CarManager carMgr = new CarManager();
            CarFilter isNew = CarFilters.IsNew;
            Menus.NewCarsMenu();
            carMgr.PrintWhere(isNew);
            Console.ReadKey();
        }

        public void ShowCars()
        {
            Console.Clear();
            var newCars = car.GetCar();
            foreach (var cars in newCars)
            {
                Console.WriteLine("Make: {0}, Variant: {1}, Model year: {2}, Horse Power: {3}, Fuel: {4}, Price: {5}",cars.Make,cars.Variant,cars.ModelYear,cars.Power,cars.Fuel,cars.Price);
            }
            Console.ReadKey();
        }

        public void PrintWhere(CarFilter filter)
        {
            foreach (var car in Cars.CarList)
            {
                if (filter(car))
                    Console.WriteLine("Make: {0}, Variant: {1}, Model year: {2}, Horse Power: {3}, Fuel: {4}, Price: {5}", car.Make, car.Variant, car.ModelYear, car.Power, car.Fuel, car.Price);
            }
        }
    }
}
