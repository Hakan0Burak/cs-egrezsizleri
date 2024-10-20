using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------");
            while (a <= b)
            {
                Console.WriteLine(a);
                a++;
            }

        }
    }
}
