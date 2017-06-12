using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni
{
    class Client
    {
        public void OdenecekMeblayiHesapla(ITutarHesaplayici hesaplayici)
        {
            Console.WriteLine("\nLütfen fiyatı giriniz");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nLütfen adedi giriniz");
            double adet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nTutar:" + hesaplayici.Hesap(fiyat, adet));
            Console.WriteLine();
        }
    }
}
