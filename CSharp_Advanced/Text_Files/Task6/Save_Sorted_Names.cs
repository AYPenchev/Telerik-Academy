namespace Task6
{
    using System;
    using System.IO;
    using System.Linq;

    class SaveSortedNames
    {
        static void Main()
        {
            string[] arrayNames = File.ReadAllText("input.txt")
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(item => item)
                                .ToArray();
            
            Array.Sort(arrayNames);

            File.WriteAllLines("output.txt", arrayNames);
        }
    }
}
