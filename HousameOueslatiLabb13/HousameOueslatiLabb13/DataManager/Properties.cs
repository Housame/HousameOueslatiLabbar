using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb13.DataManager
{
    class Properties
    {
        public enum GenreType
        {
            Diesel = 1,
            Bensin,
            Electric,
            Hybrid,
            Etanol

        }
        public int ModelYear { get; set; }
        public string Make { get; set; }
        public string Variant { get; set; }
        public int Power { get; set; }
        public GenreType Fuel { get; set; }
        public int Price { get; set; }
    }
}
