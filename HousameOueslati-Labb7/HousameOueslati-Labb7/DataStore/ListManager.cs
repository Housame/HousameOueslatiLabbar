using HousameOueslati_Labb7.Products;
using HousameOueslati_Labb7.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.DataStore
{
    class ListManager
    {
        static List<ShoppingCart> shoppingCart;
        public static List<ShoppingCart> ShoppingCart
        {
            get
            {
                if (shoppingCart == null)
                    shoppingCart = new List<ShoppingCart>();
                return shoppingCart;
            }
            set { shoppingCart = value; }
        }

        static List<Food> food;
        public static List<Food> Food
        {
            get { return food; }
            set { food = value; }
        }

        static List<Electronics> electronic;
        public static List<Electronics> Electronics
        {
            get { return electronic; }
            set { electronic = value; }
           
        }

        static List<Clothes> clothes;
        public static List<Clothes> Clothes
        {
            get { return clothes; }
            set { clothes = value; }
        }
    }
}
