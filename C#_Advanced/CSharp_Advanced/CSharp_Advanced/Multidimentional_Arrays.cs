using System;

namespace CSharp_Advanced
{
    class Multidimentional_Arrays
    {
        private static void FillTheMatrix01()
        {
            Console.WriteLine("Enter size n - size of the matrix: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a, b, c or d to determine how to fill the matrix: ");
            char determineFill = char.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            switch (determineFill)
            {
                case 'a':
                    for (int i = 0, count = 1; i < n; i++, count++)
                    {
                        for (int j = 0; j < n; j++, count++)
                        {
                            matrix[j, i] = count;
                        }
                        count--;
                    }
                    break;
                case 'b':
                    for (int i = 0, count = 1; i < n; i++, count++)
                    {
                        for (int j = 0; j < n; j++, count++)
                        {
                            if (i % 2 == 0)
                            {
                                matrix[j, i] = count;
                            }
                            else
                            {
                                matrix[n - 1 - j, i] = count;
                            }
                        }
                        count--;
                    }
                    break;
                case 'c':
                    int counter = 1;

                    for (int i = n - 1; i >= 0; i--)
                    {
                        int row = i; 
                        int col = 0;

                        do
                        {
                            matrix[row, col] = counter;
                            row++;
                            col++;
                            counter++;
                        } while (row < n);
                    }

                    for (int i = 1; i < n; i++)
                    {
                        int row = 0;
                        int col = i;

                        do
                        {
                            matrix[row, col] = counter;
                            row++;
                            col++;
                            counter++;
                        } while (col < n);
                    }
                    break;
                case 'd':
                    break;
                default:
                    break;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > 9)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            FillTheMatrix01();
        }
    }
}
