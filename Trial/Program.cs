using System;

namespace entry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar();
            Credit();

            Console.ReadLine();
        }

        private static void Credit()
        {
            string[] credits = { "Fast", "Happy", "Angry" };

            foreach (string credit in credits)
            {
                Console.WriteLine(credit);
            }
        }

        private static void Dollar()
        {
            double DolarDun = 7.5;
            double DolarBugun = 8.3;

            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (DolarDun < DolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi, sabit");
            }
        }
    }
}
