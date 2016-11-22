using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.Shopping
{
    interface IBuyable
    {
        int Price { get; set; }
        int Quantity { get; set; }
        string Name { get; set; }
        int TotalPrice();
        int TotalQuantity();
        string GetInformation();
        void AddToCart(ShoppingCart newCart);
    }
}
