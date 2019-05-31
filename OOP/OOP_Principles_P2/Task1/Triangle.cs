namespace Task1
{
    using System;

    class Triangle : Shape
    {
        public Triangle() : base()
        {

        }

        public Triangle(double height, double width) : base(height, width)
        {

        }
        public override double CalculateSurface()
        {
            double surface = (this.Height * this.Width) / 2;
            return surface;
        }
    }
}
