using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class KonutCreditManager : ICreditBaseManager
    {
        public void Hesapla()
        {
            //
            // Simulation
            //
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");
        }

        public void Listele()
        {
            throw new NotImplementedException();
        }
    }
}
