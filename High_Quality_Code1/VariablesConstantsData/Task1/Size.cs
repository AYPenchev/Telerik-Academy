namespace Task1
{
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Size GetRotatedSize(Size size, double angleToBeRotated)
        {
            double width = Math.Abs(Math.Cos(angleToBeRotated)) * size.Width +
                           Math.Abs(Math.Sin(angleToBeRotated)) * size.Height;

            double height = Math.Abs(Math.Sin(angleToBeRotated)) * size.Width +
                            Math.Abs(Math.Cos(angleToBeRotated)) * size.Height;

            return new Size(width, height);
        }
    }
}
