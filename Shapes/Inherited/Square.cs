using System;

namespace Shapes.Inherited
{
    public class Square : Shape
    {
        public int Length { get; protected set; }

        public Square(string name, int length) : base(name)
        {
            this.Length = length;
        }

        public override int Area()
        {
            return this.Length * this.Length;
        }
    }
}