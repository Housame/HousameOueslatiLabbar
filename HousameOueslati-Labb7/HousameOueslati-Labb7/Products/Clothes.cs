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
    class Clothes : Product
    {
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string listPath = projectPath + @"\Clothes.json";

        public static void CreateGetFile()
        {

            if (File.Exists(listPath))
            {
                string json = File.ReadAllText(listPath);
                ListManager.Clothes = JsonConvert.DeserializeObject<List<Clothes>>(json);
            }

            else
            {
                var newClothes = new List<Clothes>()
            {
                new Clothes {ProductName = "T-Shirt",ProductMake = "Lyle Scott",Price = 399 ,ProductionDate = 2016 ,ProductionLand = "England" },
                new Clothes {ProductName = "T-Shirt",ProductMake = "Lacoste",Price = 599 ,ProductionDate = 2016 ,ProductionLand = "France" },
                new Clothes {ProductName = "T-Shirt",ProductMake = "Gant",Price = 599 ,ProductionDate = 2016 ,ProductionLand = "USA" },
                new Clothes {ProductName = "T-Shirt",ProductMake = "Fred Perry",Price = 399 ,ProductionDate = 2014 ,ProductionLand = "Scottland" },
                new Clothes {ProductName = "Long sleeves",ProductMake = "GASP",Price = 799 ,ProductionDate = 2015 ,ProductionLand = "USA" },
                new Clothes {ProductName = "Pants",ProductMake = "Dockers",Price = 699 ,ProductionDate = 2015 ,ProductionLand = "Bangladesh" },
                new Clothes {ProductName = "Jeans",ProductMake = "Levis",Price = 1599 ,ProductionDate = 2016 ,ProductionLand = "Tunisia" }
            };
                File.WriteAllText(listPath, JsonConvert.SerializeObject(newClothes));
            }


        } //Söker om JSON filen existerar annars skapar den det

        public static List<Clothes> GetClothes()
        {

            string json = File.ReadAllText(listPath);
            List<Clothes> newClothes = new List<Clothes>();
            newClothes = JsonConvert.DeserializeObject<List<Clothes>>(json);
            return newClothes;
        } //Laddar upp filen till listan

        public static void Remove(int index)
        {
            ListManager.Clothes.RemoveAt(index);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ListManager.Clothes));
        } //Remove sen sparar den till filen

        public static void AddClothes(Clothes newClothes)
        {
            ListManager.Clothes.Add(newClothes);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ListManager.Clothes));
        } //Laddar upp listan till filen

    }
}
