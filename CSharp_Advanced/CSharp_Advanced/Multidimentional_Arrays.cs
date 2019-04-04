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

        private static void PrintMatrix(int[,] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
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

        private static void FillMatrix(int[,] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
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

            if (n >= 3 && m >= 3)
            {
                int row = 0;
                int column = 0;
                int maxSum = 0;
                int currentSum = 0;

                while (row + 2 < n && column + 2 < m)
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

        private static void SequenceInMatrix03()
        {
            Console.WriteLine("Enter size n - rows of the matrix and size m - columns of the matrix: ");
            int[] numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(item => int.Parse(item))
                    .ToArray();

            int n = numbers[0];
            int m = numbers[1];

            string[,] matrix = new string[n, m];
            /*{ { 92, 11, 23, 42, 59, 48 },
              { 09, 92, 23, 72, 48, 14 },
              { 17, 63, 92, 48, 85, 95 },
              { 34, 12, 48, 92, 23, 95 },
              { 26, 48, 78, 71, 92, 95 },
              { 48, 34, 16, 63, 39, 95 }
            };*/

            for (int i = 0; i < n; i++)
            {
                string[] eachRow = Console.ReadLine()
                        .Split(' ')
                        .Select(item => item)
                        .ToArray();

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = eachRow[j];
                }
            }

            int maxSequence = 1;
            int currentSequence = 1;

            //Check each row
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        currentSequence++;
                    }
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
                currentSequence = 1;
            }

            //Check each column
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (matrix[j, i] == matrix[j + 1, i])
                    {
                        currentSequence++;
                    }
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
                currentSequence = 1;
            }

            //Check main diagonal
            for (int i = 0; i < m - 1; i++)
            {

                if (matrix[i, i] == matrix[i + 1, i + 1])
                {
                    currentSequence++;
                }

            }
            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }
            currentSequence = 1;

            //Check secondary diagonal
            for (int i = 0, j = m - 1; i < n - 1 && j >= 1; i++, j--)
            {
                if (matrix[i, j] == matrix[i + 1, j - 1])
                {
                    currentSequence++;
                }
            }
            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }
            Console.WriteLine(maxSequence);
        }

        //this function returns the index of the largest number in the array which is <= k
        private static void BinarySearch04()
        {
            Console.Write("Enter length for array: ");
            int n = int.Parse(Console.ReadLine());

            int[] binSearchArray = new int[n];

            Console.WriteLine("Enter elements for the created array: ");
            for (int i = 0; i < n; i++)
            {
                binSearchArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            Array.Sort(binSearchArray);
            int indexOfNumBeingSearched = Array.BinarySearch(binSearchArray, k);

            if (indexOfNumBeingSearched >= 0)
            {
                Console.WriteLine(indexOfNumBeingSearched);
            }
            else if (binSearchArray[n - 1] < k)
            {
                Console.WriteLine(n - 1);
            }
            else
            {
                Console.WriteLine("There is no such element.");
            }
        }

        private static void SortByStringLength05()
        {
            string[] matrix = { "9266", "11", "237" };
            int matrixLength = matrix.Length;
            //Array.Sort(matrix); also works

            Console.WriteLine("Not sorted");
            for (int i = 0; i < matrixLength; i++)
            {
                Console.WriteLine(matrix[i]);
            }

            for (int i = 0; i < matrixLength - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < matrixLength; j++)
                {
                    if (matrix[j].Length < matrix[min_idx].Length)
                    {
                        min_idx = j;
                    }
                }

                string temp = matrix[min_idx];
                matrix[min_idx] = matrix[i];
                matrix[i] = temp;
            }

            Console.WriteLine("Sorted");
            for (int i = 0; i < matrixLength; i++)
            {
                Console.WriteLine(matrix[i]);
            }

        }

        //Description Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
        class MatrixClass06
        {
            private int[,] matrix;   // matr

            public static MatrixClass06 operator +(MatrixClass06 addend1, MatrixClass06 addend2)
            {
                MatrixClass06 matrixSum = new MatrixClass06();
                
                return matrixSum;
            }
        }

        private static void LargestAreaInMatrix07()
        {

        }

        static void Main()
        {
            /*
            FillTheMatrix01();
            MaximalSum02();
            SequenceInMatrix03();
            BinarySearch04();
            SortByStringLength05();
            */
            MatrixClass06 matr1;
        }
    }
}