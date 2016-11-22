using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.DataStore
{
    class Product : ISellable
    {
        public int Price { get; set; }

        public  string ProductionLand { get; set; }

        public int ProductionDate { get; set; }

        public string ProductName { get; set; }

        public string ProductMake { get; set; }

        public string GetInformation()
        {
            return string.Format("Product: {0} ,Make: {4} ,Price: {1} SEK,Production date: {2} ,Land: {3} .",ProductName, Price, ProductionDate, ProductionLand, ProductMake);
        }
    }
}
