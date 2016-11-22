using HousameOueslatiLabb15.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb15.Models
{
    class SpaceShip : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("SpaceShip starting");
        }
        public void Stop()
        {
            Console.WriteLine("SpaceShip stopping");
        }
        public void Lock()
        {
            Console.WriteLine("SpaceShip is locked");
        }
        public void Unlock()
        {
            Console.WriteLine("SpaceShip is unlocked");
        }
    }
}
