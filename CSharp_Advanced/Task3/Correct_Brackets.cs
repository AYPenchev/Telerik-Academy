namespace Task3
{
    using System;
    using System.Collections.Generic;

    class CorrectBrackets
    {
        public static bool AreBracketsCorrect(string expression)
        {
            Queue<char> allBrackets = new Queue<char>();
            int countLeftBrackets = 0;
            int countRightBrackets = 0;

            foreach (char symbol in expression)
            {
                if(symbol == '(')
                {
                    allBrackets.Enqueue(symbol);
                    countLeftBrackets++;
                }
                else if(symbol == ')')
                {
                    allBrackets.Enqueue(symbol);
                    countRightBrackets++;
                }
            }

            if (countLeftBrackets != countRightBrackets)
            {
                return false;
            }

            char currentBracket;

            for (int i = 0; i < allBrackets.Count; i++)
            {
                if (countRightBrackets < countLeftBrackets)
                {
                    return false;
                }

                currentBracket = allBrackets.Dequeue();

                if (currentBracket == '(')
                {
                    countLeftBrackets--;
                }
                else
                {
                    countRightBrackets--;
                }
            }
            return true;
        }

        static void Main()
        {
            string expression = Console.ReadLine();
            bool areBracketsCorrect = AreBracketsCorrect(expression);

            if(areBracketsCorrect)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
