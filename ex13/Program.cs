using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//asal sayı bulucu
namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı: ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool c = false;
            int b = a;
            while(--b > 1)
            {
                if (a % b == 0)
                    c = false;
                else
                    c = true;
            }
            if (c == true) { Console.WriteLine("sayınız asal sayıdır"); }
            else { Console.WriteLine("sayınız asal sayıdeğildir"); }
            { Console.WriteLine(); }
            Console.ReadLine();
        }
    }
}
