using System;
using System.Collections.Generic;

namespace Task15
{
    class ReplaceTags
    {
        static void Main()
        {
            string inputHTML = Console.ReadLine();
            string replacedHTML = inputHTML;

            while (inputHTML.Contains("<a href=\""))
            {
                string siteKey = inputHTML.Remove(0, inputHTML.IndexOf("<a href=\"") + 9);
                siteKey = siteKey.Remove(siteKey.IndexOf('"'));
                siteKey = "(" + siteKey + ")";

                string textValue = inputHTML.Remove(0, inputHTML.IndexOf("\">") + 2);
                textValue = textValue.Remove(textValue.IndexOf("</a>"));
                textValue = "[" + textValue + "]";

                inputHTML = inputHTML.Remove(0, inputHTML.IndexOf("a>") + 2);

                int startIdx = replacedHTML.IndexOf("<a");
                int lenOfSubstring = replacedHTML.IndexOf("a>") + 2 - replacedHTML.IndexOf("<a");
                replacedHTML = replacedHTML.Replace(replacedHTML.Substring(startIdx, lenOfSubstring), textValue + siteKey);
            }
            Console.WriteLine(replacedHTML);
        }
    }
}
