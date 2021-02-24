using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] name = new string[] { "İlknur", "İrem", "Pınar" };

            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name[2]);

            //name = new string[5];   // YENİ BİR DİZİ TANIMADIK BU SEBEPTEN 0 ELEMAN SİLİNDİ VE İLKNUR GÖSTERMEDİ.

            //name[3] = "Fatma";
            //Console.WriteLine(name[3]);
            //Console.WriteLine(name[0]);



            List<string> name2 = new List<string> { "İlknur", "İrem", "Pınar" };

            Console.WriteLine(name2[0]);
            Console.WriteLine(name2[1]);
            Console.WriteLine(name2[2]);

            name2.Add("Fatrma");
            Console.WriteLine(name2[3]);
            Console.WriteLine(name2[0]);

            Console.ReadLine();
        }
    }
}
