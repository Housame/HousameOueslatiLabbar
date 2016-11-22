using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HousameOueslatiLabb16.Models;
using Newtonsoft.Json;

namespace HousameOueslatiLabb16.Repositories
{
    class ListProduct : IProduct
    {
        private static List<Product> productList;
        public static List<Product> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }

        public void Add(Product newProduct)
        {
            ProductList.Add(newProduct);
        }

        public void Delete(int id)
        {
            var productToRemove = ProductList.SingleOrDefault(product => product.Id == id);
            ProductList.Remove(productToRemove);
        }

        public void Get(int id)
        {
            var productToGet = ProductList.FindAll(product => product.Id == id);
            foreach (var product in productToGet)
            {
                Console.WriteLine("Product: {0}. Price {1}", product.Name, product.Price);
            }
        }

        public void GetAll()
        {
            Console.WriteLine("Current products is: ");
            foreach (var product in ProductList)
            {
                Console.WriteLine("ID: {0} - {1} - {2} SEK.", product.Id, product.Name, product.Price);
            }
            Console.ReadKey();
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
           
        }
    }
}
