namespace Task5
{
    using System;
    using System.Linq;
    using System.IO;

    class MaximalAreaSum
    {
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
                int[] fillMatrixRows = Console.ReadLine()
                        .Split(new char[] { ' ' }, columns, StringSplitOptions.RemoveEmptyEntries)
                        .Select(item => int.Parse(item))
                        .ToArray();

                for (int j = 0; j < fillMatrixRows.Length; j++)
                {
                    matrix[i, j] = fillMatrixRows[j];
                }
            }
        }

        private static void WriteMatrixToFile(int[,] matrix)
        {
            using (var writerMatrixToFile = new StreamWriter("MatrixFile.txt"))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j  = 0; j < matrix.GetLength(1); j++)
                    {
                        writerMatrixToFile.Write(matrix[i, j] + " ");
                    }
                    writerMatrixToFile.WriteLine();
                }

                
            }
        }

        private static int[,] GetMatrixFromFile(string path)
        {
            using (var readerMatrixFromFile = new StreamReader(path))
            {
                int[,] matrix;
                int countSizeOfMatrix = 0;
                while (!readerMatrixFromFile.EndOfStream)
                {
                    countSizeOfMatrix++;
                    readerMatrixFromFile.ReadLine();
                }

                matrix = new int[countSizeOfMatrix, countSizeOfMatrix];

                readerMatrixFromFile.BaseStream.Position = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int[] fillMatrixRows = readerMatrixFromFile.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(item => int.Parse(item))
                            .ToArray();

                    for (int j = 0; j < fillMatrixRows.Length; j++)
                    {
                        matrix[i, j] = fillMatrixRows[j];
                    }
                }
                return matrix;
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter size n - for square matrix: ");
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];
            Console.WriteLine("Enter elements:");

            FillMatrix(matrix, matrixSize, matrixSize);
            PrintMatrix(matrix, matrixSize, matrixSize);

            WriteMatrixToFile(matrix);
            int[,] matrixFromFile = GetMatrixFromFile("MatrixFile.txt");

            if (matrixFromFile.GetLength(0) >= 2)
            {
                int row = 0;
                int column = 0;
                int maxSum = 0;
                int currentSum = 0;

                while (row + 1 < matrixFromFile.GetLength(0) && column + 1 < matrixFromFile.GetLength(0))
                {
                    for (int i = row; i <= row + 1; i++)
                    {
                        for (int j = column; j <= column + 1; j++)
                        {
                            currentSum += matrixFromFile[i, j];
                        }
                    }
                    row++;

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;

                    if (row + 1 >= matrixFromFile.GetLength(0))
                    {
                        row = 0;
                        column++;
                    }
                }

                Console.WriteLine(maxSum);
                using (var writerResult = new StreamWriter("ResultOutput.txt"))
                {
                    writerResult.WriteLine(maxSum);
                }
            }
        }
    }
}
