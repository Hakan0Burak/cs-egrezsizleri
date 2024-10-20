using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("doğum günü tarihiniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int gunyil = DateTime.Now.Year;
            int yas = gunyil -  a;
            Console.WriteLine("yaşınız: {0}", yas);
        }
    }
}
