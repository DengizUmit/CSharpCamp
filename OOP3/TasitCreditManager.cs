using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitCreditManager : ICreditBaseManager
    {
        public void Hesapla()
        {
            //
            // Simulation
            //
            Console.WriteLine("Taşıt Kredisi ödeme planı hesaplandı.");
        }

        public void Listele()
        {
            throw new NotImplementedException();
        }
    }
}
