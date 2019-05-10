namespace Task2
{
    using System;
    using System.IO;
    using System.Text;

    class ConcatenateTextFiles
    {
        static void Main()
        {
            StreamWriter writerFirstFile = new StreamWriter("firstTextFile.txt");
            writerFirstFile.WriteLine("Lorem Ipsum is simply dummy text of the printing and typesetting industry.\nLorem Ipsum has been the industry's standard dummy text ever since the 1500s,\nwhen an unknown printer took a galley of type and scrambled it to make a type specimen book.");
            writerFirstFile.Close();

            StreamWriter writerSecondFile = new StreamWriter("secondTextFile.txt");
            writerSecondFile.WriteLine("It is a long established fact that a reader will be distracted by the readable content of a page\nwhen looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution\nof letters, as opposed to using 'Content here, content here', making it look like readable English.");
            writerSecondFile.Close();

            using (StreamWriter writerAppendFile = new StreamWriter("appendFile.txt", true, Encoding.UTF8))
            {
                StreamReader readerFirstFile = new StreamReader("firstTextFile.txt");
                while (!readerFirstFile.EndOfStream)
                {
                    writerAppendFile.WriteLine(readerFirstFile.ReadLine());
                }
                readerFirstFile.Close();

                StreamReader readerSecondFile = new StreamReader("secondTextFile.txt");
                while (!readerSecondFile.EndOfStream)
                {
                    writerAppendFile.WriteLine(readerSecondFile.ReadLine());
                }
                readerSecondFile.Close();
            }
        }
    }
}
