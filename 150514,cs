using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progobcw
{
    class Program
    {
        static void poPrzecinku(int[] tablica)

        {
            Console.Write("(" + string.Join(",", tablica) + ")");
        }

        static void nowaLinia(int[] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }
        static void odwKolej(int[] tablica)
        {
            Array.Reverse(tablica);
            Console.Write("(" + string.Join(",", tablica) + ")");
        }
        static void porownywanie()
        {
            int a, b, c;
            Console.Write("Podaj a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Podaj c: ");
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else if (a == b)
            {
                Console.WriteLine("a == b");
            }
            else
            {
                Console.WriteLine("b > a");
            }
            if (a > c)
            {
                Console.WriteLine("a > c");
            }
            else if (a == c)
            {
                Console.WriteLine("a == c");
            }
            else
            {
                Console.WriteLine("c > a");
            }
            if (b > c)
            {
                Console.WriteLine("b > c");
            }
            else if (b == c)
            {
                Console.WriteLine("b == c");
            }
            else
            {
                Console.WriteLine("c > b");
            }
        }
        static void trojkat()
        {
            int a, b, c;
            Console.Write("Podaj a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Podaj c: ");
            c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                if (a <= (b + c))
                {
                    Console.WriteLine("Istnieje trójkąt o podanych bokach");
                }
                else
                {
                    Console.WriteLine("Nie istnieje trójkąt o podanych bokach");
                }

            }
            if (b >= a && b >= c)
            {
                if (b <= (a + c))
                {
                    Console.WriteLine("Istnieje trójkąt o podanych bokach");
                }
                else
                {
                    Console.WriteLine("Nie istnieje trójkąt o podanych bokach");
                }

            }
            if (c >= b && c >= a)
            {
                if (c <= (a + b))
                {
                    Console.WriteLine("Istnieje trójkąt o podanych bokach");
                }
                else
                {
                    Console.WriteLine("Nie istnieje trójkąt o podanych bokach");
                }
            }
        }
        static void ogran()
        {

            int liczba;
            Console.Write("Podaj liczbe >5 i <15: ");
            liczba = int.Parse(Console.ReadLine());
            if (liczba > 5 && liczba < 15)
            {
                while (liczba + 1 != 0)
                {
                    liczba -= 1;
                    Console.WriteLine(liczba + 1);
                }
            }
            else
            {
                Console.Write("Zły przedział");
            }
        }

        static void warunek()
        {

            int liczba = 0;
            do
            {
                Console.Write("Podaj liczbe: ");
                liczba = int.Parse(Console.ReadLine());
            }
            while (!(liczba > 4 && liczba < 7 && liczba != 10));
            Console.WriteLine("Podano prawidłową liczbę");
        }
        static void Main(string[] args)
        {

            int[] tablica = new int[] { 1, 2, 3, 4, 5 };
            //poPrzecinku(tablica);
            //nowaLinia(tablica);
            //odwKolej(tablica);
            //porownywanie();
            //trojkat();
            //ogran();
            //warunek();
            Console.ReadKey();

        }
    }
}
