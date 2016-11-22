using HousameOueslatiLabb14.PublicationStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb14.DataStore
{
    class Magazine : Publication
    {
        public enum GenreType
        {
            Mode = 1,
            Vehicles,
            Science,
            Technologie,
            Beauty
        }
        public GenreType Genre { get; set; }
        public int Pages { get; set; }
    }
}
