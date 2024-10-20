using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 90, 5, 7, 3, 9, 2, 0, 30 , 60 };
            int b = 0;
            foreach(int i in a)
            {
                if (b < i)
                { b = i; }
            }
            Console.WriteLine("kümenin en büyük sayısı {0}", b);
            Console.ReadLine();
        }
    }
}
