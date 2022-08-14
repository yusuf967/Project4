using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class ProductDal:IProductDal
    {
        //Ado.Net
        List<Product> products;

        public ProductDal()
        {
            products = new List<Product>
            {
                new Product{ProductId=1,ProductName="Acer Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitsInStock=2},
                new Product{ProductId=2,ProductName="Asus Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitsInStock=1},
                new Product{ProductId=3,ProductName="Hp Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitsInStock=2},
                new Product{ProductId=4,ProductName="Mac Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitsInStock=3},
                new Product{ProductId=5,ProductName="Dell Bilgisayar", QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitsInStock=10}
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado. NET ile Eklendi."); 
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
