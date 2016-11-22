using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLabb2
{
    abstract class Animal
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Age { get; set; }

        public string FurOrNot { get; set; }

        public string FoodType { get; set; }

        public string Genre { get; set; }

        public string Colour { get; set; }

        public virtual string Move()
        {

            return string.Format("{0} have a weight {1}, {0} are {2} years old, have {3} , eats {4} , are {5} ,  are{6}", Name, Weight, Age, FurOrNot, FoodType, Genre, Colour);

        }
    }
}
