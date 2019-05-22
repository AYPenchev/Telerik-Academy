namespace Task1
{
    using System;
    using System.Runtime.InteropServices;

    [Version(Version = "v2")]
    class Matrix<T>
    {
        [Version(Version = "v1.1.2")]
        public int Rows { get; private set; }
        [Version(Version = "v1.0.2")]
        public int Cols { get; private set; }

        public T[,] MatrixArray { get; private set; }

         public Matrix(int numberOfRows, int numberOfCols, params T[] elements)
        {
            if (numberOfRows * numberOfCols != elements.Length && elements.Length != 0)
            {
                throw new ArgumentException();
            }
            this.Rows = numberOfRows;
            this.Cols = numberOfCols;
            this.MatrixArray = new T[Rows, Cols];

            if (elements.Length > 0)
            {
                Buffer.BlockCopy(elements, 0, this.MatrixArray, 0, (int)(Rows * Cols * Marshal.SizeOf(typeof(T))));
            }
        }
        
        public static Matrix<T> operator +(Matrix<T> addend1, Matrix<T> addend2)
        {
            if (addend1.Rows != addend2.Rows || addend1.Cols != addend2.Cols)
            {
                throw new InvalidOperationException("Invalid operation! Matrices must be of one and same size...");
            }

            Matrix<T> matrixSumm = new Matrix<T>(addend1.Rows, addend1.Cols);

            for (uint i = 0; i < matrixSumm.Rows; i++)
            {
                for (uint j = 0; j < matrixSumm.Cols; j++)
                {
                    matrixSumm[i, j] = addend1[i, j] + (dynamic)addend2[i, j];
                }
            }
            return matrixSumm;
        }
        
        public static Matrix<T> operator -(Matrix<T> minuend, Matrix<T> subtrahend)
        {
            if (minuend.Rows != subtrahend.Rows || minuend.Cols != subtrahend.Cols)
            {
                throw new InvalidOperationException("Invalid operation! Matrices must be of one and same size...");
            }

            Matrix<T> matrixDifference = new Matrix<T>(minuend.Rows, minuend.Cols);

            for (int i = 0; i < matrixDifference.Rows; i++)
            {
                for (int j = 0; j < matrixDifference.Cols; j++)
                {
                    matrixDifference.MatrixArray[i, j] = minuend.MatrixArray[i, j] - (dynamic)subtrahend.MatrixArray[i, j];
                }
            }
            return matrixDifference;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Cols);

            for (uint row = 0; row < result.Rows; row++)
            {
                for (uint col = 0; col < result.Cols; col++)
                {
                    for (uint k = 0; k < matrix1.Cols; k++) // or i < matrix2.Rows
                    {
                        result[row, col] += (dynamic)matrix1[row, k] * matrix2[k, col];
                    }
                }
            }
            return result;
        }

        public T this[uint row, uint col]
        {
            get
            {
                return this.MatrixArray[row, col];
            }
            set
            {
                this.MatrixArray[row, col] = value;
            }
        }

        public static bool operator true(Matrix<T> matrix) => matrix != null;
        public static bool operator false(Matrix<T> matrix) => matrix == null;
     
        public override string ToString()
        {
            string matrixToString = "";

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrixToString += MatrixArray[i, j] + " ";
                }
                matrixToString += Environment.NewLine;
            }
            return matrixToString;
        }
    }
}
