namespace Task3
{
    using System.IO;

    class LineNumbers
    {
        static void Main()
        {
            using (var writerHelper = new StreamWriter("Helper.txt"))
            {
                writerHelper.WriteLine("Lorem ipsum dolor sit amet, quod impedit ut pro.\nStet habeo paulo vix an.\nEa eros nemore nam, et sea meis pertinax inciderint, has altera persius corpora cu.\nPro ne exerci everti constituam, quo affert legere aliquando an, eos eros convenire ut.");
            }

            using (var writerLineNumber = new StreamWriter("LineNumber.txt"))
            {
                var readerHelper = new StreamReader("Helper.txt");
                int rowCounter = 1;
                while (!readerHelper.EndOfStream)
                {
                    writerLineNumber.WriteLine(rowCounter++ + ". " + readerHelper.ReadLine());
                }
                readerHelper.Close();
                File.Delete("Helper.txt");
            }
        }
    }
}
