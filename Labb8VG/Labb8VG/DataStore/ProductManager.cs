using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb8VG.Runtime;

namespace Labb8VG.DataStore
{
    class ProductManager
    {
         List<Product> productList;

        public  List<Product> ProductList
        {
            get
            {
                if (productList == null)
                    productList = new List<Product>()
                    {
                        new Product {Id = new Guid("0fb7097c-335c-4d07-b0fd-000004e2d28a"), Name = "Processor", Price = 799.99f },
                        new Product {Id = new Guid("1fb1287c-134c-4e78-b9fd-000004e5c30b"), Name = "DVD-Reader", Price = 399.99f },
                        new Product {Id = new Guid("2fb1287c-287c-4e89-b8fd-000004e5c60c"), Name = "Screen", Price = 1299.99f },
                        new Product {Id = new Guid("3fb0737c-852c-4e87-b7fd-000004e5c74d"), Name = "Hard-disk", Price = 999.99f },
                        new Product {Id = new Guid("4fb2252c-366c-4e80-b6fd-000004e5c59e"), Name = "Camera", Price = 299.99f },
                        new Product {Id = new Guid("5fb6242c-816c-4e97-b5fd-000004e5c54f"), Name = "Grafic-Card", Price = 2499.99f },
                        new Product {Id = new Guid("6fb7508c-128c-4e71-b4fd-000004e5c16c"), Name = "Keyboard", Price = 1099.99f },
                        new Product {Id = new Guid("7fb5021c-781c-4e93-b3fd-000004e5c99c"), Name = "Mouse", Price = 599.99f },
                        new Product {Id = new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"), Name = "Headphones", Price = 2199.99f },
                        new Product {Id = new Guid("9fb2048c-512c-4e16-b4fd-000004e5c08a"), Name = "Mother-Card", Price = 1699.99f }
                    };
                return productList;
            }
            set { productList = value; }
        }

       

        public void FormatProductNames(StringConcatinator format)
        {
            string names = "";
            foreach (var name in ProductList)
            {
                names += name.Name.ToString()+@"//";
            }
            format(names);
        }

        public void PriceCalculation(Func<float,float, float> calc)
        {
            float total = 0;
            foreach (var price in ProductList)
            {
                
                total = calc(total, price.Price);
            }
            Console.WriteLine(total); 
        }

    }
}
