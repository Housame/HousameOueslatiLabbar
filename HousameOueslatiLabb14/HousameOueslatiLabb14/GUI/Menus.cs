using HousameOueslatiLabb14.DataStore;
using HousameOueslatiLabb14.PublicationStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb14.GUI
{
    class Menus
    {
        public void MainMenu()
        {
            PrintManiMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowMagazines();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    ShowBooks();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    ShowPapers();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    SearchByAuthor();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    Environment.Exit(0);
                    break;
            }
        }

        private void SearchByAuthor()
        {
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("**** Search by author ****");
            Console.WriteLine("**************************");
            Console.WriteLine("\n");
            string seekedAuthor = AuthorInput();

            #region Books with seekedAuthor
            var newBook = ListManager.MyBooks.FindAll(b => b.Author.Name.Contains(seekedAuthor));
            foreach (var book in newBook)
                {
                Console.WriteLine("Book# Title: {0}, Genre: {1}, Release date: {2}, Pages: {3}, Author: {4}", book.Title, book.Genre, book.ReleaseDate, book.Pages, book.Author.Name);
            }
            #endregion
            #region Papers with seekedAuthor
            var newPaper = ListManager.MyPapers.FindAll(p => p.Author.Name.Contains(seekedAuthor));
            foreach (var paper in newPaper)
            {
                Console.WriteLine("Paper# Title: {0}, Genre: {1}, Release date: {2}, Pages: {3}, Author: {4}", paper.Title, paper.Genre, paper.ReleaseDate, paper.Pages, paper.Author.Name);
            }
            #endregion
            #region Magazines with seekedAuthor
            var newMagazine = ListManager.MyMagazines.FindAll(m => m.Author.Name.Contains(seekedAuthor));
            foreach (var magazine in newMagazine)
            {
                Console.WriteLine("Magazine# Title: {0}, Genre: {1}, Release date: {2}, Pages: {3}, Author: {4}", magazine.Title, magazine.Genre, magazine.ReleaseDate, magazine.Pages, magazine.Author.Name);
            }
            #endregion

            Console.ReadKey();
        }

        private string AuthorInput()
        {
            
            do
            {
                Console.Write("The author: ");
                var input = Console.ReadLine();
                if (input.Length >= 1)
                    return input;
                else
                Console.WriteLine("The name must have at least one letter");
            } while (true);
           
        }

        private void ShowPapers()
        {
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("****    Papers    ****");
            Console.WriteLine("**********************");
            foreach (var paper in ListManager.MyPapers)
            {
                Console.WriteLine("Title: {0}, Genre: {1}, Release date: {2}, Pages: {3}, Author: {4}", paper.Title, paper.Genre, paper.ReleaseDate, paper.Pages, paper.Author.Name);
            }
            Console.ReadKey();
        }

        private void ShowBooks()
        {
            Console.Clear();
            Console.WriteLine("*********************");
            Console.WriteLine("****    Books    ****");
            Console.WriteLine("*********************");
            foreach (var book in ListManager.MyBooks)
            {
                Console.WriteLine("Title: {0}, Genre: {1}, Release date: {2}, Pages: {3}, Author: {4}", book.Title, book.Genre, book.ReleaseDate, book.Pages, book.Author.Name);
            }
            Console.ReadKey();
        }

        private void ShowMagazines()
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("****   Magazines   ****");
            Console.WriteLine("***********************");
            foreach (var magazine in ListManager.MyMagazines)
            {
                Console.WriteLine("Title: {0}, Genre: {1}, Release date: {2}, Pages: {3}, Author: {4}", magazine.Title, magazine.Genre, magazine.ReleaseDate, magazine.Pages, magazine.Author.Name);
            }
            Console.ReadKey();
        }

        public void PrintManiMenu()
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("*-----------------------*");
            Console.WriteLine("    1.Show Magazines    *");
            Console.WriteLine("    2.Show Books        *");
            Console.WriteLine("    3.Show Papers       *");
            Console.WriteLine("    4.Search by author  *");
            Console.WriteLine("    5.Exit              *");
            Console.WriteLine("*-----------------------*");
            Console.WriteLine("*************************");
        }
    }
}
