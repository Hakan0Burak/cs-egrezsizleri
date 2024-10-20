using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    struct ogrenci
    {
        public string isim;
        public int yas;
        public int not;
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            ogrenci ogrenci1;
            Console.WriteLine("öğrecinin ismini giriniz: ");
            ogrenci1.isim = Console.ReadLine();
            Console.WriteLine("öğrecinin yasını giriniz: ");
            ogrenci1.yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("öğrecinin notunu giriniz: ");
            ogrenci1.not = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------öğrenci bilgileri-----------");
            Console.WriteLine("İsim: " + ogrenci1.isim);
            Console.WriteLine("Yaş: " + ogrenci1.yas);
            Console.WriteLine("Not: " + ogrenci1.not);
            Console.ReadLine();
        }

    }
}
