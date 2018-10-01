using System;

namespace Shapes.Encapsulated
{
    public class ShapePrinter
    {
        public void PrintShapesWithAreas()
        {
            Square square1 = new Square("Square 1", 5);
            Square square2 = new Square("Square 2", 10);
            Circle circle1 = new Circle("Circle 1", 10);
            square1.PrintNameAndArea();
            square2.PrintNameAndArea();
            circle1.PrintNameAndArea();
        }
    }
}