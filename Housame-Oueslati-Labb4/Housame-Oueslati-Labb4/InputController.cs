using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_Labb4
{
    class InputController
    {
        #region Input Controller to list and one for index (Index to remove)
        public static int QuantityToSellBuy()
        {
            int input = 0;
            do
            {
                Console.Write("How many do you want to sell: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that you put in a resonable quantity!!");
                    Runtime.Timer(1);

                };

                if (input >= 1 && input < 1000)
                {
                    return input;
                }

                else
                {
                    Console.WriteLine("Make sure that you put in a resonable quantity!!");
                    Runtime.ClearOneLine();
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        
        public static string MakeController()
        {
            do
            {
                Console.Write("Make: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Please put a right Make name, at least 2 characters!");
                    Runtime.Timer(1);
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        
        public static int PriceController()
        {
            int input = 0;
            do
            {
                Console.Write("Price(SEK): ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that the price is reasonable");
                    Runtime.Timer(1);

                };

                if (input >= 10 && input < 10000000)
                {
                    return input;
                }

                else
                {
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        
        public static int QuantityController()
        {
            int input = 0;
            do
            {
                Console.Write("Quantity: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that the quantity is a reasonable number");
                    Runtime.Timer(1);

                };

                if (input >= 0 && input < 10000000)
                {
                    return input;
                }

                else
                {
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        
        public static bool UsedController()
        {
            bool result=true;
            Console.Write("Is the car used(Y/N): ");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    Console.WriteLine("Used");
                    result = true;
                    break;
                case ConsoleKey.N:
                    Console.WriteLine("New");
                    result = false;
                    break;
            }
            return result;
        }
        
        public static int ModelYearController()
        {

            int input = 0;
            do
            {
                Console.Write("Model year(yyyy): ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that you put in a year Ex. 2016");
                    Runtime.Timer(1);

                };

                if (input >= 1885 && input < DateTime.Now.Year)
                {
                    return input;
                }

                else
                {
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        
        public static int PowerController()
        {
            int input = 0;
            do
            {
                Console.Write("Power(hp): ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that you put in a resonable power!!");
                    Runtime.Timer(1);

                };

                if (input >= 10 && input < 1500)
                {
                    return input;
                }

                else
                {
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        
        public static int IndexController(int listCount)
        {
            int input = 0;
            do
            {
                Console.Write("Choose which one: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that you put in a number between 0 and {0}!!",listCount);
                    Runtime.Timer(1);

                };

                if (input >= 1 && input <= listCount)
                {
                    return input;
                }

                else
                {
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        
        public static int MileAgeController()
        {
            int input = 0;
            do
            {
                Console.Write("Mile age(km): ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that the Mile age is a number");
                    Runtime.Timer(1);

                };

                if (input >= 10 && input < 1000000)
                {
                    return input;
                }

                else
                {
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        
        public static string FuelController()
        {
            string returnedFuel = "";
            Console.Write("Fuel(D-Diesel/P-Petrol/E-Electric/H-Hybrid): ");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {

                case ConsoleKey.D:
                    Console.WriteLine("Diesel");
                    returnedFuel = "Diesel";
                    break;
                case ConsoleKey.P:
                    Console.WriteLine("Petrol");
                    returnedFuel = "Petrol";
                    break;
                case ConsoleKey.E:
                    Console.WriteLine("Electric");
                    returnedFuel = "Electric";
                    break;
                case ConsoleKey.H:
                    Console.WriteLine("Hybrid");
                    returnedFuel = "Hybrid";
                    break;
            }
            return returnedFuel;
        }
        
        public static string VariantController()
        {

            do
            {
                Console.Write("Varaint: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Please put a right Variant name, at least 2 characters!");
                    Runtime.Timer(1);
                    Runtime.ClearOneLine();
                }
            } while (true);
        }
        #endregion
    }
}
