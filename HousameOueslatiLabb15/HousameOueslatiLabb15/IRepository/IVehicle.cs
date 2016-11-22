using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb15.IRepository
{
    interface IVehicle
    {
        void Start();
        void Stop();
        void Lock();
        void Unlock();
    }
}
