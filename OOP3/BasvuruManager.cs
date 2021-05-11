using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditBaseManager creditBaseManager)
        {
            // Başvuran bilgilerini değerlendirme
            //
            creditBaseManager.Hesapla();
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
