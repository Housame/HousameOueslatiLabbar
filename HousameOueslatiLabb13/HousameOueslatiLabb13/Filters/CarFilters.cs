using HousameOueslatiLabb13.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb13.Filters
{
    class CarFilters
    {
         public static bool IsPowerful(Cars car)
        {
            return car.Power > 250;
        }

        public static bool IsExpensive(Cars car)
        {
            return car.Price > 500000;
        }

        public static bool IsNew(Cars car)
        {
            return car.ModelYear == DateTime.Now.Year ;
        }

        public static bool IsElectric(Cars car)
        {
            return car.Fuel == Properties.GenreType.Electric;
        }
    }
}
