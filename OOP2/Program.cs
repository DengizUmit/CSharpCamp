using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri customer1 = new GercekMusteri();
            customer1.CustomerId = "4354";
            customer1.FirstName = "Ümit";
            customer1.LastName = "Dengiz";
            customer1.TcNo = "23643647";

            TuzelMusteri customer2 = new TuzelMusteri();
            customer2.Id = 2;
            customer2.CustomerId = "3253";
            customer2.CompanyName = "Enqura IT";
            customer2.TaxNo = "6446248";

            // Gerçek - Tüzel Müşteri

            // SO'L'ID

            // new : reference
            Customer customer3 = new GercekMusteri();
            Customer customer4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.ReadLine();
        }
    }
}
