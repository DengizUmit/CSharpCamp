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
        public void BasvuruYap(ICreditBaseManager creditBaseManager, ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme
            //
            creditBaseManager.Hesapla();
            loggerService.Log();
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
