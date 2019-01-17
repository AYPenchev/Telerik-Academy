using System;
using System.Numerics;

namespace Loops
{
    class Loops
    {
        private static void NumbersFrom1ToN01()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }

        private static int readIntWithConstraints(int firstConstraint, int secondConstraint)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n >= firstConstraint && n <= secondConstraint)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number. Try again!");
                }
            }
            return n;
        }

        private static void NotDivisibleNumbers02()
        {
            Console.Write("Enter n: ");
            int n = readIntWithConstraints(2, 1499);
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3) != 0 && (i % 7) != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        private static void MMSA03()
        {
            double sum = 0;
            double min = int.MaxValue;
            double max = int.MinValue;
            double avg;
            Console.WriteLine("Enter n: ");
            int n = readIntWithConstraints(1, 1000);
            for (int i = 0; i < n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
                if (currentNum > max)
                {
                    max = currentNum;
                }
                if (currentNum < min)
                {
                    min = currentNum;
                }
                sum += currentNum;
            }
            avg = sum / n;

            Console.WriteLine("min = " + String.Format("{0:F2}", min));
            Console.WriteLine("max = " + String.Format("{0:F2}", max));
            Console.WriteLine("sum = " + String.Format("{0:F2}", sum));
            Console.WriteLine("avg = " + String.Format("{0:F2}", avg));

        }

        private static void PrintADeck04()
        {
            string sign = Console.ReadLine();
            int counter;
            switch (sign)
            {
                case "2": counter = 2; break;
                case "3": counter = 3; break;
                case "4": counter = 4; break;
                case "5": counter = 5; break;
                case "6": counter = 6; break;
                case "7": counter = 7; break;
                case "8": counter = 8; break;
                case "9": counter = 9; break;
                case "10": counter = 10; break;
                case "J": counter = 11; break;
                case "Q": counter = 12; break;
                case "K": counter = 13; break;
                case "A": counter = 14; break;
                default:
                    counter = 0;
                    break;
            }
            for (int i = 2; i <= counter; i++)
            {
                if (i <= 10)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                else if (i == 11)
                {
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                }
                else if (i == 12)
                {
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                }
                else if (i == 13)
                {
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                }
                else
                {
                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                }
            }
        }

        private static void Calculate05()
        {
            Console.Write("Enter n: ");
            int n = readIntWithConstraints(2, 10);
            int factorial = 1;
            double x, sum = 0;
            Console.Write("Enter x: ");

            //Constraints and sample test don't match
            while (true)
            {
                x = double.Parse(Console.ReadLine());
                if (x > -5/*0.5*/ && x < 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number. Try again!");
                }
            }
            for (int i = 0; i <= n; i++)
            {
                if (i != 0)
                {
                    factorial *= i;
                    sum += factorial / Math.Pow(x, i);
                }
                else
                {
                    sum++;
                }
            }
            Console.WriteLine(string.Format("{0:F5}", sum));
        }

        private static void CalculateAgain06()
        {
            BigInteger factorialN = 1, factorialK = 1;
            int difference;
            Console.WriteLine("Enter K: ");
            int k = readIntWithConstraints(1, 100);
            Console.WriteLine("Enter n: ");
            int n = readIntWithConstraints(k, 100);

            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    factorialK *= i;
                }
                factorialN *= i;
            }

            difference = (int)(factorialN / factorialK);
            Console.WriteLine(difference);
        }

        private static int CalculateCombinatorics07()
        {
            BigInteger factorialN = 1, factorialK = 1, factorialNK = 1;
            int combination;
            Console.WriteLine("Enter K: ");
            int k = readIntWithConstraints(1, 100);
            Console.WriteLine("Enter n: ");
            int n = readIntWithConstraints(k, 100);

            for (int i = 1; i <= n; i++)
            {
                if (i <= (n - k))
                {
                    factorialNK *= i;
                }
                if (i <= k)
                {
                    factorialK *= i;
                }
                factorialN *= i;
            }
            combination = (int)(factorialN / (factorialK * factorialNK));
            return combination;
        }

        private static void CatalanNumbers08()
        {
            double CatalanNumber = 1;
            Console.WriteLine("Enter n: ");
            int n = readIntWithConstraints(0, 100);
            for (double i = 2; i <= n; i++)
            {
                CatalanNumber *= (n + i) / i;
            }
            Console.WriteLine(CatalanNumber);

        }

        private static void MatrixOfNumbers09()
        {
            Console.WriteLine("Enter n: ");
            int n = readIntWithConstraints(1, 20);
            int k = n;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= k; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
                k++;
            }
        }

        private static void MatrixOfNumbersChallange09()
        {
            Console.WriteLine("Enter n: ");
            int n = readIntWithConstraints(1, 20);
            for (int i = 1, j = 1; i <= n * n; i++, j++)
            {
                Console.Write(j + " ");
                if (i % n == 0)
                {
                    j = j - n + 1;
                    Console.WriteLine();
                }
            }
        }

        private static void OddAndEvenProduct10()
        {
            Console.WriteLine("Enter n: ");
            int n = readIntWithConstraints(4, 50);
            int productOdd = 1, productEven = 1;

            Console.Write("Enter the value of each number separated with space: ");
            string[] x = Console.ReadLine().Split(' ');
            int[] number = new int[n];

            for (int i = 0; i < 5; i++)
            {
                number[i] = Convert.ToInt32(x[i]);
                if (i % 2 == 0)
                {
                    productOdd *= number[i];
                }
                else
                {
                    productEven *= number[i];
                }
            }
            if (productEven == productOdd)
            {
                Console.WriteLine("yes " + productOdd);
            }
            else
            {
                Console.WriteLine("no " + productOdd + " " + productEven);
            }

            /*same task but reads each new number on new line
             Console.WriteLine("Enter n: ");
             int n = readIntWithConstraints(4, 50);
             int productOdd = 1, productEven = 1;
             for (int i = 0; i < n; i++)
             {
                 if (i % 2 == 0)
                 {
                     productOdd *= int.Parse(Console.ReadLine());
                 }
                 else
                 {
                     productEven *= int.Parse(Console.ReadLine());
                 }
             }
             if (productEven == productOdd)
             {
                 Console.WriteLine("yes " + productOdd);
             }
             else
             {
                 Console.WriteLine("no " + productOdd + " " + productEven);
             }*/
        }

        private static void BinaryToDecimal11()
        {
            long decimalNum = 0;
            Console.Write("Enter binary number: ");
            string binaryNum = Console.ReadLine();
            for (int i = binaryNum.Length - 1, j = 1; i >= 0; i--,j *= 2)
            {
                if(binaryNum[i] == '1')
                {
                    decimalNum += j;
                }
            }
            Console.WriteLine(decimalNum);
        }

        private static void DecimalToBinary12()
        {
            string binaryNum = "";
            Console.Write("Enter decimal number: ");
            long decimalNum = long.Parse(Console.ReadLine());

            if(decimalNum == 0)
            {
                binaryNum = "0";
            }
 
            while (decimalNum >= 1)
            {
                if(decimalNum % 2 == 0)
                {
                    binaryNum = binaryNum.Insert(0, "0");
                }
                else
                {
                   binaryNum = binaryNum.Insert(0, "1");
                }
                decimalNum /= 2;
            }
            Console.WriteLine(binaryNum);
        }

        private static void DecimalToHex13()
        {
            string HexNum = "";
            Console.Write("Enter decimal number: ");
            long decimalNum = long.Parse(Console.ReadLine());

            while (decimalNum > 0)
            {
                long remainder = decimalNum % 16;
                switch (remainder)
                {
                    case 1: HexNum = HexNum.Insert(0, "1"); break;
                    case 2: HexNum = HexNum.Insert(0, "2"); break;
                    case 3: HexNum = HexNum.Insert(0, "3"); break;
                    case 4: HexNum = HexNum.Insert(0, "4"); break;
                    case 5: HexNum = HexNum.Insert(0, "5"); break;
                    case 6: HexNum = HexNum.Insert(0, "6"); break;
                    case 7: HexNum = HexNum.Insert(0, "7"); break;
                    case 8: HexNum = HexNum.Insert(0, "8"); break;
                    case 9: HexNum = HexNum.Insert(0, "9"); break;
                    case 10: HexNum = HexNum.Insert(0, "A"); break;
                    case 11: HexNum = HexNum.Insert(0, "B"); break;
                    case 12: HexNum = HexNum.Insert(0, "C"); break;
                    case 13: HexNum = HexNum.Insert(0, "D"); break;
                    case 14: HexNum = HexNum.Insert(0, "E"); break;
                    case 15: HexNum = HexNum.Insert(0, "F"); break;
                    default:  break;
                }
                decimalNum /= 16;

            }
            Console.WriteLine(HexNum);

        }

        private static void HexToDecimal14()
        {
            BigInteger decimalNum = 0;
            Console.Write("Enter Hexdecimal number: ");
            string HexNum = Console.ReadLine();
            for (BigInteger i = HexNum.Length - 1, j = 1; i >= 0; i--, j *= 16)
            {
                switch (HexNum[(int)i])
                {
                    case '1': decimalNum += 1 * j;  break;
                    case '2': decimalNum += 2 * j; break;
                    case '3': decimalNum += 3 * j; break;
                    case '4': decimalNum += 4 * j; break;
                    case '5': decimalNum += 5 * j; break;
                    case '6': decimalNum += 6 * j; break;
                    case '7': decimalNum += 7 * j; break;
                    case '8': decimalNum += 8 * j; break;
                    case '9': decimalNum += 9 * j; break;
                    case 'A': decimalNum += 10 * j; break;
                    case 'B': decimalNum += 11 * j; break;
                    case 'C': decimalNum += 12 * j; break;
                    case 'D': decimalNum += 13 * j; break;
                    case 'E': decimalNum += 14 * j; break;
                    case 'F': decimalNum += 15 * j; break;
                    default: break;
                }
            }
            Console.WriteLine(decimalNum);
        }
            static void Main()
        {
            NumbersFrom1ToN01();
            NotDivisibleNumbers02();
            MMSA03();
            PrintADeck04();
            Calculate05();
            CalculateAgain06();
            Console.WriteLine(CalculateCombinatorics07());
            CatalanNumbers08();
            MatrixOfNumbers09();
            MatrixOfNumbersChallange09();
            OddAndEvenProduct10();
            BinaryToDecimal11();
            DecimalToBinary12();
            DecimalToHex13();
            HexToDecimal14();
        }
    }
}
