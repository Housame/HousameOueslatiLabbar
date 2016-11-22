using HousameOueslatiLabb14.DataStore;
using HousameOueslatiLabb14.GUI;
using HousameOueslatiLabb14.PublicationStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb14
{
    class Runtime
    {
        Menus menus = new Menus();
        public void Start()
        {
            do
            {
                menus.MainMenu();
            } while (true);
        }
    }
}
