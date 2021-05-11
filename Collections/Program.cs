using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Array();

            List<string> names2 = new List<string> { "Ümit", "Bjorn", "Lagertha", "Astrid" };

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            names2.Add("Mazlum");

            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

            
            List<string> isimler3 = new List<string>();

            Console.ReadLine();
        }



        private static void Array()
        {
            string[] names = new string[] { "Ümit", "Bjorn", "Lagertha", "Astrid" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names = new string[5];
            names[4] = "Athelsan";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);
        }
    }
}
