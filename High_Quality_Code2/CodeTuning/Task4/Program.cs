using System.Runtime.InteropServices;

namespace Task4
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// How close to sorted an array is. There are three types.
    /// </summary>
    /// <returns> Returns the array degree of sorting </returns>
    delegate string ArrayDegreeOfSorting();

    public class Program
    {
        public static void GenericArrayInsertionSort<T>(T[] arrayToBeSorted)
            where T : IComparable
        {
            var arrayInsertionSortWatch = new Stopwatch();
            arrayInsertionSortWatch.Start();

            SortUtils<T>.InsertionSort(arrayToBeSorted);
            Console.Write($"Reveresed {typeof(T)} array sorted with quick sort: ");
            PrintUtils<T>.PrintArray(arrayToBeSorted);

            arrayInsertionSortWatch.Stop();
            Console.WriteLine($"{arrayInsertionSortWatch.Elapsed} \n");
        }

        public static void GenericArraySelectionSort<T>(T[] arrayToBeSorted)
            where T : IComparable
        {
            var arraySelectionSortWatch = new Stopwatch();
            arraySelectionSortWatch.Start();

            SortUtils<T>.SelectionSort(arrayToBeSorted);
            Console.Write($"Reversed {typeof(T)} array sorted with quick sort: ");
            PrintUtils<T>.PrintArray(arrayToBeSorted);

            arraySelectionSortWatch.Stop();
            Console.WriteLine($"{arraySelectionSortWatch.Elapsed} \n");
        }

        public static void GenericArrayQuickSort<T>(T[] arrayToBeSorted) 
            where T : IComparable
        {
            var arrayQuickSortWatch = new Stopwatch();
            arrayQuickSortWatch.Start();

            SortUtils<T>.QuickSort(arrayToBeSorted, 0, arrayToBeSorted.Length - 1);
            Console.Write($"Reversed {typeof(T)} array sorted with quick sort: ");
            PrintUtils<T>.PrintArray(arrayToBeSorted);

            arrayQuickSortWatch.Stop();
            Console.WriteLine($"{arrayQuickSortWatch.Elapsed} \n");
        }

        public static void Main()
        {
            int[] randomIntArrayToBeSorted = { 10, 7, 8, 9, 1, 5 };
            int[] sortedIntArrayToBeSorted = { 1, 5, 7, 8, 9, 10 };
            int[] reversedIntArrayToBeSorted = { 10, 9, 8, 7, 5, 1 };
            double[] randomDoubleArrayToBeSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            double[] sortedDoubleArrayToBeSorted = { 1.1, 5.2, 7.3, 8.4, 9.5, 10.6 };
            double[] reversedDoubleArrayToBeSorted = { 10.1, 9.2, 8.3, 7.4, 5.5, 1.6 };
            string[] randomStringArrayToBeSorted = { "b", "a", "d", "f", "c", "e" };
            string[] sortedStringArrayToBeSorted = { "a", "b", "c", "d", "e", "f" };
            string[] reversedStringArrayToBeSorted = { "f", "e", "d", "c", "b", "a" };

            Console.WriteLine("Different sorts with different primitive types and degree of sorting - random.");
            ArrayDegreeOfSorting degree = RandomSorted;

            GenericArrayInsertionSort(randomIntArrayToBeSorted);
            GenericArrayInsertionSort(randomDoubleArrayToBeSorted);
            GenericArrayInsertionSort(randomStringArrayToBeSorted);

            GenericArraySelectionSort(randomIntArrayToBeSorted);
            GenericArraySelectionSort(randomDoubleArrayToBeSorted);
            GenericArraySelectionSort(randomStringArrayToBeSorted);

            GenericArrayQuickSort(randomIntArrayToBeSorted);
            GenericArrayQuickSort(randomDoubleArrayToBeSorted);
            GenericArrayQuickSort(randomStringArrayToBeSorted);

            Console.WriteLine("Different sorts with different primitive types and degree of sorting - sorted.");
            degree = FullySorted;

            GenericArrayInsertionSort(sortedIntArrayToBeSorted);
            GenericArrayInsertionSort(sortedDoubleArrayToBeSorted);
            GenericArrayInsertionSort(sortedStringArrayToBeSorted);

            GenericArraySelectionSort(sortedIntArrayToBeSorted);
            GenericArraySelectionSort(sortedDoubleArrayToBeSorted);
            GenericArraySelectionSort(sortedStringArrayToBeSorted);

            GenericArrayQuickSort(sortedIntArrayToBeSorted);
            GenericArrayQuickSort(sortedDoubleArrayToBeSorted);
            GenericArrayQuickSort(sortedStringArrayToBeSorted);

            Console.WriteLine("Different sorts with different primitive types and degree of sorting - reversed.");
            degree = ReversedSorted;

            GenericArrayInsertionSort(reversedIntArrayToBeSorted);
            GenericArrayInsertionSort(reversedDoubleArrayToBeSorted);
            GenericArrayInsertionSort(reversedStringArrayToBeSorted);

            GenericArraySelectionSort(reversedIntArrayToBeSorted);
            GenericArraySelectionSort(reversedDoubleArrayToBeSorted);
            GenericArraySelectionSort(reversedStringArrayToBeSorted);

            GenericArrayQuickSort(reversedIntArrayToBeSorted);
            GenericArrayQuickSort(reversedDoubleArrayToBeSorted);
            GenericArrayQuickSort(reversedStringArrayToBeSorted);
        }

        private static string RandomSorted()
        {
            return "Random ";
        }

        private static string FullySorted()
        {
            return "Sorted ";
        }

        private static string ReversedSorted()
        {
            return "Reversed ";
        }
    }
}
