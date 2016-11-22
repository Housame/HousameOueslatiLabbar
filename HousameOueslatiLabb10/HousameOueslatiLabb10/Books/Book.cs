using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb10.Books
{
    public class Book
    {
        public enum Genres
        {
            Novel = 1,
            ShortStory,
            Mystery,
            Fantasy,
            Romance
        }

        public string Title { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public Genres Genre { get; set; }
    }
}
