// See https://aka.ms/new-console-template for more information


using FactoryMethodProject;

IPayment payment = PaymentFactory.create(PaymentMethod.CreditCard);
IPayment p = PaymentFactory.create(PaymentMethod.PayPal);
IPayment pay = PaymentFactory.create(PaymentMethod.GooglePay);
payment.Pay(300.00);
p.Pay(100.67);
pay.Pay(87.92);