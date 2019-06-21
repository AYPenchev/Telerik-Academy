namespace Task2
{
    public class SimpleMathInteger : ISimpleMathable<int>
    {
        private int integerPlaceholder = 0;

        public void Add(int addend)
        {
            this.integerPlaceholder += addend;
        }

        public void Substract(int minuend)
        {
            this.integerPlaceholder -= minuend;
        }

        public void Increment()
        {
            this.integerPlaceholder++;
        }

        public void Multiply(int multiplier)
        {
            this.integerPlaceholder *= multiplier;
        }

        public void Devide(int devisor)
        {
            this.integerPlaceholder /= devisor;
        }
    }
}
