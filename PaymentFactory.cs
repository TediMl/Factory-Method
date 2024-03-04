using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProject
{
    public class PaymentFactory
    {
        public static IPayment create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                case PaymentMethod.PayPal:
                    return new PaypalPayment();
                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();

                default:
                    throw new NotSupportedException(
                    "${paymentMethod} is not currently supported as a payment method."
                    );
            }
        }

    }
}

