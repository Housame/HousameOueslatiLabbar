using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb13.DataManager
{
    class Cars : Properties
    {
        #region Class Variables
        private static List<Cars> carList;
        public static List<Cars> CarList
        {
            get { return carList; }
            set { carList = value; }
        }
        string listPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Cars.json";
        #endregion


        public void CreateGetFile()
        {

            if (File.Exists(listPath))
            {
                string json = File.ReadAllText(listPath);
                CarList = JsonConvert.DeserializeObject<List<Cars>>(json);
            }

            else
            {
                var newCars = new List<Cars>()
            {
                new Cars { Make = "BMW", Variant = "320", ModelYear = 2016, Power = 185, Fuel = GenreType.Diesel, Price = 380000 },
                new Cars { Make = "Mercedes", Variant = "C180", ModelYear = 2016, Power = 173, Fuel = GenreType.Bensin, Price = 375000 },
                new Cars { Make = "Wolkswagen", Variant = "Golf 7", ModelYear = 2013, Power = 164, Fuel = GenreType.Diesel, Price = 150000 },
                new Cars { Make = "Skoda", Variant = "Octavia", ModelYear = 2012, Power = 146, Fuel = GenreType.Bensin, Price = 80000 },
                new Cars { Make = "Citroën", Variant = "Cactus", ModelYear = 2016, Power = 82, Fuel = GenreType.Bensin, Price = 171000 },
                new Cars { Make = "BMW", Variant = "M2", ModelYear = 2013, Power = 340, Fuel = GenreType.Bensin, Price = 420000 },
                new Cars { Make = "Bugatti", Variant = "Chiron", ModelYear = 2015, Power = 680, Fuel = GenreType.Bensin, Price = 1500000 },
                new Cars { Make = "BMW", Variant = "i8", ModelYear = 2015, Power = 362, Fuel = GenreType.Hybrid, Price = 1700000 },
                new Cars { Make = "Tesla", Variant = "Model X", ModelYear = 2016, Power = 185, Fuel = GenreType.Electric, Price = 949000 },
                new Cars { Make = "Audi", Variant = "A8", ModelYear = 2016, Power = 374, Fuel = GenreType.Diesel, Price = 1200000 },
                new Cars { Make = "Mercedes", Variant = "S65 AMG", ModelYear = 2016, Power = 590, Fuel = GenreType.Bensin, Price = 1800000 },
                new Cars { Make = "Audi", Variant = "RS7", ModelYear = 2015, Power = 560, Fuel = GenreType.Bensin, Price = 1172600 },
                new Cars { Make = "BMW", Variant = "i3", ModelYear = 2016, Power = 560, Fuel = GenreType.Electric, Price = 430600 }

            };
                File.WriteAllText(listPath, JsonConvert.SerializeObject(newCars));
            }


        } //Söker om JSON filen existerar annars skapar den det

        public List<Cars> GetCar()
        {

            string json = File.ReadAllText(listPath);
            List<Cars> newCars = new List<Cars>();
            newCars = JsonConvert.DeserializeObject<List<Cars>>(json);
            return newCars;
        } //Laddar upp filen till listan

        public void AddCars(Cars newCars)
        {
            CarList.Add(newCars);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(CarList));
        } //Laddar upp listan till filen
    }
}
