using System;

namespace Shapes.Abstracted
{
    public class ShapePrinter
    {
        public void PrintShapesWithAreas()
        {
            Square square1 = new Square("Square 1", 5);
            Square square2 = new Square("Square 2", 10);
            Circle circle1 = new Circle("Circle 1", 10);
            Console.WriteLine(square1.GetPrintText());
            Console.WriteLine(square2.GetPrintText());
            Console.WriteLine(circle1.GetPrintText());
        }
    }
}