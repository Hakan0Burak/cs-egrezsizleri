using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütefen 1.sayıyı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütefen 2.sayıyı giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("toplam: {0}",result);
        }
    }
}
