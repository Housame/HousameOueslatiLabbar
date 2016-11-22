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
    class Electronics : Product
    {
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string listPath = projectPath + @"\Electronics.json";

        public static void CreateGetFile()
        {

            if (File.Exists(listPath))
            {
                string json = File.ReadAllText(listPath);
                ListManager.Electronics = JsonConvert.DeserializeObject<List<Electronics>>(json);
            }

            else
            {
                var newElectronics = new List<Electronics>()
            {
                new Electronics {ProductName = "TV",ProductMake = "Samsung",Price = 7499 ,ProductionDate = 2016 ,ProductionLand = "South Korea" },
                new Electronics {ProductName = "IPad",ProductMake = "Apple",Price = 4599 ,ProductionDate = 2016 ,ProductionLand = "USA" },
                new Electronics {ProductName = "Mobile",ProductMake = "HTC M9",Price = 3599 ,ProductionDate = 2015 ,ProductionLand = "Vietnam" },
                new Electronics {ProductName = "Mobile",ProductMake = "ZTE",Price = 1399 ,ProductionDate = 2016 ,ProductionLand = "Czech" },
                new Electronics {ProductName = "Ipod",ProductMake = "Apple",Price = 1799 ,ProductionDate = 2015 ,ProductionLand = "USA" },
                new Electronics {ProductName = "Media Player",ProductMake = "Marshall",Price = 2699 ,ProductionDate = 2015 ,ProductionLand = "China" },
                new Electronics {ProductName = "Hair dryer",ProductMake = "Philips",Price = 1599 ,ProductionDate = 2016 ,ProductionLand = "USA" }
            };
                File.WriteAllText(listPath, JsonConvert.SerializeObject(newElectronics));
            }


        } //Söker om JSON filen existerar annars skapar den det


        public static void Remove(int index)
        {
            ListManager.Electronics.RemoveAt(index);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ListManager.Electronics));
        } //Remove sen sparar den till filen

        public static void AddElectronic(Electronics newElectronic)
        {
            ListManager.Electronics.Add(newElectronic);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ListManager.Electronics));
        } //Laddar upp listan till filen

        public static List<Electronics> GetElectronic()
        {

            string json = File.ReadAllText(listPath);
            List<Electronics> newElect = new List<Electronics>();
            newElect = JsonConvert.DeserializeObject<List<Electronics>>(json);
            return newElect;
        } //Laddar upp filen till listan

        

    }
}
