namespace Task1
{
    using System;
    using System.Text;

    class GenericList<T>
        where T : IComparable
    {
        private T[] elements;
        private int capacity;

        public GenericList()
        {
            this.Count = 0;
            this.Capacity = 8;
            this.elements = new T[this.Capacity];
        }

        public T[] Elements { get; private set; }
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public void AddAtEnd(T element)
        {
            if(this.Capacity == this.Count)
            {
                this.Expand();
            }
            elements[this.Count] = element;
            Count++;
        }

        public void AddAt(int index, T element)
        {
            if (this.Capacity == this.Count)
            {
                this.Expand();
            }
            for (int i = this.Count; i >= index; i--)
            {
                elements[i + 1] = elements[i];
            }
            elements[index] = element;
            Count++;
        }

        public void RemoveFirst(T item)
        {
            int index = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if(this.elements[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.Count - 1] = default(T);

            this.Count--;
        }

        public void Clear()
        {
            while (this.Count - 1 >= 0)
            {
                RemoveAt(this.Count - 1);
            }
        }

        public T this[int index]
        {
            get { return this.elements[index]; }
            set { this.elements[index] = value; }
        }

        private void Expand()
        {
            this.Capacity *= 2;
            T[] expandedArray = new T[this.Capacity];
            for (int i = 0; i < elements.Length; i++)
            {
                expandedArray[i] = elements[i];
            }
            this.elements = expandedArray;
        }

        public int GetElementIndex(T element)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                result.Append(this.elements[i]);

                if (i != this.Count - 1)
                {
                    result.Append(" -> ");
                }
            }
            return result.ToString();
        }
    }
}
