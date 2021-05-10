using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BasketManager
    {
        // naming convention : isimlendirme kuralı
        // syntax
        public void Add(Product product)
        {
            Console.WriteLine("Yuppi Sepete eklendi : "+ product.Name);
        }

    }
}
