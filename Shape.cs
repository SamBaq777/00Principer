using System;

namespace OOPPrinciper
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape...");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle!");
        }
    }
}
