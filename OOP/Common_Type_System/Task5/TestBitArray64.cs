namespace Task5
{
    using System;

    public class TestBitArray64
    {
        static void Main()
        {
            BitArray64 bitsHolder = new BitArray64();

            foreach (ulong bit in bitsHolder)
            {
                Console.WriteLine(bit);
            }

            BitArray64 secondBitsHolder = new BitArray64();

            Console.WriteLine(bitsHolder.Equals(secondBitsHolder));

            bitsHolder[0] = 10;

            Console.WriteLine(bitsHolder == secondBitsHolder);
        }
    }
}
