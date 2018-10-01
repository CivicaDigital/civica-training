using System;

namespace Shapes.Abstracted
{
    public class Circle
    {
        public string Name { get; private set; }
        public int Radius { get; private set; }

        public Circle(string name, int radius)
        {
            this.Name = name;
            this.Radius = radius;
        }

        public int GetArea()
        {
            return (int)(Math.PI * this.Radius * this.Radius);
        }

        public string GetPrintText()
        {
            return "This shape is called: " + this.Name + " and it has an area of " + this.GetArea();
        }
    }
}