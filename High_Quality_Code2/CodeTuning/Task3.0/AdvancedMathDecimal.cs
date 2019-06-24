
namespace Task3
{
    using DecimalMathOperations;

    public class AdvancedMathDecimal : IAdvancedMathable<decimal>
    {
        public void Ln(decimal logarithm)
        {
            DecimalMath.Log(logarithm);
        }

        public void Sin(decimal degrees)
        {
            DecimalMath.Sin(degrees);
        }

        public void SquareRoot(decimal number)
        {
            DecimalMath.Sqrt(number);
        }
    }
}
