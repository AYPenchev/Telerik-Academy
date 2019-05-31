namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class Shapes
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Triangle(2, 4),
                new Rectangle(4, 5),
                new Square(6)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
 