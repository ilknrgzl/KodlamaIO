using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> name = new MyList<string>();
            name.Add("İlknur");

            Console.ReadLine();
        }
    }
}
