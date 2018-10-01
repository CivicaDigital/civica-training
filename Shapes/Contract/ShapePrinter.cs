using System;
using System.Collections.Generic;

namespace Shapes.Contract
{
    public class ShapePrinter
    {
        List<Shape> shapes = new List<Shape>
            {
                new Square("Square 1", 5),
                new Square("Square 2", 10),
                new Circle("Circle 1", 10),
                new Cube("Cube 1", 10)
            };

        public void PrintShapesWithAreas()
        {
            foreach(var shape in this.shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }

        public void PrintShapesWithVolumes()
        {
            foreach(var shape in this.shapes)
            {
                var shapeWithVolume = shape as IHasVolume;
                if (shapeWithVolume != null)
                {
                    Console.WriteLine(shape.Name + " also has a volume of " + shapeWithVolume.Volume());
                }
            }
        }
    }
}