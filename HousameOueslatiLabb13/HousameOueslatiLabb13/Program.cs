using HousameOueslatiLabb13.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb13
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Cars car = new Cars();
            car.CreateGetFile();
            var runtime = new Runtime();
            runtime.Start();
        }
    }
}
