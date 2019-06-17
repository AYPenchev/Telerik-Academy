namespace Task9
{
    using System;
    using System.IO;
    using System.Text;

    public class DeleteOddLines
    {
        public static void Main()
        {
            using (var firstWriteStream = new StreamWriter("../../DeleteOddLines.txt"))
            {
                for (int i = 1; i <= 10; i++)
                {
                    firstWriteStream.WriteLine(i);
                }
            }

            StringBuilder content = new StringBuilder();

            using (var reader = new StreamReader("../../DeleteOddLines.txt"))
            {
                int rowCounter = 1;

                while (!reader.EndOfStream)
                {
                    if (rowCounter % 2 == 0)
                    {
                        content.Append(reader.ReadLine() + Environment.NewLine);
                        rowCounter++;
                    }

                    reader.ReadLine();
                    rowCounter++;
                }
            }

            using (var secondWriteStream = new StreamWriter("../../DeleteOddLines.txt"))
            {
                secondWriteStream.WriteLine(content);
            }
        }
    }
}
