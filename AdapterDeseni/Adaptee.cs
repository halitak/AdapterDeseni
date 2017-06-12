using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni
{
    class Adaptee
    {
        public double IskontaliTutarHesapla(double fiyat,double adet) {
            Console.WriteLine("lütfen iskonto miktarını giriniz");
            double iskonto = Convert.ToDouble(Console.ReadLine());
            return fiyat * adet * (1 - iskonto);
        }
    }
}
