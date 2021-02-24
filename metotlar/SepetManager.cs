using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class SepetManager
    {

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: "+ urun.Adi);

        }

        public void Ekle2(string urunAdi,string acıklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    


    }
}
