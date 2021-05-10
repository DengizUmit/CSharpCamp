using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // --> do not repeat yourself

            // type safety - tip güvenliği

            string CategoryTag = "Category";
            int OgrenciSayisi = 45;
            double FaizOranı = 1.89;
            bool SistemeGirisYapmısMı = false;
            

            if (SistemeGirisYapmısMı == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine(CategoryTag);

            Console.ReadLine();
        }
    }
}
