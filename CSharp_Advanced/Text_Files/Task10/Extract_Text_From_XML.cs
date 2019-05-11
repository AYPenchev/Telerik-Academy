namespace Task10
{
    using System;
    using System.IO;
    using System.Text;

    class ExtractTextFromXML
    {
        static void Main()
        {
            StringBuilder textContent = new StringBuilder();
            StringBuilder xmlCode = new StringBuilder();

            using (var readXML = new StreamReader("../../ExtractTextFrom.xml"))
            {
                while (!readXML.EndOfStream)
                {
                    xmlCode.Append(readXML.ReadLine());
                }
            }

            for (int i = 0; i < xmlCode.Length; i++)
            {
                if (xmlCode[i] == '<')
                { 
                    while (xmlCode[i] != '>')
                    {
                        i++;
                    }
                    continue;
                }

                textContent.Append(xmlCode[i]);
            }

            string extractedText = textContent.ToString();
            string[] extractedTextAsArray = extractedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            extractedText = string.Join(" ", extractedTextAsArray);
            Console.WriteLine(extractedText);
        }
    }
}
