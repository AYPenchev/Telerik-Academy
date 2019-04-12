using System;
using System.Linq;

namespace Methods
{
    class Methods
    {

        public static void SayHello01(string userName)
        {
            Console.WriteLine("Hello, " + userName + "!");
        }

        public static string AsksForName01()
        {
            string userName = Console.ReadLine();
            return userName;
        }

        public static int GetMax02(int firstNumber, int secondNumber)
        {
            return firstNumber >= secondNumber ? firstNumber : secondNumber;
        }

        public static string EnglishDigit03(int lastDigit)
        {
            switch (GetLastDigit03(lastDigit))
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";

                default: return "Something went wrong! Try again!";
            }

        }
        public static int GetLastDigit03(int number)
        {
            return number % 10;
        }

        public static int AppearanceCount04(int[] numbers, int numberCheckedForAppearance)
        {
            int countAppearance = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (numberCheckedForAppearance == numbers[i])
                {
                    countAppearance++;
                }
            }
            return countAppearance;
        }

        public static void FillArray(ref int[] numbers)
        {
            int arraySize = int.Parse(Console.ReadLine());

            numbers = Console.ReadLine()
                           .Split(new char[] { ' ' }, arraySize, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();
        }

        public static int LargerThanNeighbours05(int[] largerThanNeighbourArray)
        {
            int countLargerThanNeighbours = 0;

            for (int i = 0; i < largerThanNeighbourArray.GetLongLength(0); i++)
            {
                if (i != 0 && i != largerThanNeighbourArray.GetLongLength(0) - 1)
                {
                    if (largerThanNeighbourArray[i] > largerThanNeighbourArray[i - 1] && largerThanNeighbourArray[i] > largerThanNeighbourArray[i + 1])
                    {
                        countLargerThanNeighbours++;
                    }
                }
                /* Check if first and last numbers are larger than their only neighbour
                else if (i == 0)
                {
                    if (largerThanNeighbourArray[i] > largerThanNeighbourArray[i + 1])
                    {
                        countLargerThanNeighbours++;
                    }
                }
                else if (i == largerThanNeighbourArray.GetLongLength(0) - 1)
                {
                    if (largerThanNeighbourArray[i] > largerThanNeighbourArray[i - 1])
                    {
                        countLargerThanNeighbours++;
                    }
                }
                */
            }
            return countLargerThanNeighbours;
        }

        public static int FirstLargerThanNeighbours06(int[] largerThanNeighbourArray)
        {
            for (int i = 0; i < largerThanNeighbourArray.GetLongLength(0); i++)
            {
                if (i != 0 && i != largerThanNeighbourArray.GetLongLength(0) - 1)
                {
                    if (largerThanNeighbourArray[i] > largerThanNeighbourArray[i - 1] && largerThanNeighbourArray[i] > largerThanNeighbourArray[i + 1])
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static double ReverseDecimalNumber(double numberToBeReversed)
        {
            int wholeNumberPart = (int)numberToBeReversed;
            int decimalNumberPart;

            string input_decimal_number = numberToBeReversed.ToString();

            var regex = new System.Text.RegularExpressions.Regex("(?<=[\\.])[0-9]+");
            if (regex.IsMatch(input_decimal_number))
            {
                string decimal_places = regex.Match(input_decimal_number).Value;
                decimalNumberPart = int.Parse(decimal_places);
            }
            return 1;
        }

        //public static int ReverseIntNumber(int numberToBeReversed)
        //{
        //    int reversedNumber = 0;
        //    numberToBeReversed.ToString().Length;
        //}

        static void Main()
        {
            /* Task 1
             string userName = AsksForName01();
             SayHello01(userName);
            //SayHello01(AsksForName01());
            */

            /* Task 2
            int[] numbers = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            int firstNumber = numbers[0];
            int secondNumber = numbers[1];
            int thirdNumber = numbers[2];

            Console.WriteLine(GetMax02(GetMax02(firstNumber, secondNumber), thirdNumber));
            */

            /* Task 3 
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(EnglishDigit03(GetLastDigit03(number)));
            */

            /* Task 4
            int[] numbers = { };
            
            FillArray(ref numbers);

            int numberCheckedForAppearance = int.Parse(Console.ReadLine());

            Console.WriteLine(AppearanceCount04(numbers, numberCheckedForAppearance));
            */

            /* Task 5
            int[] largerThanNeighbourArray = { };

            FillArray(ref largerThanNeighbourArray);

            Console.WriteLine(LargerThanNeighbours05(largerThanNeighbourArray));
            */

            /* Task 6 
            int[] firstLargerThanNeighbourArray = { };

            FillArray(ref firstLargerThanNeighbourArray);

            Console.WriteLine(FirstLargerThanNeighbours06(firstLargerThanNeighbourArray));
            */

            /* Task 7 */

        }
    }
}
