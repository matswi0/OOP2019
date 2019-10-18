using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wejsc3
{
    class Program
    {
        static void bmi(float masa, float wzrost)
        {
            Console.WriteLine("Podana masta to: " + masa + " kg");
            Console.WriteLine("Podany wzrost to: " + wzrost + " m");
            float bmiwyn = masa / (wzrost * wzrost);
            Console.WriteLine("Wyliczone BMI: " + bmiwyn);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj masę w kg: ");
            float masa = float.Parse(Console.ReadLine());
            Console.Write("Podaj wzrost w m: ");
            float wzrost = float.Parse(Console.ReadLine());
            Console.WriteLine();
            bmi(masa, wzrost);
            Console.ReadKey();
        }
    }
}
