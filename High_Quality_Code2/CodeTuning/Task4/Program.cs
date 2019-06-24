namespace Task4
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            QuickSort(arr, 0, n - 1);
            Console.WriteLine("sorted array ");
            PrintUtils<int>.PrintArray(arr);
        }
    }
}
