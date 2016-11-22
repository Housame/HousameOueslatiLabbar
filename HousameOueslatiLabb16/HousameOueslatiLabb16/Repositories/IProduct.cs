using HousameOueslatiLabb16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousameOueslatiLabb16.Repositories
{
    interface IProduct
    {
        void Add(Product newProduct);
        void Get(int id);
        void GetAll();
        void Update(Product updatedProduct);
        void Delete(int id);
    }
}
