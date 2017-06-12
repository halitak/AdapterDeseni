using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            MalzemeTutari malzemeTutati = new MalzemeTutari();
            string tercih = null;
            Client client = new Client();
            try
            {
                while (true) {
                    Console.WriteLine("\nMalzemenin tutarını hesaplamak için 1'e," +
                        "\niskontolu tutarını hesaplamak için 2'ye" +
                        "\nuygulamadan çıkmak için 3'e basınız.\n");
                    tercih = Console.ReadLine();
                    int secenek = Convert.ToInt32(tercih);
                    Console.WriteLine();

                    if (secenek==1)
                    {
                        //client.OdenecekMeblayiHesapla(new MalzemeTipineGoreToplamTutariHesapla());
                        client.OdenecekMeblayiHesapla(new MalzemeTutari());
                    }
                    else if(secenek==2)
                    {
                        client.OdenecekMeblayiHesapla(new Adapter());
                    }
                    else if (secenek==3)
                    {
                        return;
                    }
                }
            }
            catch
            {

                Console.WriteLine("Hata ile karşılaşıldı, program sonlanacak");
            }
        }
    }
}
