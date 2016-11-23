using HousameOueslatiLabb13.DataManager;
using System;

namespace HousameOueslatiLabb13.GUI
{
    public delegate void PrintErrorMsg();
    internal class InputControllers
    {
        Events myEvent = new Events();
        private event PrintErrorMsg ErrorMsg;

        internal string MakeController()
        {
            ErrorMsg += new PrintErrorMsg(myEvent.MakeErrorMsg);
            do
            {
                Console.Write("Make: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {
                    ErrorMsg -= new PrintErrorMsg(myEvent.MakeErrorMsg);
                    return input;
                }
                else
                {
                    OnError();
                }
            } while (true);

        }

        internal string VariantController()
        {
            ErrorMsg += new PrintErrorMsg(myEvent.VariantErrorMsg);
            do
            {
                Console.Write("Variant: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {
                    ErrorMsg -= new PrintErrorMsg(myEvent.VariantErrorMsg);
                    return input;
                }
                else
                {
                    OnError();
                }
            } while (true);
            
        }

        internal int ModelYearController()
        {
            ErrorMsg += new PrintErrorMsg(myEvent.YearErrorMsg);
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
                    OnError();     
                };

                if (input >= 1885 && input < DateTime.Now.Year+1)
                {
                    ErrorMsg -= new PrintErrorMsg(myEvent.YearErrorMsg);
                    return input;                    
                }

                else
                {
                    OnError();
                }
            } while (true);
            

        }

        internal int PowerController()
        {
            ErrorMsg += new PrintErrorMsg(myEvent.PowerErrorMsg);
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
                    OnError();
                };

                if (input >= 50 && input < 1500)
                {
                    ErrorMsg -= new PrintErrorMsg(myEvent.PowerErrorMsg);
                    return input;
                }

                else
                {
                    OnError();
                }
            } while (true);
        }

        internal Properties.GenreType FuelController()
        {
            int gnr = 0;
            foreach (var genre in Enum.GetValues(typeof(Properties.GenreType)))
            {
                Console.WriteLine("{0}. {1}",(int)genre,genre);
            }
            
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    gnr = 1;
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    gnr = 2;
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    gnr = 3;
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    gnr = 4;
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    gnr = 5;
                    break;

            }
            return (Properties.GenreType)gnr;

        }

        internal int PriceController()
        {
            int input = 0;
            ErrorMsg += new PrintErrorMsg(myEvent.PriceErrorMsg);
            do
            {
                Console.Write("Price(SEK): ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    OnError();
                };

                if (input >= 10 && input < 10000000)
                {
                    ErrorMsg -= new PrintErrorMsg(myEvent.PriceErrorMsg);
                    return input;
                }

                else
                {
                    OnError();
                }
            } while (true);
        }

        public void OnError()
        {
            ErrorMsg?.Invoke();
        }

    }
}