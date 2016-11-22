using HousameOueslatiLabb14.PublicationStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb14.DataStore
{
    class Book : Publication
    {
        public enum GenreType
        {
            Thriller = 1,
            Romance,
            Fantasy,
            Novel,
            Biography
        }
        public GenreType Genre { get; set; }
        public int Pages { get; set; }
    }
}
