namespace Task20
{
    using System;
    using System.Collections.Generic;

    class ExtractPalindromes
    {
        private static bool IsPalindrome(string palindrome)
        {
            int i = 0;
            int j = palindrome.Length - 1;

            while (i < j)
            {
                if (palindrome[i] != palindrome[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }

        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> extractedPalindromes = new List<string>();

            foreach (string palindrome in text)
            {
                if(IsPalindrome(palindrome))
                {
                    extractedPalindromes.Add(palindrome);
                    Console.Write(palindrome + "\n");
                }
            }
        }
    }
}
