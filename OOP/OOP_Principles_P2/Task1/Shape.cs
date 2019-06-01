namespace Task1
{
    using System;

    public abstract class Shape
    {
        protected double width;
        protected double height;
        protected Shape()
        {
            this.height = 1;
            this.width = 1;
        }
        protected Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }

        public abstract double CalculateSurface();
    }
}
