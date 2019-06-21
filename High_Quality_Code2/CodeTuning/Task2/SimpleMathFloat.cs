namespace Task2
{
    public class SimpleMathFloat : ISimpleMathable<float>
    {
        private float floatPlaceholder = 0;

        public void Add(float addend)
        {
            this.floatPlaceholder += addend;
        }

        public void Substract(float minuend)
        {
            this.floatPlaceholder -= minuend;
        }

        public void Increment()
        {
            this.floatPlaceholder++;
        }

        public void Multiply(float multiplier)
        {
            this.floatPlaceholder *= multiplier;
        }

        public void Devide(float devisor)
        {
            this.floatPlaceholder /= devisor;
        }
    }
}
