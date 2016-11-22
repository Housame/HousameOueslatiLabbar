using HousameOueslatiLabb10.Books;
using HousameOueslatiLabb10.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb10
{
    class Runtime
    {
        public void Start()
        {
            BookManager manager = new BookManager();

            BookFilter isNovel = BookFilters.IsNovel;
            BookFilter isRomance = BookFilters.IsRomance;
            BookFilter isShortStory = BookFilters.IsShortStory;
            BookFilter isFantasy = BookFilters.IsFantasy;
            BookFilter isMyster = BookFilters.IsMystery;
            BookFilter isCheap = BookFilters.IsCheap;
            BookFilter isExpensive = BookFilters.IsExpensive;

            Console.WriteLine("Novels: ");
            manager.PrintWhere(isNovel);

            Console.WriteLine("\nRomance: ");
            manager.PrintWhere(isRomance);

            Console.WriteLine("\nShorty Story: ");
            manager.PrintWhere(isShortStory);

            Console.WriteLine("\nFantasy: ");
            manager.PrintWhere(isFantasy);

            Console.WriteLine("\nMystery: ");
            manager.PrintWhere(isMyster);

            Console.WriteLine("\nCheap books that costs less than 100 SEK: ");
            manager.PrintWhere(isCheap);

            Console.WriteLine("\nExpensive books that costs more than 100 SEK: ");
            manager.PrintWhere(isExpensive);
        }
    }
}
