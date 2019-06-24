namespace Task3
{
    using System;

    public class AdvancedMathDouble : IAdvancedMathable<double>
    {
        public void Ln(double logarithm)
        {
            Math.Log10(logarithm);
        }

        public void Sin(double degrees)
        {
            Math.Sin(degrees);
        }

        public void SquareRoot(double number)
        {
            Math.Sqrt(number);
        }
    }
}
