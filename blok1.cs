using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w02
{
    class blok
    {
        public int iloscPieter;
        public bool senior;
        public void CzyWinda()
        {
            this.iloscPieter = iloscPieter;
            this.senior = senior;
            if (this.iloscPieter < 3 && this.senior == false)
                Console.WriteLine("Winda nie jest potrzebna");
            else if (this.iloscPieter >= 3 && this.senior == true)
                Console.WriteLine("Winda jest potrzebna");
        }
    }
}
