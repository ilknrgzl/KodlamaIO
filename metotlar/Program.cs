using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string acilkama = "Amasya Elmasý";


            //string[] meyveler = new string[] { };


            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama= "Amasya Elmasý";

            Urun urun2 = new Urun();
            urun2.Adi = "çilek";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Çilek gibi çilek";

            Urun[] urunler = new Urun[] {urun1,urun2};


            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");


            }

            Console.WriteLine("------------Metotlar-------------");
            SepetManager sepetManager = new SepetManager();


            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeþil armut", 12);
            sepetManager.Ekle2("elma", "yeþil elma", 12);
            sepetManager.Ekle2("karpuz", "diyarbakýr karpuzu", 12);



            Console.ReadLine();

        }
    }
}
