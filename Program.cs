using System;

namespace OOPPrinciper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arv
            Car myCar = new Car();
            myCar.Drive();
            myCar.Honk();

            // Polymorfism
            Shape shape = new Circle();
            shape.Draw();

            // Inkapsling
            User user = new User();
            user.SetPassword("1234");
            Console.WriteLine(user.CheckPassword("1234")); // true

            // Abstraktion
            PaymentMethod payment = new CreditCard();
            payment.Pay(99.99m);
        }
    }
}
