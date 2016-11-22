using HousameOueslati_Labb7.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Food.CreateGetFile();
            Electronics.CreateGetFile();
            Clothes.CreateGetFile();

            client.Start();
        }
    }
}
