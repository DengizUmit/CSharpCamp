using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager ihtiyacCreditManager = new IhtiyacCreditManager();

            ICreditBaseManager tasitCreditManager = new TasitCreditManager();

            ICreditBaseManager konutCreditManager = new KonutCreditManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacCreditManager);

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() { ihtiyacCreditManager, konutCreditManager };

            basvuruManager.KrediOnBilgilendirmesiYap(credits);

            Console.ReadLine();
        }
    }
}
