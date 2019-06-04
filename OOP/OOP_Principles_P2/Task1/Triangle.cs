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

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (this.height <= 0)
                {
                    throw new Exception("Height can't 0 or less!");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (this.width <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height can't 0 or less!");
                }

                this.width = value;
            }
        }

        public override double CalculateSurface()
        {
            double surface = (this.height * this.width) / 2;
            return surface;
        }
    }
}
