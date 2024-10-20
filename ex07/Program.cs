using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5,7};
            int b = 0;
            foreach(int i in a)
                b += i;
            Console.WriteLine("toplam: {0}",b);
            Console.ReadLine(); 
        }
    }
}
