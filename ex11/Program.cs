using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("kaçıncı: ");
            int i = Convert.ToInt32(Console.ReadLine());
            i -= 3;
            c = b + a;
            while (--i >= 0)
            {
                a = c;
                c = a + b;
                b = a;
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
