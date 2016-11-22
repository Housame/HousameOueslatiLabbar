using HousameOueslati_Labb7.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.Shopping
{
    class ShoppingCart : IBuyable
    {

        public int Price { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string GetInformation()
        {
            return string.Format(". Quantity: {0} pieces, of {1} with a total price: {2}",Quantity, Name, Price);
        }

        public int TotalPrice()
        {
            int totalPrice = 0;
            foreach (var item in ListManager.ShoppingCart)
            {
                totalPrice = totalPrice + item.Price;
            }
            return totalPrice;
        }

        public int TotalQuantity()
        {
            int totalQuantity = 0;
            foreach (var item in ListManager.ShoppingCart)
            {
                totalQuantity = totalQuantity + item.Quantity;
            }
            return totalQuantity;
        }

        public static List<ShoppingCart> GetShoppingCart()
        {
            return ListManager.ShoppingCart;
        }

        public void AddToCart (ShoppingCart newCart)
        {
            ListManager.ShoppingCart.Add(newCart);
        }

    }
}
