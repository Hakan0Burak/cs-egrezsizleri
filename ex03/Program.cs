using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = toplama(5, 10);
            Console.WriteLine(result);
        }
        static int toplama(int a, int b)
        { return a + b;}
    }
}
