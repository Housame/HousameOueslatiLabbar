using HousameOueslatiLabb15.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb15.Models
{
    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car starting");
        }
        public void Stop()
        {
            Console.WriteLine("Car stopping");
        }
        public void Lock()
        {
            Console.WriteLine("Car is locked");
        }
        public void Unlock()
        {
            Console.WriteLine("Car is unlocked");
        }
    }
}
