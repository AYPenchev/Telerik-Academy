namespace Task2
{
    public class SimpleMathDecimal : ISimpleMathable<decimal>
    {
        private decimal decimalPlaceholder = 0;

        public void Add(decimal addend)
        {
            this.decimalPlaceholder += addend;
        }

        public void Devide(decimal devisor)
        {
            this.decimalPlaceholder /= devisor;
        }

        public void Increment()
        {
            this.decimalPlaceholder++;
        }

        public void Multiply(decimal multiplier)
        {
            this.decimalPlaceholder *= multiplier;
        }

        public void Substract(decimal minuend)
        {
            this.decimalPlaceholder -= minuend;
        }
    }
}
