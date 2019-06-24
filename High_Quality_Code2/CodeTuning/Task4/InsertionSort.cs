namespace Task4
{
    using System;

    public class InsertionSort<T>
    where T : IComparable
    {
        void sort(T[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                T key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }
    }
}
