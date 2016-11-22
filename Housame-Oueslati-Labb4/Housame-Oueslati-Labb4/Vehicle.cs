using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Housame_Oueslati_Labb4
{
    public class Vehicle
    {
        public int ModelYear { get; set; }
        public string Make { get; set; }
        public string Variant { get; set; }
        public int Power { get; set; }
        public int MileAge { get; set; }
        public string Fuel { get; set; }
        public int Price { get; set; }
        public bool Used { get; set; }
        public int Quantity { get; set; }

        
        public override string ToString()
        {
            string condition;
            if (Used == false)
                condition = "The car is brand new";
            else condition = "The car is used";
            return string.Format("*************************\n Make: {0}\n Variant: {1}\n Quantity: {2}\nModelYear: {3}\n Power: {4}\n MileAge: {5}\n Fuel: {6}\n Price: {7} SEK\n", Make, Variant,Quantity, ModelYear, Power, MileAge, Fuel, Price, condition);
        }
    }
}