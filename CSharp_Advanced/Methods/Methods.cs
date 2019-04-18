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

        public static decimal ReverseDecimalNumber07(string numberToBeReversed)
        {
            string[] parts = numberToBeReversed.Split('.');
            int wholeNumberPart = int.Parse(parts[0]);
            int decimalNumberPart = int.Parse(parts[1]);

            string reversedNumber = ReverseIntNumber(decimalNumberPart).ToString() + "." + ReverseIntNumber(wholeNumberPart).ToString();

            return decimal.Parse(reversedNumber);
        }

        public static int ReverseIntNumber(int numberToBeReversed)
        {
            int reversedNumber = 0;

            for (int i = numberToBeReversed.ToString().Length - 1; i >= 0; i--)
            {
                reversedNumber += (int)((numberToBeReversed % 10) * Math.Pow(10, i));
                numberToBeReversed /= 10;
            }
            return reversedNumber;
        }

        public static int CountZerosInBeggining(string number)
        {
            int zeroCount = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '0')
                {
                    return zeroCount;
                }

                zeroCount++;
            }
            return 0;
        }

        public static void NumberAsArray08()
        {
            int[] arrayLengths = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(item => int.Parse(item))
                                .ToArray();

            int firstArrayLength = arrayLengths[0];
            int secondArrayLegth = arrayLengths[1];

            int[] firstArray = new int[firstArrayLength];
            firstArray = Console.ReadLine()
                           .Split(new char[] { ' ' }, firstArrayLength, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            int[] secondArray = new int[secondArrayLegth];
            secondArray = Console.ReadLine()
                           .Split(new char[] { ' ' }, secondArrayLegth, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            string concatFirstArray = "";
            for (int i = 0; i < firstArray.Length; i++)
            {
                concatFirstArray += firstArray[i];
            }

            int firstAddend = int.Parse(concatFirstArray);
            firstAddend = ReverseIntNumber(firstAddend);

            if (CountZerosInBeggining(concatFirstArray) > 0)
            {
                firstAddend *= (int)Math.Pow(10, CountZerosInBeggining(concatFirstArray));
            }

            string concatSecondArray = "";
            for (int i = 0; i < secondArray.Length; i++)
            {
                concatSecondArray += secondArray[i];
            }

            int secondAddend = int.Parse(concatSecondArray);
            secondAddend = ReverseIntNumber(secondAddend);

            if (CountZerosInBeggining(concatSecondArray) > 0)
            {
                secondAddend *= (int)Math.Pow(10, CountZerosInBeggining(concatSecondArray));
            }

            int arraysSum = firstAddend + secondAddend;
            string sumArray = ReverseIntNumber(arraysSum).ToString();

            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.Write("{0,2}", sumArray[i]);
            }
        }

        public static int MaxElementFromArray(int[] arrayToBeSorted, int startingIndex = 0)
        {
            int maximalElement = int.MinValue;

            for (int i = startingIndex; i < arrayToBeSorted.Length; i++)
            {
                if (arrayToBeSorted[i] > maximalElement)
                {
                    maximalElement = arrayToBeSorted[i];
                }
            }
            return maximalElement;
        }

        public static void SortinArray09()
        {

        }

        public static void MultiplyDigitsOfNumberByAnother(int numberToBeRepresentedAsArray, int multiplier)
        {
            int numberLength = numberToBeRepresentedAsArray.ToString().Length;
            int[] numberAsArray = new int[numberLength];

            for (int i = numberLength - 1; i >= 0; i--)
            {
                numberAsArray[i] = (numberToBeRepresentedAsArray % 10) * multiplier;
                numberToBeRepresentedAsArray /= 10;
            }

            for (int i = 0; i < numberAsArray.Length; i++)
            {
                Console.Write("{0,3}", numberAsArray[i]);
            }
        }

        public static int Factorial10(int number)
        {
            int factorial = number;

            for (int i = number - 1; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int FactorialRecursion10(int number)
        {
            if (number == 1)
            {
                return number;
            }

            return number * FactorialRecursion10(--number);
        }

        public static void AddingPolynomials11()
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] firstPolinom = Console.ReadLine()
                           .Split(new char[] { ' ' }, arraySize, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            int[] seconPolinom = Console.ReadLine()
                           .Split(new char[] { ' ' }, arraySize, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("{0, -3}", firstPolinom[i] + seconPolinom[i]);
            }
        }

        public static void SubtractPolynomials12()
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] firstPolinom = Console.ReadLine()
                           .Split(new char[] { ' ' }, arraySize, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            int[] seconPolinom = Console.ReadLine()
                           .Split(new char[] { ' ' }, arraySize, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("{0, -3}", firstPolinom[i] - seconPolinom[i]);
            }
        }

        public static int[] MultiplyPolynomials12(int[] polyOne, int[] polyTwo, int polyOneLen, int polyTwoLen)
        {
            int[] prod = new int[polyOneLen + polyTwoLen - 1];

            for (int i = 0; i < polyOneLen + polyTwoLen - 1; i++)
            {
                prod[i] = 0;
            }

            for (int i = 0; i < polyOneLen; i++)
            {
                for (int j = 0; j < polyTwoLen; j++)
                {
                    prod[i + j] += polyOne[i] * polyTwo[j];
                }
            }

            return prod;            
        }

        public static void PrintPolinom12(int[] poly, int polyLen)
        {
            for (int i = polyLen - 1; i >= 0; i--)
            {
                Console.Write(poly[i]);
                if (i != 0)
                {
                    Console.Write("x^" + i);
                }
                if (i != 0)
                {
                    Console.Write(" + ");
                }
            }
        }

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

            /* Task 7 
            string numberToBeReversed = Console.ReadLine();
            Console.WriteLine(ReverseDecimalNumber07(numberToBeReversed));
            */

            /* Task 8 
            NumberAsArray08();
            */

            /* Task 9 */
            //int[] maxot3 = new int[] { 500, 18, 14, 16, 19, 203, -2, 432, 45 };
            //Console.WriteLine(MaxElementFromArray(maxot3));
            //Console.WriteLine(MaxElementFromArray(maxot3, 3));

            /* Task 10 - Part1
            int numberToBeRepresentedAsArray = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            MultiplyDigitsOfNumberByAnother(numberToBeRepresentedAsArray, multiplier);
                       - Part2
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial10(number));
            Console.WriteLine(FactorialRecursion10(number));
            */

            /* Task 11 
            AddingPolynomials11();
            */

            /* Task 12 
            SubtractPolynomials12();
           
            // Task 2 - part 2    
            int[] firstPolinom = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            int[] secondPolinom = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();

            Console.Write("(");
            PrintPolinom12(firstPolinom, firstPolinom.Length);
            Console.Write(") * (");
            PrintPolinom12(secondPolinom, secondPolinom.Length);
            Console.Write(") = ");

            int[] prod = MultiplyPolynomials12(firstPolinom, secondPolinom, firstPolinom.Length, secondPolinom.Length);

            PrintPolinom12(prod, firstPolinom.Length + secondPolinom.Length - 1);
            */
        }
    }
}
