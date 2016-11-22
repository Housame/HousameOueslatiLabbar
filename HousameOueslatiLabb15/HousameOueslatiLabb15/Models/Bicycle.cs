using HousameOueslatiLabb15.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb15.Models
{
    class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bicycle starting");
        }
        public void Stop()
        {
            Console.WriteLine("Bicycle stopping");
        }
        public void Lock()
        {
            Console.WriteLine("Bicycle is locked");
        }
        public void Unlock()
        {
            Console.WriteLine("Bicycle is unlocked");
        }
    }
}
