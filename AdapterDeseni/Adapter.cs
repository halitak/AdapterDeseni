using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni
{
    class Adapter:ITutarHesaplayici
    {
        private Adaptee adaptee;

        public Adapter() {
            adaptee = new Adaptee();
        }

        public double Hesap(double fiyat, double adet)
        {
            return adaptee.IskontaliTutarHesapla(fiyat, adet);
        }
    }
}
