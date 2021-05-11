using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1997,
                FirstName = "Ümit",
                LastName = "Dengiz",
                IdentityNumber = 12345
            });

            Console.WriteLine();
        }
    }
}
