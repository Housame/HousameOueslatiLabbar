using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb5.DataStores
{
    class ListManager
    {
        static List<Books> book;
        public static List<Books> Book
        {        
                get {
                if (book == null)
                    book = new List<Books>();
                return book ; }
                set { book = value; }
        }

        static List<Movies> movie;
        public static List<Movies> Movie
        {
            get
            {
                if (movie == null)
                    movie = new List<Movies>();
                return movie;
            }
            set { movie = value; }
        }

    }
}
