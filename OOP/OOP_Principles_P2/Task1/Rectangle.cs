namespace Task1
{
    using System;

    class Rectangle : Shape
    {
        public Rectangle() : base()
        {

        }

        public Rectangle(double height, double width) : base(height, width)
        {

        }
        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;
            return surface;
        }
    }
}
