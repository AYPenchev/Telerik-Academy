namespace Task4
{
    using System;

    public static class PrintUtils<T>
    {
        public static void PrintArray(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
