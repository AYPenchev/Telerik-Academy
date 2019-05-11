namespace Task6
{
    using System;
    using System.IO;
    using System.Linq;

    class SaveSortedNames
    {
        static void Main()
        {
            using (var writerToInputFile = new StreamWriter("input.txt"))
            {
                writerToInputFile.WriteLine("Ivan");
                writerToInputFile.WriteLine("Peter");
                writerToInputFile.WriteLine("Maria");
                writerToInputFile.WriteLine("George");
            }

            string[] arrayNames = File.ReadAllText("input.txt")
                                .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(item => item)
                                .ToArray();

            Array.Sort(arrayNames);

            File.WriteAllLines("output.txt", arrayNames);
        }
    }
}
