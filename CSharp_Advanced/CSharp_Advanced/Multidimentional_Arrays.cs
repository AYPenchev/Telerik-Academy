using System;
using System.Linq;

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

                    for (int i = 0, countA = 1; i < n; i++, countA++)
                    {
                        for (int j = 0; j < n; j++, countA++)
                        {
                            matrix[j, i] = countA;
                        }
                        countA--;
                    }

                    break;

                case 'b':

                    for (int i = 0, countB = 1; i < n; i++, countB++)
                    {
                        for (int j = 0; j < n; j++, countB++)
                        {
                            if (i % 2 == 0)
                            {
                                matrix[j, i] = countB;
                            }
                            else
                            {
                                matrix[n - 1 - j, i] = countB;
                            }
                        }
                        countB--;
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
                    int leftColumn = 0;
                    int rightColumn = n - 1;
                    int upperRow = 0;
                    int bottomRow = n - 1;
                    int count = 1;

                    do
                    {
                        for (int i = upperRow; i <= bottomRow; i++)
                        {
                            matrix[i, leftColumn] = count;
                            count++;
                        }

                        leftColumn++;

                        for (int i = leftColumn; i <= rightColumn; i++)
                        {
                            matrix[bottomRow, i] = count;
                            count++;
                        }

                        bottomRow--;

                        for (int i = bottomRow; i >= upperRow; i--)
                        {
                            matrix[i, rightColumn] = count;
                            count++;
                        }

                        rightColumn--;

                        for (int i = rightColumn; i >= leftColumn; i--)
                        {
                            matrix[upperRow, i] = count;
                            count++;
                        }

                        upperRow++;

                    } while (count <= n * n);

                    break;

                default:
                    break;
            }
            PrintMatrix(matrix, n, n);
        }

        private static void PrintMatrix(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
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

        private static void FillMatrix(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private static void MaximalSum02()
        {
            Console.WriteLine("Enter size n - rows of the matrix and size m - columns of the matrix: ");
            int[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => int.Parse(item))
                    .ToArray();

            int n = numbers[0];
            int m = numbers[1];
            
            int[,] matrix = new int[n, m];
            Console.WriteLine("Enter elements:");

            FillMatrix(matrix, n, m);
            PrintMatrix(matrix, n, m);

            if(n >= 3 && m >= 3)
            {
                int row = 0;
                int column = 0;
                int maxSum = 0;
                int currentSum = 0;

                while(row + 2 < n && column + 2 < m)
                {
                    for (int i = row; i <= row + 2; i++)
                    {
                        for (int j = column; j <= column + 2; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                    }
                    row++;

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;

                    if (row + 2 >= n)
                    {
                        row = 0;
                        column++;
                    }
                }
                Console.WriteLine(maxSum);
            }
            
        }


        static void Main()
        {
            //FillTheMatrix01();
            //MaximalSum02();
        }
    }
}
