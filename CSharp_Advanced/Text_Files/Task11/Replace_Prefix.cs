namespace Task11
{
    using System;
    using System.IO;

    public class ReplacePrefix
    {
        public static void Main()
        {
            using (var writer = new StreamWriter("largeFile.txt"))
            {
                Random randNumGenerator = new Random();
                for (int i = 1; i <= 1000; i++)
                {
                    int randNum = randNumGenerator.Next(1, 4);
                    switch (randNum)
                    {
                        case 1:
                            writer.Write("test");
                            break;
                        case 2:
                            writer.Write("Begin");
                            break;
                        case 3:
                            writer.Write("last_");
                            break;
                    }

                    if (i % 2 == 0)
                    {
                        writer.Write(" ");
                    }

                    if (i % 3 == 0)
                    {
                        writer.WriteLine();
                    }
                }
            }

            using (var writer = new StreamWriter("newFile.txt"))
            {
                string[] content = File.ReadAllText("largeFile.txt").Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < content.Length; i++)
                {
                    if (content[i].StartsWith("test") && content[i].Length > 4)
                    {
                        content[i] = content[i].Remove(0, 4);
                    }

                    if (i % 2 == 0 && i != 0)
                    {
                        content[i] = Environment.NewLine + content[i];
                    }
                }

                writer.WriteLine(string.Join(" ", content));
            } 
        }
    }
}
