using HousameOueslatiLabb10.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb10.Filters
{
    class BookFilters
    {
        public static bool IsNovel(Book book)
        {
            return book.Genre == Book.Genres.Novel;
        }

        public static bool IsShortStory(Book book)
        {
            return book.Genre == Book.Genres.ShortStory;
        }

        public static bool IsMystery(Book book)
        {
            return book.Genre == Book.Genres.Mystery;
        }

        public static bool IsFantasy(Book book)
        {
            return book.Genre == Book.Genres.Fantasy;
        }

        public static bool IsRomance(Book book)
        {
            return book.Genre == Book.Genres.Romance;
        }

        public static bool IsCheap(Book book)
        {
            return book.Price < 100;
        }

        public static bool IsExpensive(Book book)
        {
            return book.Price >= 100;
        }
    }
}
