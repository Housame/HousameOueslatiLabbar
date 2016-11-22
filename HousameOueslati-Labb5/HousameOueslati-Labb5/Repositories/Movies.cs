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
    class Movies : IRepository
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
        public String MainArtist;
        public GenreType Genre;

        static string moviePath = @"C:\Users\Housame\Documents\DataStore\Movie.json";  //Path för den som clonar programmet till sin dator för att ändra
        public void CreateGetFile()
        {

            if (File.Exists(moviePath))
            {
                string json = File.ReadAllText(moviePath);
                ListManager.Movie = JsonConvert.DeserializeObject<List<Movies>>(json);
            }

            else
            {
                File.WriteAllText(moviePath, JsonConvert.SerializeObject(ListManager.Movie));
            }
            
        } //Söker om JSON filen existerar annars skapar den det
        public void Remove(int index)
        {
            ListManager.Movie.RemoveAt(index);
            File.WriteAllText(moviePath, JsonConvert.SerializeObject(ListManager.Movie));
        } //Remove sen sparar den till filen
        public static List<Movies> GetMovies()
        {
            string json = File.ReadAllText(moviePath);
            List<Movies> newMovie = new List<Movies>();
            newMovie = JsonConvert.DeserializeObject<List<Movies>>(json);
            return newMovie;
        } //Laddar upp filen till listan
        public static void AddMovie(Movies newMovie)
        {
            ListManager.Movie.Add(newMovie);
            File.WriteAllText(moviePath, JsonConvert.SerializeObject(ListManager.Movie));
        } //Laddar upp listan till filen

    }
}
