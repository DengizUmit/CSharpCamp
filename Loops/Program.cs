using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "C# Yazılım Geliştirme";
            string kurs2 = "Python";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3 + "\n");


            string[] kurslar = new string[] { "C# - Yazılım Geliştirme", "Python", "Java", "BlockChain"};


            for(int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n");

            foreach(string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("\n sayfa sonu - footer");

            Console.ReadLine();
        }
    }
}
