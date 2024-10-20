using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen 1.sayıyı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen 2.sayıyı giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen yapmak istediğiniz işlemin sembolünü giriniz");
            string islem = Console.ReadLine();
            int c;

            if (islem == "+")
            {
                c = Toplama(a, b);
                Console.WriteLine("işleminizin sonucu: {0}", c);
            }
            else if (islem == "-")
            {
                c = Cıkarma(a, b);
                Console.WriteLine("işleminizin sonucu: {0}", c);
            }
            else if (islem == "*")
            {
                c = Carpma(a, b);
                Console.WriteLine("işleminizin sonucu: {0}", c);
            }
            else if (islem == "/")
            {
                c = Bolme(a, b);
                Console.WriteLine("işleminizin sonucu: {0}", c);
            }
            else
                Console.WriteLine("lütfen geçerli bir işlem giriniz");
            Console.ReadLine();
        }
        static int Toplama(int a, int b)
        {return a + b;}
        static int Cıkarma(int a, int b)
        { return a - b; }
        static int Carpma(int a, int b)
        { return a * b; }
        static int Bolme(int a, int b)
        { return a / b; }
    }
}
