using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb10.Books
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>
            {
                new Book {Title = "Lord of The ring", Pages = 352,Price = 199.99,Genre = Book.Genres.Fantasy},
                new Book {Title = "Star Wars", Pages = 180,Price = 99.99,Genre = Book.Genres.Fantasy},
                new Book {Title = "Shorty", Pages = 62,Price = 49.99,Genre = Book.Genres.ShortStory},
                new Book {Title = "The gentleman", Pages = 72,Price = 199.99,Genre = Book.Genres.ShortStory},
                new Book {Title = "Who did it?", Pages = 170,Price = 89.99,Genre = Book.Genres.Mystery},
                new Book {Title = "Who killed Kennedy", Pages = 500,Price = 399.99,Genre = Book.Genres.Mystery},
                new Book {Title = "The miserables", Pages = 620,Price = 499.99,Genre = Book.Genres.Novel},
                new Book {Title = "The bussiness Man", Pages = 351,Price = 99.99,Genre = Book.Genres.Novel},
                new Book {Title = "Romeo & Juliette", Pages = 400,Price = 169.99,Genre = Book.Genres.Romance},
                new Book {Title = "The contesse", Pages = 196,Price = 99.99,Genre = Book.Genres.Romance},

            };
        }

        public void PrintWhere(BookFilter filter)
        {
            foreach (var book in Books)
            {
                if (filter(book))
                    Console.WriteLine(book.Title);
            }
        }

    }
}
