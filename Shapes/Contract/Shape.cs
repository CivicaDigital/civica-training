using System;

namespace Shapes.Contract
{
    public abstract class Shape
    {
        private readonly string name;

        public string Name
        {
            get { return this.name; }
        }    

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract int Area();

        public override string ToString()
        {
            return "This shape is called: " + this.name + " and it has an area of " + this.Area();
        }
    }
}