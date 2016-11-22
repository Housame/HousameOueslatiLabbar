using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8VG
{
    class GUI
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine("*        Start Menu             *");
            Console.WriteLine("* ----------------------------  *");
            Console.WriteLine("*                               *");
            Console.WriteLine("*                               *");
            Console.WriteLine("*    1. Format P. Names         *");
            Console.WriteLine("*    2. 20% all prices          *");
            Console.WriteLine("*    3. -10% prices> 1000       *");
            Console.WriteLine("*    4. Show list + all prices  *");
            Console.WriteLine("*    5. Exit                    *");
            Console.WriteLine("*                               *");
            Console.WriteLine("* ----------------------------  *");
            Console.WriteLine("*********************************");
        }

        internal static void ShowListTotalPrice()
        {
            Console.WriteLine("***************************");
            Console.WriteLine(" Showing Price of all products together");
            Console.WriteLine(" Then showing a list of all products");
            Console.WriteLine("***************************");
        }

        internal static void PricesOverThousand()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Adding all prices over 1000 SEK and removing 10%");
            Console.WriteLine("***************************");
        }

        internal static void AllPricesAddedTwenty()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Adding all products prices and adding 20% to the total");
            Console.WriteLine("***************************");
        }

        internal static void FormatNames()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Making one string that contains all products names");
            Console.WriteLine("***************************");
        }
    }
}
