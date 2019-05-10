namespace Task4
{
    using System;
    using System.IO;

    class CompareTextFiles
    {
        static void Main()
        {
            using (var writerFirstFile = new StreamWriter("firstFile.txt"))
            {
                writerFirstFile.WriteLine("Lorem ipsum dolor sit amet, quod impedit ut pro.\nStet habeo paulo vix an.\nEa eros nemore nam, et sea meis pertinax inciderint, has altera persius corpora cu.\nPro ne exerci everti constituam, quo affert legere aliquando an, eos eros convenire ut.");
            }

            using (var writerSecondFile = new StreamWriter("secondFile.txt"))
            {
                writerSecondFile.WriteLine("Lorem ipsum dolor sit amet, quod impedit ut pro.\nStet habeo paulo vix an.\nDonec sodales sagittis magna.\nQuisque rutrum.");
            }

            var readerFirstFile = new StreamReader("firstFile.txt");
            var readerSecondFile = new StreamReader("secondFile.txt");

            int countEqualLines = 0;
            int countDiffLines = 0;

            //no need to check the end of second file because we assume the files have equal number of lines.
            while (!readerFirstFile.EndOfStream)
            {
                if (readerFirstFile.ReadLine() == readerSecondFile.ReadLine())
                {
                    countEqualLines++;
                }
                else
                {
                    countDiffLines++;
                }
            }

            readerFirstFile.Close();
            readerSecondFile.Close();

            Console.WriteLine("Equal lines: {0}" + Environment.NewLine + "Different lines: {1}", countEqualLines, countDiffLines);

        }
    }
}
