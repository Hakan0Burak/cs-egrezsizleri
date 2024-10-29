using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hesaplama toplama = new toplama();
            hesaplama cıkarma = new cıkarma();
            hesaplama çarpma = new çarpma();
            hesaplama bölme = new bölme();
            int a;
            int b;
            char c;

            Console.WriteLine("1.sayı: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("işlem: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("2.sayı: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (c == '+') { Console.WriteLine(toplama.islem(a, b)); } else if (c == '-') { Console.WriteLine(cıkarma.islem(a, b)); } else if (c == '*') { Console.WriteLine(çarpma.islem(a, b)); } else if (c == '/') { Console.WriteLine(bölme.islem(a, b)); } else { Console.WriteLine("lütfen geçerli bir işaretle işlem yapmayı deneyiniz"); }
        }
        interface hesaplama { int islem(int a, int b); }

        public class toplama : hesaplama { public int islem(int a, int b) { return a + b; } }
        public class cıkarma : hesaplama { public int islem(int a, int b) { return a - b; } }
        public class çarpma : hesaplama { public int islem(int a, int b) { return a * b; } }
        public class bölme : hesaplama { public int islem(int a, int b) { return a / b; } }
    }
}