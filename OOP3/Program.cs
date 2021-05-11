using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yazılımda sürdürülebilirlik
            ICreditBaseManager ihtiyacCreditManager = new IhtiyacCreditManager();

            ICreditBaseManager tasitCreditManager = new TasitCreditManager();

            ICreditBaseManager konutCreditManager = new KonutCreditManager();

            ICreditBaseManager esnafCreditManager = new EsnafCreditManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            //basvuruManager.BasvuruYap(esnafCreditManager, loggers);

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafCreditManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService()});

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() { ihtiyacCreditManager, konutCreditManager };

            basvuruManager.KrediOnBilgilendirmesiYap(credits);

            Console.ReadLine();
        }
    }
}
