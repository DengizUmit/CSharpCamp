using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        // Method Injections
        public void BasvuruYap(ICreditBaseManager creditBaseManager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
            //
            creditBaseManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
