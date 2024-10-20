using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//farktoriyel hesaplayan bir program
namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            while (--a > 1)
                b *= a;
            Console.WriteLine(b);
        }
    }
}
