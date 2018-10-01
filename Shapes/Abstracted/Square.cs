using System;

namespace Shapes.Abstracted
{
    public class Square
    {
        public string Name { get; private set; }
        public int Length { get; private set; }

        public Square(string name, int length)
        {
            this.Name = name;
            this.Length = length;
        }

        public int GetArea()
        {
            return this.Length * this.Length;
        }

        public string GetPrintText()
        {
            return "This shape is called: " + this.Name + " and it has an area of " + this.GetArea();
        }
    }
}