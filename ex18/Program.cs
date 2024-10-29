using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dog dog = new dog();
            dog.eat();
            dog.bark();
        }
    }
    public class animal
    {
        public void eat()
        {
            Console.WriteLine("animal is eating");
        }
    }
    public class dog : animal
    {
        public void bark()
        {
            Console.WriteLine("dog is barking");
        }
    }
}