namespace Task25
{
    using System;
    using System.Text;

    class ExtractTextHTML
    {
        static void Main()
        {
            string htmlCode = @"<html>
          <head><title>News</title></head>
          <body><p><a href=""http://academy.telerik.com"">Telerik
            Academy</a>aims to provide free real-world practical
            training for young people who want to turn into
            skilful .NET software engineers.</p></body>
        </html>";

            StringBuilder extractedText = new StringBuilder();

            for (int i = 0; i < htmlCode.Length; i++)
            {
                if (htmlCode[i] == '<')
                {
                    extractedText.Append(" ");

                    while (htmlCode[i] != '>')
                    {
                        i++;
                    }

                    continue;
                }

                extractedText.Append(htmlCode[i]);
            }

            string[] output = extractedText.ToString()
                .Split(new string[] { " ", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                //.ToArray();

            Console.WriteLine("Title: {0}", output[0]);

            Console.Write("Text: ");
            for (int i = 1; i < output.Length; i++)
            {
                if (i != output.Length - 1)
                {
                    Console.Write(output[i] + " ");
                }
                else
                {
                    Console.Write(output[i]);
                }
            }

            Console.WriteLine();




            //string inputHTML = Console.ReadLine();

            //string text = inputHTML.Remove(0, inputHTML. IndexOf("<tittle>") + 8);

            //text = text.Remove(text.IndexOf("</tittle>"));
            //Console.WriteLine("Tittle: " + text);

            
        }
    }
}
