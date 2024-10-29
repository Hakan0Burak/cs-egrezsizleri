using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment1 = new CreditCard();
            IPayment payment2 = new BankCard();

            payment1.ProcessPayment();
            payment2.ProcessPayment();
        }
    }
    interface IPayment
    {
        void ProcessPayment();
    }
    public class CreditCard : IPayment
    {
        void IPayment.ProcessPayment()
        {
            Console.WriteLine("kredi kartıyla ödeme işleminiz kabul edilmiştir");
        }
    }
    public class BankCard : IPayment
    {
        void IPayment.ProcessPayment()
        {
            Console.WriteLine("banka kartıyla ödeme işlemi kabul edilmiştir");
        }
    }
}