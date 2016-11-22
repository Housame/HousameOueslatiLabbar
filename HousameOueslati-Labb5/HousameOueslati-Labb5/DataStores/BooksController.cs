using HousameOueslati_Labb5.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslati_Labb5.DataStores
{
    class BooksController
    {
        private IRepository repository = new Books();

        public void MainMenu()
        {


            Client client = new Client();
            Menus.PrintMainMenu();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    AddToList();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    RemoveFromList();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    EditList();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    ShowList();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    client.Start();
                    break;

            }
        } // Menyn för att ändra, ta bort, lägga till och visa Book listan

        private void ShowList()
        {
            Console.Clear();

            PrintBookList();
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
        }//// Metoden som anropar PrintBookList som i sin tur Visar listans innehåll

        private void EditList()
        {
            Console.Clear();
            var book = Books.GetBooks();
            PrintBookList();
            int index = InputController.IndexController(book.Count);

            EditBook(book[index]);
            repository.Remove(index);
            Books.AddBook(book[index]);

        }// tar emot valet, skickar den till EditBook för att ändra, tar bort gamla raden och sätter in den nya i listan

        private void EditBook(Books books)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change Year");
            Console.WriteLine("3. Change writer");
            Console.WriteLine("4. Change genre");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Name: {0}, Publishing year: {1}, Writer: {2}, Genre: {3}", books.Name, books.Year, books.Writer, books.Genre);

            switch (choice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Write("New name: ");
                    books.Name = InputController.NameController();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Write("New year: ");
                    books.Year = InputController.YearController();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.Write("New writer: ");
                    books.Writer = InputController.NameController();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.WriteLine("Genre list");
                    PrintBookGenre();
                    Console.Write("New genre: ");
                    int index = InputController.GenreChoice();
                    books.Genre = (Books.GenreType)index;
                    break;
            }
        } //Tar emot raden som ska ändras och visar alternativen som kan ändras

        private void RemoveFromList()
        {
            var newBook = Books.GetBooks();
            Console.Clear();
            PrintBookList();
            int index = InputController.IndexController(newBook.Count);

            repository.Remove(index);
            

        }//Tar bort en rad från listan genom att anropa  remove funktionen från repository

        private void AddToList()
        {
            Console.Clear();
            Console.WriteLine("Add new book:");
            var newBook = CreateBook();
            Books.AddBook(newBook);

        }// Lägger till en rad i listan genom CreateBook metoden

        Books CreateBook()
        {
            Books newBook = new Books();
            newBook.Name = InputController.NameController();
            newBook.Writer = InputController.WriterController();
            newBook.Year = InputController.YearController();
            PrintBookGenre();
            int choice = InputController.GenreChoice();
            newBook.Genre = (Books.GenreType)choice;
            return newBook;
        } // metod för att ta emot inputs för list raden och returnera det

        private void PrintBookGenre()
        {

            foreach (var genre in Enum.GetValues(typeof(Books.GenreType)))
            {
                Console.WriteLine("{0}, {1}", (int)genre, genre);
            }
        } //Visar ut Genres

        void PrintBookList()
        {
            int index=0;
            var newBook = Books.GetBooks();
            foreach (var book in newBook)
            {
                index++;
                Console.WriteLine("{4}- Name: {0}, Publishing year: {1}, Writer: {2}, Genre: {3}", book.Name, book.Year, book.Writer, book.Genre,index);
            }
        } //Visar listans innehåll
    }
}
