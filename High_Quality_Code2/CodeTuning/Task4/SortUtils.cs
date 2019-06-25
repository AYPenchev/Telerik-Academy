namespace Task4
{
    using System;

    public static class SortUtils<T>
        where T : IComparable
    {
        public static void SelectionSort(T[] arr)
        {
            int arrayLength = arr.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (arr[j].CompareTo(arr[min_idx]) < 0)
                    {
                        min_idx = j;
                    }
                }

                T swapPlaceHolder = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = swapPlaceHolder;
            }
        }

        public static void InsertionSort(T[] arr)
        {
            int arrayLength = arr.Length;
            for (int i = 1; i < arrayLength; ++i)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        public static void QuickSort(T[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private static int Partition(T[] arr, int low, int high)
        {
            T pivot = arr[high];

            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j].CompareTo(pivot) <= 0)
                {
                    i++;

                    T swapPlaceHolder = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swapPlaceHolder;
                }
            }

            T swapSecondPlaceHoleder = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapSecondPlaceHoleder;

            return i + 1;
        }
    }
}
