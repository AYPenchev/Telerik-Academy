namespace Task3
{
    using System;

    public class InvalidRangeException<T> : Exception
    {
        public readonly T Start;
        public readonly T End;

        public InvalidRangeException(T start, T end, string message) : base(message)
        {
            this.Start = start;
            this.End = end;
        }

        public override string Message { get; }
    }
}
