using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb7.DataStore
{
    interface ISellable
    {
        string ProductName { get; set; }
        string ProductMake { get; set; }
        int Price { get; set; }
        string ProductionLand { get; set; }
        int ProductionDate { get; set; }
        string GetInformation();
    }
}
