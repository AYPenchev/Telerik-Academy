namespace Task2
{
    public interface ISimpleMathable<T>
    {
        void Add(T addend);

        void Substract(T minuend);

        void Increment();

        void Multiply(T multiplier);

        void Devide(T devisor);
    }
}
