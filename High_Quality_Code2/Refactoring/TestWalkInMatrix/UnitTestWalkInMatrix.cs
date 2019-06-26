namespace TestWalkInMatrix
{
    using Task1;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestWalkInMatrix
    {
        [TestMethod]
        public void MitrixCannotNullOrHaveCellWithValueZero()
        {
            for (int row = 0; row < WalkInMatrix.MatrixSize; row++)
            {
                for (int column = 0; column < WalkInMatrix.MatrixSize; column++)
                {
                    Assert.IsTrue(WalkInMatrix.Matrix == null || WalkInMatrix.Matrix[row, column] == 0);
                }
            }         
        }
    }
}
