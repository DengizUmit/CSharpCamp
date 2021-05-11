using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Muz";
            product1.Price = 3;
            product1.Explanation = "Anamur Muzu";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Kavun";
            product2.Price = 2;
            product2.Explanation = "Sulu Kavun";


            Product[] products = new Product[] { product1, product2 };

            // Type safetly
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("\n");
            }


            Console.WriteLine("\tMethods\t");

            // Instance
            // Encapsulation

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);


            Console.ReadLine();
        }
    }
}

// DRY, Clean Code, Best Practice