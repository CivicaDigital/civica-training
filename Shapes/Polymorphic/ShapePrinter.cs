using System;
using System.Collections.Generic;

namespace Shapes.Polymorphic
{
    public class ShapePrinter
    {
        public void PrintShapesWithAreas()
        {
            var shapes = new List<Shape>
            {
                new Square("Square 1", 5),
                new Square("Square 2", 10),
                new Circle("Circle 1", 10)
            };

            foreach(var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}