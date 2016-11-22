using HousameOueslati_Labb5.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb5.Repositories
{
    interface IRepository
    {
        
        void CreateGetFile();
        
        void Remove(int index);
    }
}
