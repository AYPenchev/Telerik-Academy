namespace Task25
{
    using System;

    class ExtractTextHTML
    {
        static void Main()
        {
            string inputHTML = Console.ReadLine();

            string text = inputHTML.Remove(0, inputHTML.IndexOf("<tittle>") + 8);
            text = text.Remove(text.IndexOf("</tittle>"));
            Console.WriteLine("Tittle: " + text);

            
        }
    }
}
