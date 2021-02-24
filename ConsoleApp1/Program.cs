using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace döngüler

{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            // array-diziler
            string[] kurslar = new string[] {"yazılım yetiştirme kampı", "programlamaya başlangıç için temel kurs","java"};


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.ReadLine();
        }
    }
}
