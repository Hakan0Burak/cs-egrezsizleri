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
            dog dog = new dog();
            cat cat = new cat();

            dog.makesound();
            cat.makesound();
        }
    }
    public class animal
    {
        public virtual void makesound()
        {
            Console.WriteLine("bir hayvan ses çıkarıyor");
        }
    }
    public class dog : animal
    {
        public override void makesound()
        {
            Console.WriteLine("hav hav!");
        }
    }
    public class cat : animal
    {
        public override void makesound()
        {
            Console.WriteLine("miyav miyav!");
        }
    }
}
