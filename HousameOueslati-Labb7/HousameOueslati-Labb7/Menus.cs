using HousameOueslati_Labb7.DataStore;
using HousameOueslati_Labb7.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7
{
    class Menus
    {
        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Start Menu            *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Food                 *");
            Console.WriteLine("*      2. Electronics          *");
            Console.WriteLine("*      3. Clothes              *");
            Console.WriteLine("*      4. Back to start menu   *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }

        public void PrntShoppingStart()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Shoppin Menu          *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Food                 *");
            Console.WriteLine("*      2. Electronics          *");
            Console.WriteLine("*      3. Clothes              *");
            Console.WriteLine("*      4. Shopping cart        *");
            Console.WriteLine("*      5. Back to start menu   *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }

        internal void PrintOptionMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Option Menu           *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Add                  *");
            Console.WriteLine("*      2. Remove               *");
            Console.WriteLine("*      3. Show                 *");
            Console.WriteLine("*      4. Back to start menu   *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }

        public void PrintStartMenu()
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*        Start Menu            *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*      1. Show/Add/Remove      *");
            Console.WriteLine("*      2. Shop                 *");
            Console.WriteLine("*      3. Exit                 *");
            Console.WriteLine("*                              *");
            Console.WriteLine("* ---------------------------- *");
            Console.WriteLine("********************************");
        }
    }
}
