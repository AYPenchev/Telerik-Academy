using System;
using System.Collections.Generic;
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

        class MatrixClass06
        {
            private int rows;
            private int cols;
            private int[,] matrix;

            public MatrixClass06(int numberOfRows, int numberOfCols)
            {
                SetRows(numberOfRows);
                SetCols(numberOfCols);
                matrix = new int[rows, cols];
                int fillingMatrix = 1;

                for (int i = 0; i < GetRows(); i++)
                {
                    for (int j = 0; j < GetCols(); j++)
                    {
                        matrix[i, j] = fillingMatrix;
                        fillingMatrix++;
                    }
                }
            }

            public static MatrixClass06 operator +(MatrixClass06 addend1, MatrixClass06 addend2)
            {
                MatrixClass06 matrixSumm = new MatrixClass06(3, 3);

                for (int i = 0; i < matrixSumm.GetRows(); i++)
                {
                    for (int j = 0; j < matrixSumm.GetCols(); j++)
                    {
                        matrixSumm.matrix[i, j] = addend1.matrix[i, j] + addend2.matrix[i, j];
                    }
                }

                return matrixSumm;
            }

            public static MatrixClass06 operator -(MatrixClass06 minuend, MatrixClass06 subtrahend)
            {
                MatrixClass06 matrixDifference = new MatrixClass06(3, 3);

                for (int i = 0; i < matrixDifference.GetRows(); i++)
                {
                    for (int j = 0; j < matrixDifference.GetCols(); j++)
                    {
                        matrixDifference.matrix[i, j] = minuend.matrix[i, j] - subtrahend.matrix[i, j];
                    }
                }

                return matrixDifference;
            }

            public static MatrixClass06 operator *(MatrixClass06 multiplyable1, MatrixClass06 multiplyable2)
            {
                MatrixClass06 matrixProduct = new MatrixClass06(3, 3);

                for (int i = 0; i < matrixProduct.GetRows(); i++)
                {
                    for (int j = 0; j < matrixProduct.GetCols(); j++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (j == 0)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j] * multiplyable2.matrix[i, j] + multiplyable1.matrix[i, j + 1] * multiplyable2.matrix[i + 1, j] +
                                                        multiplyable1.matrix[i, j + 2] * multiplyable2.matrix[i + 2, j];
                                }
                                else if (j == 1)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j - 1] * multiplyable2.matrix[i, j] + multiplyable1.matrix[i, j] * multiplyable2.matrix[i + 1, j] +
                                                        multiplyable1.matrix[i, j + 1] * multiplyable2.matrix[i + 2, j];
                                }
                                else if (j == 2)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j - 2] * multiplyable2.matrix[i, j] + multiplyable1.matrix[i, j - 1] * multiplyable2.matrix[i + 1, j] +
                                                        multiplyable1.matrix[i, j] * multiplyable2.matrix[i + 2, j];
                                }
                                break;
                            case 1:
                                if (j == 0)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j] * multiplyable2.matrix[i - 1, j] + multiplyable1.matrix[i, j + 1] * multiplyable2.matrix[i, j] +
                                                       multiplyable1.matrix[i, j + 2] * multiplyable2.matrix[i + 1, j];
                                }
                                else if (j == 1)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j - 1] * multiplyable2.matrix[i - 1, j] + multiplyable1.matrix[i, j] * multiplyable2.matrix[i, j] +
                                                      multiplyable1.matrix[i, j + 1] * multiplyable2.matrix[i + 1, j];
                                }
                                else if (j == 2)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j - 2] * multiplyable2.matrix[i - 1, j] + multiplyable1.matrix[i, j - 1] * multiplyable2.matrix[i, j] +
                                                multiplyable1.matrix[i, j] * multiplyable2.matrix[i + 1, j];
                                }
                                break;
                            case 2:
                                if (j == 0)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j] * multiplyable2.matrix[i - 2, j] + multiplyable1.matrix[i, j + 1] * multiplyable2.matrix[i - 1, j] +
                                                       multiplyable1.matrix[i, j + 2] * multiplyable2.matrix[i, j];
                                }
                                else if (j == 1)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j - 1] * multiplyable2.matrix[i - 2, j] + multiplyable1.matrix[i, j] * multiplyable2.matrix[i - 1, j] +
                                                      multiplyable1.matrix[i, j + 1] * multiplyable2.matrix[i, j];
                                }
                                else if (j == 2)
                                {
                                    matrixProduct.matrix[i, j] = multiplyable1.matrix[i, j - 2] * multiplyable2.matrix[i - 2, j] + multiplyable1.matrix[i, j - 1] * multiplyable2.matrix[i - 1, j] +
                                                multiplyable1.matrix[i, j] * multiplyable2.matrix[i, j];
                                }
                                break;
                            default:
                                break;
                        }

                    }
                }

                return matrixProduct;
            }

            public override string ToString()
            {
                string matrixToString = "";

                for (int i = 0; i < GetRows(); i++)
                {
                    for (int j = 0; j < GetCols(); j++)
                    {
                        matrixToString += GetMatrix()[i, j] + " ";
                    }
                }

                return matrixToString;
            }

            public int GetRows()
            {
                return this.rows;
            }

            public void SetRows(int rows)
            {
                this.rows = rows;
            }

            public int GetCols()
            {
                return this.cols;
            }

            public void SetCols(int cols)
            {
                this.cols = cols;
            }

            public int[,] GetMatrix()
            {
                return this.matrix;
            }

            public void SetMatrix(int[,] matrix)
            {
                this.matrix = matrix;
            }
        }

        class LargestAreaInMatrix
        {
            //LargestAreaInMatrix07();
            static int[,] matrix = new int[,]
            {
                {1, 3, 2, 2, 2, 4},
                {3, 3, 3, 2, 4, 4},
                {4, 3, 1, 2, 3, 3},
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1}
            };

            // logic
            static bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            static int DepthFirstSearch(int row, int col, int value)
            {
                if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
                {
                    return 0;
                }
                if (visited[row, col])
                {
                    return 0;
                }
                if (matrix[row, col] != value)
                {
                    return 0;
                }
                visited[row, col] = true;
                return DepthFirstSearch(row, col + 1, value) + DepthFirstSearch(row, col - 1, value) +
                DepthFirstSearch(row + 1, col, value) + DepthFirstSearch(row - 1, col, value) + 1;
            }

            public static void PrintResult()
            {
                int result = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        result = Math.Max(result, DepthFirstSearch(row, col, matrix[row, col]));
                    }
                }
                Console.WriteLine("\n{0} equal neighbour elements.\n", result);

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        if (matrix[rows, cols] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        Console.Write("{0,2}", matrix[rows, cols]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            /*
            FillTheMatrix01();
            MaximalSum02();
            SequenceInMatrix03();
            BinarySearch04();
            SortByStringLength05();
           
            //Task 6:
 
            MatrixClass06 matrixTest1 = new MatrixClass06(3, 3);
 
            MatrixClass06 matrixTest2 = new MatrixClass06(3, 3);
 
            Console.WriteLine("Sum: ");
            MatrixClass06 matrixSum = new MatrixClass06(3, 3);
            matrixSum = matrixTest1 + matrixTest2;
            PrintMatrix(matrixSum.GetMatrix(), matrixSum.GetRows(), matrixSum.GetCols());
 
            Console.WriteLine("\nSubstraction: ");
            MatrixClass06 matrixDifference = new MatrixClass06(3, 3);
            matrixDifference = matrixTest1 - matrixTest2;
            PrintMatrix(matrixDifference.GetMatrix(), matrixDifference.GetRows(), matrixDifference.GetCols());
 
            Console.WriteLine("\nToString function \n" + matrixSum.ToString());
 
            Console.WriteLine("\nProduct: ");
            MatrixClass06 matrixProduct = new MatrixClass06(3, 3);
            matrixProduct = matrixTest1 * matrixTest2;
            PrintMatrix(matrixProduct.GetMatrix(), matrixProduct.GetRows(), matrixProduct.GetCols());
            */

            //Task 7:
            //LargestAreaInMatrix.PrintResult();
        }
    }
}