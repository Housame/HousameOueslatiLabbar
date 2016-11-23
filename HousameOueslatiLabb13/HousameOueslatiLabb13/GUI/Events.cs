using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb13.GUI
{
    

    class Events
    {
        public void MakeErrorMsg()
        {
            Runtime.ClearOneLine();
            Console.WriteLine("Please put a right Make name, at least 2 characters!");
            Runtime.Timer(1);
            Runtime.ClearOneLine();
        }

        public void VariantErrorMsg()
        {
            Runtime.ClearOneLine();
            Console.WriteLine("Please put a right variant name, at least 2 characters!");
            Runtime.Timer(1);
            Runtime.ClearOneLine();   
        }

        public void PowerErrorMsg()
        {
            Runtime.ClearOneLine();
            Console.WriteLine("Make sure that you put in a resonable power!!");
            Runtime.Timer(1);

        }

        public void YearErrorMsg()
        {
            
            Runtime.ClearOneLine();
            Console.WriteLine("Make sure that you put in a year Ex. 2016");
            Runtime.Timer(1);
            
        }

        public void PriceErrorMsg()
        {
            Runtime.ClearOneLine();
            Console.WriteLine("Make sure that the price is reasonable");
            Runtime.Timer(1);
            Runtime.ClearOneLine();
        }

    }
}
