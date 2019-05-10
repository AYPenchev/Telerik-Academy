namespace Task1
{
    using System;
    using System.IO;

    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../Documentation.txt");
            try
            {
                int rowCounter = 1;

                while (!reader.EndOfStream)
                {
                    if(rowCounter % 2 != 0)
                    {
                        Console.WriteLine(reader.ReadLine());
                        rowCounter++;
                    }
                    reader.ReadLine();
                    rowCounter++;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The chosen file is not supported!");
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
