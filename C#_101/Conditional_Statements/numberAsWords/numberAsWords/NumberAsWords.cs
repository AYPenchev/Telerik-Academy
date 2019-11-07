namespace NumberAsWords
{
    using System;

    class NumberAsWords
    {
        public static void ConvertNumberToWord(string[] number)
        {
            int numberAsInteger = int.Parse(number[0]);
            int ones, tens, hundreds;
            string numberAsWord = "";
            string[] onesAsWord = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                                    "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensAsWord = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (numberAsInteger == 0)
            {
                numberAsWord = "Zero";
            }
            else if (numberAsInteger < 100)
            {
                ones = int.Parse(number[0]) % 10;
                tens = int.Parse(number[0]) / 10;
                numberAsWord = NumberToWordFromOneToNintyNine(numberAsInteger, numberAsWord, onesAsWord, tensAsWord, ones, tens);
            }
            else
            {
                ones = int.Parse(number[0]) % 10;
                tens = (int.Parse(number[0]) % 100) / 10;
                hundreds = int.Parse(number[0]) / 100;
                numberAsInteger = int.Parse(number[0].Substring(1));

                numberAsWord = NumberToWordFromOneToNintyNine(numberAsInteger, numberAsWord, onesAsWord, tensAsWord, ones, tens);
                if (numberAsInteger != 0)
                {
                    numberAsWord = onesAsWord[hundreds] + " hundred and " + numberAsWord;
                }
                else
                {
                    numberAsWord = onesAsWord[hundreds] + " hundred";
                }
            }

            Console.WriteLine(CapitalizeFirstLetter(numberAsWord));
        }

        public static string NumberToWordFromOneToNintyNine(int numberAsInteger, string numberAsWord, string[] onesAsWord, string[] tensAsWord, int ones, int tens)
        {
            if (numberAsInteger > 0 && numberAsInteger < 20)
            {
                numberAsWord = onesAsWord[numberAsInteger];
                return numberAsWord;
            }
            else if (numberAsInteger > 19 && numberAsInteger < 100)
            {
                numberAsWord = tensAsWord[tens] + ' ' + onesAsWord[ones];
                return numberAsWord;
            }

            return "";
        }

        public static string CapitalizeFirstLetter(string numberAsWord)
        {
            string firstLettter = numberAsWord[0].ToString();

            if (firstLettter == firstLettter.ToUpper())
            {
                return numberAsWord;
            }

            firstLettter = firstLettter.ToUpper();
            string capitalizedFirstLetterWord = firstLettter;

            for (int i = 1; i < numberAsWord.Length; i++)
            {
                capitalizedFirstLetterWord += numberAsWord[i];
            }

            return capitalizedFirstLetterWord;
        }

        static void Main()
        {
            string[] firstNumber = { "434" };
            ConvertNumberToWord(firstNumber);

            string[] secondNumber = { "43" };
            ConvertNumberToWord(secondNumber);

            string[] thirdNumber = { "4" };
            ConvertNumberToWord(thirdNumber);
        }
    }
}
