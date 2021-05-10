using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Denmiroğ";
            kurs1.IzlenmeOrani = 73;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Kenan İnce";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Elon Musk";
            kurs3.IzlenmeOrani = 50;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C";
            kurs4.Eğitmen = "Jack Ma";
            kurs4.IzlenmeOrani = 90;


            //Console.WriteLine(kurs1.IzlenmeOrani + " " +kurs1.KursAdi);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Eğitmen+ " " +kurs.IzlenmeOrani);
            }

            Console.ReadLine();
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
