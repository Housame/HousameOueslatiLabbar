using HousameOueslatiLabb14.PublicationStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb14.DataStore
{
    class ListManager
    {
        private static List<Book> myBooks;
        public static List<Book> MyBooks
        {
            get
            {
                myBooks = new List<Book>()
                {
                    new Book { Title = "The Dark Tower: The Gunslinger", Genre = Book.GenreType.Thriller, Pages = 224, ReleaseDate =19820610, Author = MyAuthors[0]},
                    new Book { Title = "The lord of the ring: The Return of the King", Genre = Book.GenreType.Fantasy, Pages = 490 , ReleaseDate =19551020, Author = MyAuthors[1]},
                    new Book { Title = "Great Expectations", Genre = Book.GenreType.Novel, Pages = 544, ReleaseDate =18610101, Author = MyAuthors[2]},
                    new Book { Title = "The Thorn Birds", Genre = Book.GenreType.Romance, Pages = 692, ReleaseDate =19770401, Author = MyAuthors[3]},
                    new Book { Title = "The Autobiography of Malcolm X", Genre = Book.GenreType.Biography, Pages = 528, ReleaseDate =19890502, Author = MyAuthors[4]},

                };
                return myBooks;
            }
            set { myBooks = value; }
        }

        private static List<Magazine> myMagazines;
        public static List<Magazine> MyMagazines
        {
            get
            {
                myMagazines = new List<Magazine>()
                {
                    new Magazine { Title = "Mode tribes", Genre = Magazine.GenreType.Mode, Pages = 34, ReleaseDate =20160815, Author = MyAuthors[0]},
                    new Magazine { Title = "Beauty Scoop", Genre = Magazine.GenreType.Beauty, Pages = 46, ReleaseDate =20160923, Author = MyAuthors[1]},
                    new Magazine { Title = "PC World", Genre = Magazine.GenreType.Technologie, Pages = 49, ReleaseDate =20161205, Author = MyAuthors[2]},
                    new Magazine { Title = "Discover", Genre = Magazine.GenreType.Science, Pages = 36, ReleaseDate =20161205, Author = MyAuthors[3]},
                    new Magazine { Title = "Car and Driver", Genre = Magazine.GenreType.Vehicles, Pages = 32, ReleaseDate =20160223, Author = MyAuthors[4]},
                };
                return myMagazines;
            }
            set { myMagazines = value; }
        }

        private static List<Paper> myPapers;
        public static List<Paper> MyPapers
        {
            get
            {
                myPapers = new List<Paper>()
                 {
                     new Paper {Title = "New york Daily", Genre = Paper.GenreType.News, Pages = 34, ReleaseDate =20160815, Author = MyAuthors[0]},
                     new Paper {Title = "France football", Genre = Paper.GenreType.Sport, Pages = 38, ReleaseDate =20161220, Author = MyAuthors[2]},
                     new Paper {Title = "The new era", Genre = Paper.GenreType.Politic, Pages = 28, ReleaseDate =20161109, Author = MyAuthors[1]},
                     new Paper {Title = "My doctor", Genre = Paper.GenreType.Health, Pages = 29, ReleaseDate =20161205, Author = MyAuthors[3]},
                     new Paper {Title = "Celebrities news", Genre = Paper.GenreType.Celebrities, Pages = 42, ReleaseDate =20160815, Author = MyAuthors[4]},
                 };
                return myPapers;
            }
            set { myPapers = value; }
        }

        private static List<Author> myAuthors;
        public static List<Author> MyAuthors
        {
            get
            {
                myAuthors = new List<Author>()
                    {
                        new Author {Name = "Stephen King",Age = 69 },
                        new Author {Name = "J.R.R. Tolkien",Age = 73 },
                        new Author {Name = "Charles Dickens",Age = 45 },
                        new Author {Name = "Colleen McCullough",Age = 58 },
                        new Author {Name = "Malcolm X",Age = 51 },
                    };

                return myAuthors;
            }
            set { myAuthors = value; }
        }


    }
}
