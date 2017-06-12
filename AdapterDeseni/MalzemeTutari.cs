using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni
{
    class MalzemeTutari:ITutarHesaplayici
    {
        public double Hesap(double fiyat, double adet)
        {
            return fiyat * adet;
        }
    }
}
