using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a > 0)
                Console.WriteLine("P");
            else if( a == 0)
                Console.WriteLine("Nötr");
            else
                Console.WriteLine("N");
        }
    }
}
