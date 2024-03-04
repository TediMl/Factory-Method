using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProject
{
    public class PaypalPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Sucessfully paid ${amount} while using Paypal Payment.");
        }
    }
}
