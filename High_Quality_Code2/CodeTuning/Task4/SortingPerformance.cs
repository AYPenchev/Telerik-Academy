namespace Task4
{
    using System;
    using System.Diagnostics;

    public class SortingPerformance
    {
        public enum SortingDegree
        {
            Random,
            Sorted,
            Reversed
        }

        public static void GenericArrayInsertionSort<T>(T[] arrayToBeSorted, SortingDegree degree)
            where T : IComparable
        {
            var arrayInsertionSortWatch = new Stopwatch();
            arrayInsertionSortWatch.Start();

            SortUtils<T>.InsertionSort(arrayToBeSorted);
            Console.Write($"{degree} {typeof(T)} array sorted with insertion sort: ");
            PrintUtils<T>.PrintArray(arrayToBeSorted);

            arrayInsertionSortWatch.Stop();
            Console.WriteLine($"{arrayInsertionSortWatch.Elapsed} \n");
        }

        public static void GenericArraySelectionSort<T>(T[] arrayToBeSorted, SortingDegree degree)
            where T : IComparable
        {
            var arraySelectionSortWatch = new Stopwatch();
            arraySelectionSortWatch.Start();

            SortUtils<T>.SelectionSort(arrayToBeSorted);
            Console.Write($"{degree} {typeof(T)} array sorted with selection sort: ");
            PrintUtils<T>.PrintArray(arrayToBeSorted);

            arraySelectionSortWatch.Stop();
            Console.WriteLine($"{arraySelectionSortWatch.Elapsed} \n");
        }

        public static void GenericArrayQuickSort<T>(T[] arrayToBeSorted, SortingDegree degree) 
            where T : IComparable
        {
            var arrayQuickSortWatch = new Stopwatch();
            arrayQuickSortWatch.Start();

            SortUtils<T>.QuickSort(arrayToBeSorted, 0, arrayToBeSorted.Length - 1);
            Console.Write($"{degree} {typeof(T)} array sorted with quick sort: ");
            PrintUtils<T>.PrintArray(arrayToBeSorted);

            arrayQuickSortWatch.Stop();
            Console.WriteLine($"{arrayQuickSortWatch.Elapsed} \n");
        }

        public static void Main()
        {
            Console.WriteLine("Different sorts with different primitive types and degree of sorting - random.");

            int[] randomIntArrayToBeInsertionSorted = { 10, 7, 8, 9, 1, 5 };
            double[] randomDoubleArrayToBeInsertionSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] randomStringArrayToBeInsertionSorted = { "b", "a", "d", "f", "c", "e" };
            int[] randomIntArrayToBeSelectionSorted = { 10, 7, 8, 9, 1, 5 };
            double[] randomDoubleArrayToBeSelectionSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] randomStringArrayToBeSelectionSorted = { "b", "a", "d", "f", "c", "e" };
            int[] randomIntArrayToBeQuickSorted = { 10, 7, 8, 9, 1, 5 };
            double[] randomDoubleArrayToBeQuickSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] randomStringArrayToBeQuickSorted = { "b", "a", "d", "f", "c", "e" };

            GenericArrayInsertionSort(randomIntArrayToBeInsertionSorted, SortingDegree.Random);
            GenericArrayInsertionSort(randomDoubleArrayToBeInsertionSorted, SortingDegree.Random);
            GenericArrayInsertionSort(randomStringArrayToBeInsertionSorted, SortingDegree.Random);
            
            GenericArraySelectionSort(randomIntArrayToBeSelectionSorted, SortingDegree.Random);
            GenericArraySelectionSort(randomDoubleArrayToBeSelectionSorted, SortingDegree.Random);
            GenericArraySelectionSort(randomStringArrayToBeSelectionSorted, SortingDegree.Random);

            GenericArrayQuickSort(randomIntArrayToBeQuickSorted, SortingDegree.Random);
            GenericArrayQuickSort(randomDoubleArrayToBeQuickSorted, SortingDegree.Random);
            GenericArrayQuickSort(randomStringArrayToBeQuickSorted, SortingDegree.Random);

            Console.WriteLine("Different sorts with different primitive types and degree of sorting - sorted.");

            int[] sortedIntArrayToBeInsertionSorted = { 10, 7, 8, 9, 1, 5 };
            double[] sortedDoubleArrayToBeInsertionSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] sortedStringArrayToBeInsertionSorted = { "b", "a", "d", "f", "c", "e" };
            int[] sortedIntArrayToBeSelectionSorted = { 10, 7, 8, 9, 1, 5 };
            double[] sortedDoubleArrayToBeSelectionSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] sortedStringArrayToBeSelectionSorted = { "b", "a", "d", "f", "c", "e" };
            int[] sortedIntArrayToBeQuickSorted = { 10, 7, 8, 9, 1, 5 };
            double[] sortedDoubleArrayToBeQuickSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] sortedStringArrayToBeQuickSorted = { "b", "a", "d", "f", "c", "e" };

            GenericArrayInsertionSort(sortedIntArrayToBeInsertionSorted, SortingDegree.Sorted);
            GenericArrayInsertionSort(sortedDoubleArrayToBeInsertionSorted, SortingDegree.Sorted);
            GenericArrayInsertionSort(sortedStringArrayToBeInsertionSorted, SortingDegree.Sorted);

            GenericArraySelectionSort(sortedIntArrayToBeSelectionSorted, SortingDegree.Sorted);
            GenericArraySelectionSort(sortedDoubleArrayToBeSelectionSorted, SortingDegree.Sorted);
            GenericArraySelectionSort(sortedStringArrayToBeSelectionSorted, SortingDegree.Sorted);

            GenericArrayQuickSort(sortedIntArrayToBeQuickSorted, SortingDegree.Sorted);
            GenericArrayQuickSort(sortedDoubleArrayToBeQuickSorted, SortingDegree.Sorted);
            GenericArrayQuickSort(sortedStringArrayToBeQuickSorted, SortingDegree.Sorted);

            Console.WriteLine("Different sorts with different primitive types and degree of sorting - reversed.");

            int[] reversedIntArrayToBeInsertionSorted = { 10, 7, 8, 9, 1, 5 };
            double[] reversedDoubleArrayToBeInsertionSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] reversedStringArrayToBeInsertionSorted = { "b", "a", "d", "f", "c", "e" };
            int[] reversedIntArrayToBeSelectionSorted = { 10, 7, 8, 9, 1, 5 };
            double[] reversedDoubleArrayToBeSelectionSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] reversedStringArrayToBeSelectionSorted = { "b", "a", "d", "f", "c", "e" };
            int[] reversedIntArrayToBeQuickSorted = { 10, 7, 8, 9, 1, 5 };
            double[] reversedDoubleArrayToBeQuickSorted = { 10.1, 7.2, 8.3, 9.4, 1.5, 5.6 };
            string[] reversedStringArrayToBeQuickSorted = { "b", "a", "d", "f", "c", "e" };

            GenericArrayInsertionSort(reversedIntArrayToBeInsertionSorted, SortingDegree.Reversed);
            GenericArrayInsertionSort(reversedDoubleArrayToBeInsertionSorted, SortingDegree.Reversed);
            GenericArrayInsertionSort(reversedStringArrayToBeInsertionSorted, SortingDegree.Reversed);

            GenericArraySelectionSort(reversedIntArrayToBeSelectionSorted, SortingDegree.Reversed);
            GenericArraySelectionSort(reversedDoubleArrayToBeSelectionSorted, SortingDegree.Reversed);
            GenericArraySelectionSort(reversedStringArrayToBeSelectionSorted, SortingDegree.Reversed);

            GenericArrayQuickSort(reversedIntArrayToBeQuickSorted, SortingDegree.Reversed);
            GenericArrayQuickSort(reversedDoubleArrayToBeQuickSorted, SortingDegree.Reversed);
            GenericArrayQuickSort(reversedStringArrayToBeQuickSorted, SortingDegree.Reversed);
        }
    }
}
