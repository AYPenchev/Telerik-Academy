﻿namespace Task8
{
    using System;
    using System.IO;
    class ReplaceWholeWord
    {
        static void Main()
        {
            using (var writer = new StreamWriter("largeFile.txt"))
            {
                Random randNumGenerator = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    int randNum = randNumGenerator.Next(1, 4);
                    switch (randNum)
                    {
                        case 1:
                            writer.WriteLine("start");
                            break;
                        case 2:
                            writer.WriteLine("begin");
                            break;
                        case 3:
                            writer.WriteLine("last");
                            break;
                    }
                }
            }

            using (var reader = new StreamReader("largeFile.txt"))
            {
                var writer = new StreamWriter("newFile.txt");

                while (!reader.EndOfStream)
                {
                    string content = reader.ReadLine();
                    if (content.Contains("start"))
                    {
                        writer.WriteLine(content.Replace("start", "finish"));
                    }
                    else
                    {
                        writer.WriteLine(content);
                    }
                }
                writer.Close();
            }
        }
    }
}
