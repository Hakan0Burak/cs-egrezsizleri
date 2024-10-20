using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Array.Reverse(a);
            foreach (int b in a)
                Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
