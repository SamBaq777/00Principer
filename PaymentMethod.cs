using System;

namespace OOPPrinciper
{
    abstract class PaymentMethod
    {
        public abstract void Pay(decimal amount);
    }

    class CreditCard : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} with credit card.");
        }
    }
}
