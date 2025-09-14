using System;

namespace OOPPrinciper
{
    class Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Vehicle is driving...");
        }
    }

    class Car : Vehicle
    {
        public void Honk()
        {
            Console.WriteLine("Car is honking!");
        }
    }
}





