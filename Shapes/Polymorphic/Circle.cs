using System;

namespace Shapes.Polymorphic
{
    public class Circle : Shape
    {
        public int Radius { get; protected set; }

        public Circle(string name, int radius) : base(name)
        {
            this.Radius = radius;
        }

        public override int Area()
        {
            return (int)(Math.PI * this.Radius * this.Radius);
        }
    }
}