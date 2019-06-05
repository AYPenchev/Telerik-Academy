namespace Task5
{
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64()
        {
            this.Bits = new List<ulong>(10);

            for (int i = 1; i <= this.Bits.Capacity; i++)
            {
                this.Bits.Add((ulong)i);
            }
        }
        public BitArray64(List<ulong> bits)
        {
            this.Bits = bits;
        }

        public List<ulong> Bits { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Bits.Count; i++)
            {
                yield return (int)this.Bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var otherStudent = (BitArray64)obj;
            bool areEqual = true;

            for (int i = 0; i < this.Bits.Count; i++)
            {
                if (this.Bits[i] != otherStudent.Bits[i])
                {
                    areEqual = false;
                    return areEqual;
                }
            }

            return areEqual;
        }

        public override int GetHashCode()
        {
            int hashCode = this.Bits[0].GetHashCode();

            for (int i = 1; i < this.Bits.Count; i++)
            {
                hashCode ^= this.Bits[i].GetHashCode();
            }

            return hashCode;
        }

        public static bool operator ==(BitArray64 firstStudent, BitArray64 secondStudent)
        {
            return BitArray64.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(BitArray64 firstStudent, BitArray64 secondStudent)
        {
            return !BitArray64.Equals(firstStudent, secondStudent);
        }


        public ulong this[uint index]
        {
            get
            {
                return this.Bits[(int)index];
            }
            set
            {
                this.Bits[(int)index] = value;
            }
        }
    }
}
