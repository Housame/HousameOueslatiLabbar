using HousameOueslati_Labb5.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb5
{
    class Client
    {
        public void Start()
        {
            
            Menus.MainMenu();
            
        }
        public static void ClearOneLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        } // en metod som ska användas för att kunna ta bort ett antal Line "för grafisk förbättring"

        public static void Timer(double seconds)
        {
            {
                double sec = seconds;
                var t = Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromSeconds(sec));
                    return;
                });
                t.Wait();

            }
        } // en timer för att användaren sk kunna se felmeddelande innan ClearLines tar bort den "för grafisk förbättring"
    }
}
