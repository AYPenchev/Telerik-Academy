namespace Task1
{
    using System;

    class Rectangle : Figure
    {
        private double width;
        private double height;

        //Is this okay?
        public Rectangle(double width, double height)
        {
            try
            {
                this.Width = width;
                this.Height = height;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Set radius to numbers bigger than 0.
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Set radius to numbers bigger than 0.
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.height = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
