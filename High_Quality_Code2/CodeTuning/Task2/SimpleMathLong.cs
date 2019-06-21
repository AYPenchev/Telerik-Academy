namespace Task2
{
    public class SimpleMathLong : ISimpleMathable<long>
    {
        private long longPlaceholder = 0;

        public void Add(long addend)
        {
            this.longPlaceholder += addend;
        }

        public void Devide(long devisor)
        {
            this.longPlaceholder /= devisor;
        }

        public void Increment()
        {
            this.longPlaceholder++;
        }

        public void Multiply(long multiplier)
        {
            this.longPlaceholder *= multiplier;
        }

        public void Substract(long minuend)
        {
            this.longPlaceholder -= minuend;
        }
    }
}
