using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProject
{
    internal class CreditCardPayment : IPayment //inherited
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Sucessfully paid ${amount} while using Credit Card Payment.");
        }
    }
}
