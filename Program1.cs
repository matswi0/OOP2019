using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Blok 1");
            blok b1 = new blok();
            b1.iloscPieter = 10;
            b1.senior = true;
            b1.CzyWinda();
            Console.WriteLine("Blok 2");
            blok b2 = new blok();
            b2.iloscPieter = 3;
            b2.senior = true;
            b2.CzyWinda();
            Console.ReadKey();
        }
    }
}
