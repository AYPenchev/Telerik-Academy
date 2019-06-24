namespace Task4
{
    using System;

    public static class SortUtils<T>
        where T : IComparable
    {
        /* This function takes last element as pivot, 
         places the pivot element at its correct 
         position in sorted array, and places all 
         smaller (smaller than pivot) to left of 
         pivot and all greater elements to right 
         of pivot */
        private static int Partition(T[] arr, int low, int high)
        {
            T pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j].CompareTo(pivot) <= 0)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    T swapPlaceHolder = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swapPlaceHolder;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            T swapSecondPlaceHoleder = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapSecondPlaceHoleder;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void QuickSort(T[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = Partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public static void SelectionSort(T[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j].CompareTo(arr[min_idx]) < 0)
                    {
                        min_idx = j;
                    }
                }

                // Swap the found minimum element with the first 
                // element 
                T swapPlaceHolder = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = swapPlaceHolder;
            }
        }

        public static void InsertionSort(T[] arr)
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
