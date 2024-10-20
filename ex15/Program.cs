using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.not: ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.not: ");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.not: ");
            int not3 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("ortalama: {0}", ortalama);

            if (ortalama > 50) { Console.WriteLine("geçtiniz"); }
            else { Console.WriteLine("kaldınız"); }
        }
    }
}
