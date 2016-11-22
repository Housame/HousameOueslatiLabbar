using HousameOueslatiLabb16.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb16.Repositories
{
    class FileProduct : IProduct
    {
        private static List<Product> productList;
        public static List<Product> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }

        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        static string listPath = projectPath + @"\Product.json";

        public void GetAll()
        {

            if (File.Exists(listPath))
            {
                string json = File.ReadAllText(listPath);
                ProductList = JsonConvert.DeserializeObject<List<Product>>(json);
            }

            else
            {
                var newProduct = new List<Product>() { };
            
                File.WriteAllText(listPath, JsonConvert.SerializeObject(newProduct));
            }

            Console.WriteLine("Current products is: ");
            foreach (var product in ProductList)
            {
                Console.WriteLine("ID: {0} - {1} - {2} SEK.", product.Id, product.Name, product.Price);
            }


        } //Söker om JSON filen existerar annars skapar den det

        public void Add(Product newProduct)
        {
           ProductList.Add(newProduct);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ProductList));
        }

        public void Get(int id)
        {
            GetAll();
            var productToGet = ProductList.FindAll(product => product.Id == id);
            foreach (var product in productToGet)
            {
                Console.WriteLine("Product: {0}. Price {1}", product.Name, product.Price);
            }
        }

        public void Update(Product updatedProduct)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change price");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;


            Console.Clear();
            Console.WriteLine("Product: {0}. Price {1}", updatedProduct.Name, updatedProduct.Price);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    updatedProduct.Name = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("New price: ");
                    updatedProduct.Price = int.Parse(Console.ReadLine());
                    break;
            }
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ProductList));
        }

        public void Delete(int id)
        {
            var productToRemove = ProductList.SingleOrDefault(product => product.Id == id);
            ProductList.Remove(productToRemove);
            File.WriteAllText(listPath, JsonConvert.SerializeObject(ProductList));
        }
    }
}
