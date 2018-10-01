using System;

namespace Shapes.Contract
{
    public class Cube : Shape, IHasVolume
    {
        public int Length { get; protected set; }

        public Cube(string name, int length) : base(name)
        {
            this.Length = length;
        }

        public override int Area()
        {
            return this.Length * this.Length;
        }

        public int Volume()
        {
            return (int)Math.Pow(this.Length, 3);
        }
    }
}