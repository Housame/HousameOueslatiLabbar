using Labb8VG.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8VG
{
    class Runtime
    {
        public delegate void StringConcatinator(string productNames);
        public delegate void NumberOperator(float productPrices);
        ProductManager myManager = new ProductManager();

        public void Start()
        {
            bool loop = true;
            while (loop)
            {
                GUI.MainMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        FormatNames();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        AllPricesAddedTwenty();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        PricesOverThousand();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        ShowListTotalPrice();
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        loop = false;
                        break;
                }
            }
        }

        private void ShowListTotalPrice()
        {
            Console.Clear();
            GUI.ShowListTotalPrice();
            Func<float, float, float> pPriceAdd = (n1, n2) =>
            {

                return n1 + n2;
            };
            Console.WriteLine("******* All products price********");
            myManager.PriceCalculation(pPriceAdd);
            foreach (var product in myManager.ProductList)
            {
                Console.Write("\n Name: {0},  Price: {1} SEK,  ID: {2}", product.Name, product.Price, product.Id);
            }
            Console.ReadKey();
        }

        private void PricesOverThousand()
        {
            Console.Clear();
            GUI.PricesOverThousand();
            Func<float, float, float> overPriceAdd = (n1, n2) =>
            {
                float tot = 0;
                if (n2 >= 1000)
                {
                    tot = n1 + n2 * 0.9f;
                    return tot;
                }

                else return n1;
            };
            myManager.PriceCalculation(overPriceAdd);
            Console.ReadKey();
        }

        private void AllPricesAddedTwenty()
        {
            Console.Clear();
            GUI.AllPricesAddedTwenty();
            Func<float, float, float> allPriceAdd = (n1, n2) =>
            {
                float tot = 0;
                tot = n1 + n2 * 1.2f;
                return tot;
            };
            myManager.PriceCalculation(allPriceAdd);
            Console.ReadKey();
        }

        void FormatNames()
        {
            Console.Clear();
            GUI.FormatNames();
            StringConcatinator sConca = (productNames) =>
            {
                Console.WriteLine(productNames);
            };

            myManager.FormatProductNames(sConca);
            Console.ReadKey();
        }

    }
}
