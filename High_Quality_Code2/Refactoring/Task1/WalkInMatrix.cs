namespace Task1
{
    using System;
    using System.Data;

    public class WalkInMatrix
    {
        private static bool isMatrixSizeNotSetYet = true;
        private static int matrixSize = GetInputForMatrixSize();
        private static int[,] matrix = new int[matrixSize, matrixSize];
        private static int filler = 1;
        private static int rowIdx = 0;
        private static int columnIdx = 0;
        private static int xDirection = 1;
        private static int yDirection = 1;

        // Somthing like Singleton design pattern
        public static int MatrixSize
        {
            get
            {
                return matrixSize;
            }

            set
            {
                if (isMatrixSizeNotSetYet)
                {
                    matrixSize = value;
                    isMatrixSizeNotSetYet = false;
                }
                else
                {
                    throw new ConstraintException("Matrix size can be set only one time!");
                }
            }
        }

        public static int[,] Matrix { get; private set; }

        public static void Main()
        {
            WalkingAlogrithm();
            FindCellCoordinates(matrix);
            if (rowIdx != 0 && columnIdx != 0)
            {
                xDirection = 1;
                yDirection = 1;
                filler++;

                WalkingAlogrithm();
            }

            PrintMatrix(matrix, matrixSize);
        }

        public static void WalkingAlogrithm()
        {
            while (IsThereNextStep(matrix, rowIdx, columnIdx))
            {
                matrix[rowIdx, columnIdx] = filler;
                if (IsThereNextStep(matrix, rowIdx, columnIdx))
                {
                    while (IsNextStepOutOfRange())
                    {
                        ChangeDirection();
                    }
                }

                rowIdx += xDirection;
                columnIdx += yDirection;
                filler++;
                if (!IsThereNextStep(matrix, rowIdx, columnIdx) && matrix[rowIdx, columnIdx] == 0)
                {
                    matrix[rowIdx, columnIdx] = filler;
                }
            }
        }

        public static void FindCellCoordinates(int[,] arr)
        {
            rowIdx = 0;
            columnIdx = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        rowIdx = i;
                        columnIdx = j;
                        return;
                    }
                }
            }
        }

        public static void PrintMatrix(int[,] matrix, int matrixSize)
        {
            for (int rowIdx = 0; rowIdx < matrixSize; rowIdx++)
            {
                for (int columnIdx = 0; columnIdx < matrixSize; columnIdx++)
                {
                    Console.Write("{0,3}", matrix[rowIdx, columnIdx]);
                }

                Console.WriteLine();
            }
        }

        private static int GetInputForMatrixSize()
        {
            MatrixSize = int.Parse(Console.ReadLine());
            if (MatrixSize < 1)
            {
                throw new ArgumentOutOfRangeException("Matrix size cannot be less than 3!");
            }

            return MatrixSize;
        }

        private static void ChangeDirection()
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int changeDirction = 0;
            for (int count = 0; count < directionX.Length; count++)
            {
                if (directionX[count] == xDirection && directionY[count] == yDirection)
                {
                    changeDirction = count;
                    break;
                }
            }

            if (changeDirction == 7)
            {
                xDirection = directionX[0];
                yDirection = directionY[0];
                return;
            }

            xDirection = directionX[changeDirction + 1];
            yDirection = directionY[changeDirction + 1];
        }

        private static bool IsThereNextStep(int[,] arr, int x, int y)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < directionX.Length; i++)
            {
                if (x + directionX[i] >= arr.GetLength(0) || x + directionX[i] < 0)
                {
                    directionX[i] = 0;
                }

                if (y + directionY[i] >= arr.GetLength(0) || y + directionY[i] < 0)
                {
                    directionY[i] = 0;
                }
            }

            for (int i = 0; i < directionX.Length; i++)
            {
                if (arr[x + directionX[i], y + directionY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsOverflowingIndexAndXDirection(int rowIndex, int xDirection, int matrixSize)
        {
            return rowIndex + xDirection >= matrixSize;
        }

        private static bool IsUnderflowingIndexAndXDirection(int rowIndex, int xDirection)
        {
            return rowIndex + xDirection < 0;
        }

        private static bool IsOverflowingIndexAndYDirection(int columnIndex, int yDirection, int matrixSize)
        {
            return columnIndex + yDirection >= matrixSize;
        }

        private static bool IsUnderflowingIndexAndYDirection(int columnIndex, int yDirection)
        {
            return columnIndex + yDirection < 0;
        }

        private static bool ValidateNextStep(int rowIndex, int columnIndex, int xDirection, int yDirection, int[,] matrix)
        {
            return matrix[rowIndex + xDirection, columnIndex + yDirection] != 0;
        }

        private static bool IsNextStepOutOfRange()
        {
            return IsOverflowingIndexAndXDirection(rowIdx, xDirection, matrixSize) ||
                   IsUnderflowingIndexAndXDirection(rowIdx, xDirection) ||
                   IsOverflowingIndexAndYDirection(columnIdx, yDirection, matrixSize) ||
                   IsUnderflowingIndexAndYDirection(columnIdx, yDirection) ||
                   ValidateNextStep(rowIdx, columnIdx, xDirection, yDirection, matrix);
        }
    }
}
