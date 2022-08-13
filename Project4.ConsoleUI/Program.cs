using Project4.Business;
using Project4.DataAccess;

ProductManager productManager = new ProductManager(new EFProductDal());

     foreach (var product in productManager.GetAll())
     {
            Console.WriteLine(product.ProductName);
     }