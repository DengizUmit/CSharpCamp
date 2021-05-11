using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Telephone";
            product1.UnitPrice = 7000;
            product1.UnitsInStock = 2;

            Product product2 = new Product { Id = 2, CategoryId = 4, ProductName = "Laptop", UnitPrice = 6000, UnitsInStock = 1};


            // case sensitive
            // PascalCase  // camelCase
            ProductManager productManager = new ProductManager();    // Stack -=- Heap
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



            Console.ReadLine();
        }
    }
}
