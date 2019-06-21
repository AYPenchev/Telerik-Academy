namespace Task2
{
    public class SimpleMathDouble : ISimpleMathable<double>
    {
        private double doublePlaceholder = 0;

        public void Add(double addend)
        {
            this.doublePlaceholder += addend;
        }

        public void Devide(double devisor)
        {
            this.doublePlaceholder /= devisor;
        }

        public void Increment()
        {
            this.doublePlaceholder++;
        }

        public void Multiply(double multiplier)
        {
            this.doublePlaceholder *= multiplier;
        }

        public void Substract(double minuend)
        {
            this.doublePlaceholder -= minuend;
        }
    }
}
