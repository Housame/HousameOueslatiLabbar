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
    class Books : IRepository
    {
        public enum GenreType
        {
            Thriller = 1,
            Criminal,
            TrueStory,
            Drama,
            ScienceFiction
        }

        public String Name;
        public int Year;
        public String Writer;
        public GenreType Genre;

        static string bookPath = @"C:\Users\Housame\Documents\DataStore\Book.json";    //Path för den som clonar programmet till sin dator för att ändra

        public void CreateGetFile()
        {

            if (File.Exists(bookPath))
            {
                string json = File.ReadAllText(bookPath);
                ListManager.Book = JsonConvert.DeserializeObject<List<Books>>(json);
            }

            else
            {
                File.WriteAllText(bookPath, JsonConvert.SerializeObject(ListManager.Book));
            }


        } //Söker om JSON filen existerar annars skapar den det
        public void Remove(int index)
        {
            ListManager.Book.RemoveAt(index);
            File.WriteAllText(bookPath, JsonConvert.SerializeObject(ListManager.Book));
        } //Remove sen sparar den till filen
        public static List<Books> GetBooks()
        {

            string json = File.ReadAllText(bookPath);
            List<Books> newBook = new List<Books>();
            newBook = JsonConvert.DeserializeObject<List<Books>>(json);
            return newBook;
        } //Laddar upp filen till listan
        public static void AddBook(Books newBook)
        {
            ListManager.Book.Add(newBook);
            File.WriteAllText(bookPath, JsonConvert.SerializeObject(ListManager.Book));


        } //Laddar upp listan till filen

    }
}
