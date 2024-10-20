using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int b = rnd.Next(0,100);
            Console.WriteLine("tahmini sayı: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (b == a)
                Console.WriteLine("doğru tahmin!!!!!");
            else 
            {
                Console.WriteLine("yanlış tahmin");
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
