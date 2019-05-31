using System.Runtime.CompilerServices;

namespace Task1
{
    using System;

    class Square : Shape
    {
        public Square() : base()
        {

        }

        public Square(double side)
        {
            this.Height = side;
            this.Width = side;
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
                    throw new ArgumentOutOfRangeException("Height can't 0 or less!");
                }

                this.height = value;
                this.width = value;
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

                this.height = value;
                this.width = value;
            }
        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;
            return surface;
        }
    }
}
