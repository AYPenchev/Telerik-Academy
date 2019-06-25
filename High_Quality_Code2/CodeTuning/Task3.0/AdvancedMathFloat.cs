namespace Task3
{
    using System;

    public class AdvancedMathFloat : IAdvancedMathable<float>
    {
        // private float floatPlaceholder = 10.2f;
        public void Ln(float logarithm)
        {
            Math.Log10(logarithm);
        }

        public void Sin(float degrees)
        {
            Math.Sin(degrees);
        }

        public void SquareRoot(float number)
        {
            Math.Sqrt(number);
        }
    }
}
