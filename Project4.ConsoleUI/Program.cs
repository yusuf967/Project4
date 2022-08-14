using Project4.Business;
using Project4.DataAccess;
using Project4.Entities;

ProductManager productManager = new ProductManager(new EFProductDal());

productManager.Add(new Product { ProductName = "Masa", CategoryId = 1, QuantityPerUnit = "4 ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });

     foreach (var product in productManager.GetAll())
     {
            Console.WriteLine(product.ProductName);
     }