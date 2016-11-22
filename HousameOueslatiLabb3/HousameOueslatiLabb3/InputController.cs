using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb3
{
    class InputController //Kontrollerar att inputs är som det ska
    {
        public static string NameController()
        {
            do
            {
                Console.Write("Your name: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Please write a name with at least 2 characters!!");
                    Runtime.Timer(1);
                    Runtime.ClearOneLine();
                }
            } while (true);
        }//Ser till att namnet är minst 2 bokstäver långt

        public static int AgeController()
        {
            int input = 0;
            do
            {
                Console.Write("Your Age: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Make sure that you are allowed to participate to this event or put right age in form of numbers");
                    Runtime.Timer(1);

                };

                if (input >= BuyTickets.tempAgeAllowed && input < 100)
                {
                    return input;
                }

                else
                {
                    Runtime.ClearOneLine();
                }
            } while (true);
        }//Ser till att ålder är tillåtet och att input är ett ålder 

        public static string UserIdController()
        {
            do
            {
                Console.Write("Your user id: ");
                string input = Console.ReadLine();
                if (input.Length >= 2)
                {

                    return input;
                }
                else
                {
                    Runtime.ClearOneLine();
                    Console.WriteLine("Please write a right UserId, At least 3 characters!!");
                    Runtime.Timer(1);
                    Runtime.ClearOneLine();
                }
            } while (true);
        }// Ser till att UserId är minst 3 bokstäver, kan tom använda LINQ för att se till om det finns ett befintligt UserId men dock behövs det databas eller fil

    }
}
