using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb5
{
    class InputController
    {
        #region Input Controller to list and one for index (Index to remove)
       

        public static int YearController()
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
                    Client.ClearOneLine();
                    Console.WriteLine("Make sure that you put in a year Ex. 2016");
                    Client.Timer(1);

                };

                if (input >= 1 && input < DateTime.Now.Year)
                {
                    return input;
                }

                else
                {
                    Client.ClearOneLine();
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
                    Client.ClearOneLine();
                    Console.WriteLine("Make sure that you put in a number between 1 and {0}!!", listCount);
                    Client.Timer(1);

                };

                if (input >= 1 && input <= listCount)
                {
                    return input-1;
                }

                else
                {
                    Client.ClearOneLine();
                }
            } while (true);
        }

        internal static int GenreChoice()
        {

            int input = 0;
            do
            {
                Console.Write("What is the genre: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Client.ClearOneLine();
                    Console.WriteLine("Make sure that you put in a number between 1-5");
                    Client.Timer(1);

                };

                if (input >= 1 && input <= 5)
                {
                    return input;
                }

                else
                {
                    Client.ClearOneLine();
                }
            } while (true);
        }

        public static string NameController()
        {

            do
            {
                Console.Write("Name: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    Client.ClearOneLine();
                    Console.WriteLine("Please put a right  name, at least 2 characters!");
                    Client.Timer(1);
                    Client.ClearOneLine();
                }
            } while (true);
        }

        public static string WriterController()
        {
            do
            {
                Console.Write("Writer: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    Client.ClearOneLine();
                    Console.WriteLine("Please put a right  name, at least 2 characters!");
                    Client.Timer(1);
                    Client.ClearOneLine();
                }
            } while (true);
        }

        public static string MainArtistController()
        {
            do
            {
                Console.Write("Main artist: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    Client.ClearOneLine();
                    Console.WriteLine("Please put a right  name, at least 2 characters!");
                    Client.Timer(1);
                    Client.ClearOneLine();
                }
            } while (true);
        }

        #endregion

    }
}
