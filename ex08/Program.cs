using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("{0} sayısı çift sayıdır", a);
            else
                Console.WriteLine("{0} sayısı tek sayıdır", a);
        }
    }
}
