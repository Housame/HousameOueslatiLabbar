using HousameOueslatiLabb14.PublicationStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb14.DataStore
{
    class Paper : Publication
    {
        public enum GenreType
        {
            Politic = 1,
            Sport,
            Celebrities,
            News,
            Health
        }
        public GenreType Genre { get; set; }
        public int Pages { get; set; }
    }
}
