using HousameOueslati_Labb7.DataStore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.Products
{
    class Food : Product
    {
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string listPath = projectPath + @"\Food.json";

        public static void CreateGetFile()
        {

            if (File.Exists(listPath))
            {
                string json = File.ReadAllText(listPath);
                ListManager.Food = JsonConvert.DeserializeObject<List<Food>>(json);
            }

            else
            {
                var newFood = new List<Food>()
            {
                new Food {ProductName = "Banan",ProductMake = "Chiquita",Price = 19 ,ProductionDate = 2016 ,ProductionLand = "Ecuador" },
                new Food {ProductName = "Minced meat",ProductMake = "Ica",Price = 69 ,ProductionDate = 2016 ,ProductionLand = "Danmark" },
                new Food {ProductName = "Spaghetti",ProductMake = "Barilla",Price = 10 ,ProductionDate = 2016 ,ProductionLand = "Italy" },
                new Food {ProductName = "Donuts",ProductMake = "Winchell's",Price = 10 ,ProductionDate = 2016 ,ProductionLand = "USA" },
                new Food {ProductName = "Soda",ProductMake = "Coca-Cola Zero",Price = 19 ,ProductionDate = 2016 ,ProductionLand = "Sweden" },
                new Food {ProductName = "Soda",ProductMake = "Fanta",Price = 19 ,ProductionDate = 2016 ,ProductionLand = "Germany" },
                new Food {ProductName = "Soda",ProductMake = "7-UP",Price = 19 ,ProductionDate = 2016 ,ProductionLand = "Ireland" },

            };
                File.WriteAllText(listPath, JsonConvert.SerializeObject(newFood));
            }


        } //Söker om JSON filen existerar annars skapar den det

        public static List<Food> GetFood()
        {

            string json = File.ReadAllText(listPath);
            List<Food> newFood = new List<Food>();
            newFood = JsonConvert.DeserializeObject<List<Food>>(json);
            return newFood;
        } //Laddar upp filen till listan

        public static void Remove(int index)
        {
            ListManager.Food.RemoveAt(index);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ListManager.Food));
        } //Remove sen sparar den till filen

        public static void AddFood(Food newFood)
        {
            ListManager.Food.Add(newFood);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ListManager.Food));
        } //Laddar upp listan till filen
    }
}
