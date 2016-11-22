using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb3
{
    class Tickets : User
    {
        
        public string Info { get; set; } // info på evenemanget som visas när man har matat in befintlig användarnamn



        public static void ShowMyTickets()
        {
            Console.Clear();
            List<Tickets> idFound = new List<Tickets>();


            
            bool loop = true;
            string input;
            Console.WriteLine("           Write your UserId");
            while (loop)
            {
                Console.Write("           UserId: ");
                input = Console.ReadLine();
                idFound = BuyTickets.AllTicket.FindAll(tickets => string.Equals(tickets.UserId, input));
                if (idFound != null)
                {

                    loop = false;
                }

            }
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("*                                 *");
            Console.WriteLine("*                                 *");
            Console.WriteLine("*          Show My Tickets        *");
            Console.WriteLine("*---------------------------------*");

            foreach (var ticket in idFound)
            {
                Console.WriteLine(ticket.Info);
            }

            Console.WriteLine("*                                 *");
            Console.WriteLine("*                                 *");
            Console.WriteLine("*---------------------------------*");
            Console.WriteLine("*          Show My Tickets        *");
            Console.WriteLine("***********************************\n");
            Console.WriteLine("Done? Press 1!");
            var tempInput = Console.ReadKey(true).Key;
            switch (tempInput)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Menus.MainMenu();
                    break;
            }


        }//En metod som söker UserId och hämtar biljetterna som den användare har bokat samt information
    }
}
