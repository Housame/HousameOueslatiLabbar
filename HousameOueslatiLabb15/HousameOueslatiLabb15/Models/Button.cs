using HousameOueslatiLabb15.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb15.Models
{
    class Button : IPushable
    {
        public void Push()
        {
            Console.WriteLine("Button is pushed");
        }
    }
}
