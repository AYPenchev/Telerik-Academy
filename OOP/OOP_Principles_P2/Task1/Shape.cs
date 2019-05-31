namespace Task1
{
    using System;

    public abstract class Shape
    {
        protected double width;
        protected double height;
        protected Shape()
        {
            this.Height = 1;
            this.Width = 1;
        }
        protected Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public virtual double Height
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
        public virtual double Width
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

        public abstract double CalculateSurface();
    }
}
