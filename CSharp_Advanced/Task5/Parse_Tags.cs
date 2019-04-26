namespace Task5
{
    using System;

    class ParseTags
    {
        public static string TagsParse(string text)
        {
            string[] textArray = text.Split(' ');
            for (int i = 0; i < textArray.Length; i++)
            {
                if (textArray[i].Contains("<upcase>"))
                {
                    textArray[i] = textArray[i].Remove(0, 8);

                    if (!textArray[i].Contains("</upcase>"))
                    {
                        textArray[i] = textArray[i].ToUpper();
                    }
                }
                if (textArray[i].Contains("</upcase>"))
                {
                    int removeTagStartPosition = textArray[i].IndexOf("</upcase>");
                    textArray[i] = textArray[i].Remove(removeTagStartPosition, 9);
                    textArray[i] = textArray[i].ToUpper();
                }
            }
            return text = string.Join(" ", textArray);
        }

        static void Main()
        {
            string text = Console.ReadLine();
            string parsedText = TagsParse(text);
            Console.WriteLine(parsedText);
        }
    }
}
