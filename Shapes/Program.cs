using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer1 = new Encapsulated.ShapePrinter();
            printer1.PrintShapesWithAreas();

            var printer2 = new Abstracted.ShapePrinter();
            printer2.PrintShapesWithAreas();

            var printer3 = new Inherited.ShapePrinter();
            printer3.PrintShapesWithAreas();

            var printer4 = new Polymorphic.ShapePrinter();
            printer4.PrintShapesWithAreas();

            var printer5 = new Contract.ShapePrinter();
            printer5.PrintShapesWithAreas();
            printer5.PrintShapesWithVolumes();
        }
    }
}
