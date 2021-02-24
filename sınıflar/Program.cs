using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ilknur";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Eğitmeni = "İrem güzel";
            kurs1.IzlenmeOrani = 25;



            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c#";
            kurs2.Eğitmeni = "ilknur güzel";
            kurs2.IzlenmeOrani = 55;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Eğitmeni = "Pınar güzel";
            kurs3.IzlenmeOrani = 85;


            //Console.WriteLine(kurs1.KursAdi+" :"+kurs1.Eğitmeni+" "+kurs1.IzlenmeOrani );

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 };

           foreach (var kurs in kurslar)
           {
                    Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Eğitmeni + " " + kurs1.IzlenmeOrani);
           }


            Console.ReadKey();

            
        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }

        public string Eğitmeni { get; set; }

        public int IzlenmeOrani { get; set; }


    }



}
