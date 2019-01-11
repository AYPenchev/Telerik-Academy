using System;

namespace Operators_And_Expressions
{
    class Operators_And_Expressions
    {
        //These functions are separate from other because of Single class responsibility principle 
        private static int ReadOneIntegerFromConsole()
        {
            int readNumber = int.Parse(Console.ReadLine());
            return readNumber;
        }
        private static float ReadOneFloatFromConsole()
        {
            float readNumber = float.Parse(Console.ReadLine());
            return readNumber;
        }
        //How to make these two functions above return generic type?

        private static void OddOrEven01()
        {
            Console.WriteLine("Enter a number to check if it is even or odd: ");
            int number = ReadOneIntegerFromConsole();
            if (number % 2 == 0)
            {
                Console.WriteLine("even " + number);
            }
            else
            {
                Console.WriteLine("odd " + number);
            }
        }

        private static void MoonGravity02()
        {
            Console.WriteLine("Enter your weight: ");
            float weight = ReadOneFloatFromConsole();
            weight = (weight / 100) * 17;
            //Console.WriteLine(Math.Round(weight, 3));
            string roundWeight = string.Format("{0:0.000}", weight);
            Console.WriteLine(roundWeight);
        }

        private static void DivideBySevenAndFive03()
        {
            Console.WriteLine("Enter a number to check if it is divisible without remainder by 7 and 5: ");
            int divisible = ReadOneIntegerFromConsole();
            if (divisible % 5 == 0 || divisible % 7 == 0)
            {
                Console.WriteLine("true " + divisible);
            }
            else
            {
                Console.WriteLine("false " + divisible);
            }
        }

        private static void Rectangles04()
        {
            Console.Write("Enter rectangle width: ");
            float rectangleWidth = ReadOneFloatFromConsole();
            Console.Write("Enter rectangle heights: ");
            float rectangleHeight = ReadOneFloatFromConsole();
            float area = rectangleWidth * rectangleHeight;
            string roundArea = string.Format("{0:0.00}", area);
            float perimeter = 2 * (rectangleWidth + rectangleHeight);
            string roundPerimeter = string.Format("{0:0.00}", perimeter);
            Console.WriteLine("Rectangle's area: " + roundArea + " perimeter: " + roundPerimeter);
        }

        private static void ThirdDigit05()
        {
            Console.WriteLine("Enter a number and check if the third digit is 7: ");
            int n = ReadOneIntegerFromConsole();
            n = (n % 1000) / 100;
            if (n == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + n);
            }
        }

        private static short? ValidateFourDigitNum()
        {
            short? fourDigitNum = null;
            bool flagValidator = true;
            Console.Write("Enter four digit number: ");
            while (flagValidator)
            {
                fourDigitNum = short.Parse(Console.ReadLine());
                if (fourDigitNum > 999 && fourDigitNum < 10000)
                {
                    flagValidator = false;
                }
            }
            return fourDigitNum;
        }

        private static short CalcSum06()
        {
            short? fourDigitNum = ValidateFourDigitNum();

            byte firstDigit = (byte)(fourDigitNum % 10);
            byte secondDigit = (byte)((fourDigitNum / 10) % 10);
            byte thirdDigit = (byte)((fourDigitNum / 100) % 10);
            byte fourthDigit = (byte)(fourDigitNum / 1000);

            short sum = (short)(firstDigit + secondDigit + thirdDigit + fourthDigit);
            return sum;

        }

        private static void ReversedNum06()
        {
            short? fourDigitNum = ValidateFourDigitNum();

            byte firstDigit = (byte)(fourDigitNum / 1000);
            byte secondDigit = (byte)((fourDigitNum / 100) % 10);
            byte thirdDigit = (byte)((fourDigitNum / 10) % 10);
            byte fourthDigit = (byte)(fourDigitNum % 10);
            if (fourthDigit == 0)
            {
                Console.WriteLine("0" + (short)(thirdDigit * 100 + secondDigit * 10 + firstDigit));
            }
            else
            {
                Console.WriteLine((short)(fourthDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + firstDigit));
            }
        }

        private static void LastDigitFirst06()
        {
            short? fourDigitNum = ValidateFourDigitNum();

            int? restOfNum = fourDigitNum / 10;
            byte fourthDigit = (byte)(fourDigitNum % 10);
            if (fourthDigit == 0)
            {
                Console.WriteLine("0" + (short)restOfNum);
            }
            else
            {
                Console.WriteLine((short)(fourthDigit * 1000 + restOfNum));
            }
        }

        private static short SwapSecondAndThirdDigit06()
        {
            short? fourDigitNum = ValidateFourDigitNum();

            byte firstDigit = (byte)(fourDigitNum / 1000);
            byte secondDigit = (byte)((fourDigitNum / 100) % 10);
            byte thirdDigit = (byte)((fourDigitNum / 10) % 10);
            byte fourthDigit = (byte)(fourDigitNum % 10);

            return (short)(firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit);
        }

        private static void PointInCircle07()
        {
            Console.Write("Enter X coordinate: ");
            double x = float.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            double y = float.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            if (distance <= 2)
            {
                Console.WriteLine("yes {0}", String.Format("{0:0.00}", distance));
            }
            else
            {
                Console.WriteLine("no {0}", String.Format("{0:0.00}", distance));
            }
        }

        private static bool PrimeCheck08()
        {
            short? checkNum = null;
            bool flagValidator = true;
            Console.WriteLine("Enter a number to check if it is prime: ");
            while (flagValidator)
            {
                checkNum = short.Parse(Console.ReadLine());
                if (checkNum <= 100)
                {
                    if (checkNum > 0)
                    {
                        flagValidator = false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (checkNum == 1)
            {
                return false;
            }
            for (int i = 2; i <= checkNum / 2; i++)
            {
                if (checkNum % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        private static void Trapezoids09()
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side h: ");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) * h) / 2;
            Console.WriteLine(String.Format("{0:F7}", area));

        }

        private static void PointCircleRectangle10()
        {
            double x, y;
            Console.Write("Enter coordinate x: ");
            while (true)
            {
                x = double.Parse(Console.ReadLine());
                if (x > -1001 && x < 1001)
                {
                    break;
                }
            }

            Console.Write("Enter coordinate y: ");
            while (true)
            {
                y = double.Parse(Console.ReadLine());
                if (y > -1001 && y < 1001)
                {
                    break;
                }
            }
            double distance = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2));

            if (distance <= 1.5)
            {
                if (x >= -1 && x <= 5 && y <= 1 && y >= -1)
                {
                    Console.WriteLine("inside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("inside circle outside rectangle");
                }
            }
            else if (x >= -1 && x <= 5 && y <= 1 && y >= -1)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }

        private static void ThirdBit11()
        {
            long positiveInteger;
            while (true)
            {
                positiveInteger = int.Parse(Console.ReadLine());
                if (positiveInteger > 0)
                {
                    break;
                }
            }
            Console.WriteLine(Convert.ToString(positiveInteger, 2));
            Console.WriteLine(Convert.ToString(8, 2));

            string compare = Convert.ToString((positiveInteger & 8), 2);
            if (compare.Equals("1000"))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static void NthBit12()
        {
            Console.WriteLine("Enter positive number N between [1 ; 54]: ");
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0 && n < 55)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number, please try again: ");
                }
            }

            Console.WriteLine("Enter positive number P: ");
            long p;
            while (true)
            {
                p = long.Parse(Console.ReadLine());
                if (p >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered negative number, please enter positive number P: ");
                }
            }

            Console.WriteLine("P in binary: " + Convert.ToString(p, 2));
            p = p >> n;
            Console.WriteLine("P in binary after shift n times: " + Convert.ToString(p, 2));
            if ((p & 1) == 1)
            {
                Console.WriteLine("N-th bit is: " + 1);
            }
            else
            {
                Console.WriteLine("N-th bit is: " + 0);
            }
        }

        private static void ModifyBit13()
        {
            Console.WriteLine("Enter positive number N: ");
            ulong n = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Enter positive number P between [0 ; 63]: ");
            int p;
            while (true)
            {
                p = int.Parse(Console.ReadLine());
                if (p >= 0 && p <= 64)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number, please try again: ");
                }
            }

            Console.WriteLine("Enter number V between [0 ; 1]: ");
            byte v;
            while (true)
            {
                v = byte.Parse(Console.ReadLine());
                if (v == 0 || v == 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number, please try again: ");
                }
            }

            // finds the bit at P position in the original number N
            int helpBit = (int)(n & (ulong)(1 << p));
            byte bitAtPPosition = (helpBit != 0) ? bitAtPPosition = 1 : bitAtPPosition = 0;

            //if it is the same as V nothing changes, else the opposite bit is set at P position
            if (bitAtPPosition != v)
            {
                if (bitAtPPosition == 0)
                {
                    n = n | (ulong)(1 << p);
                    Console.WriteLine(n);
                }
                else
                {
                    n = n ^ (ulong)(1 << p);
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine(n);
            }
        }

        private static void BitExchange14()
        {
            Console.WriteLine("Enter positive number N: ");
            uint n;
            n = uint.Parse(Console.ReadLine());
            

            int helpBit3 = (int)(n & (ulong)(1 << 3));
            byte bitAt3Position = (helpBit3 != 0) ? bitAt3Position = 1 : bitAt3Position = 0;

            int helpBit4 = (int)(n & (ulong)(1 << 4));
            byte bitAt4Position = (helpBit4 != 0) ? bitAt4Position = 1 : bitAt4Position = 0;

            int helpBit5 = (int)(n & (ulong)(1 << 5));
            byte bitAt5Position = (helpBit5 != 0) ? bitAt5Position = 1 : bitAt5Position = 0;

            int helpBit24 = (int)(n & (ulong)(1 << 24));
            byte bitAt24Position = (helpBit24 != 0) ? bitAt24Position = 1 : bitAt24Position = 0;

            int helpBit25 = (int)(n & (ulong)(1 << 25));
            byte bitAt25Position = (helpBit25 != 0) ? bitAt25Position = 1 : bitAt25Position = 0;

            int helpBit26 = (int)(n & (ulong)(1 << 26));
            byte bitAt26Position = (helpBit26 != 0) ? bitAt26Position = 1 : bitAt26Position = 0;

            if (bitAt3Position != bitAt24Position)
            {

                if (bitAt3Position == 0)
                {
                    n = n ^ (1 << 24);
                    n = n | (1 << 3);
                }
                else
                {
                    n = n | (1 << 24);
                    n = n ^ (1 << 3);
                }
            }

            if (bitAt4Position != bitAt25Position)
            {

                if (bitAt4Position == 0)
                {
                    n = n ^ (1 << 25);
                    n = n | (1 << 4);
                }
                else
                {
                    n = n | (1 << 25);
                    n = n ^ (1 << 4);
                }
            }

            if (bitAt5Position != bitAt26Position)
            {

                if (bitAt5Position == 0)
                {
                    n = n ^ (1 << 26);
                    n = n | (1 << 5);
                }
                else
                {
                    n = n | (1 << 26);
                    n = n ^ (1 << 5);
                }
            }
            Console.WriteLine(n);
        }

        private static void BitSwap15()
        {
            Console.WriteLine("Enter positive numbers: N, P, Q, K ");
            uint n;
            ushort p, q, k;

                n = uint.Parse(Console.ReadLine());
                p = ushort.Parse(Console.ReadLine());
                q = ushort.Parse(Console.ReadLine());
                k = ushort.Parse(Console.ReadLine());

            bool checkOverlap = (p + k) < q || p > (q + k);

            if (p + k <= 32 && checkOverlap && q + k <= 32)
            {
                int neededShift = Math.Abs(p - q);

                for (int i = p,j = q; i < (p + k) && (p + k) < q; i++,j++)
                {

                    long helpBitI = (n & (1 << i));
                    byte bitAtIPosition = (helpBitI != 0) ? bitAtIPosition = 1 : bitAtIPosition = 0;

                    int helpBitIPlusNeededShift = (int)(n & (ulong)(1 << (i + neededShift)));
                    byte bitAtIPlusNeededShiftPosition = (helpBitIPlusNeededShift != 0) ? bitAtIPlusNeededShiftPosition = 1 : bitAtIPlusNeededShiftPosition = 0;

                    if (bitAtIPosition != bitAtIPlusNeededShiftPosition)
                    {
                        if (bitAtIPosition == 0)
                        {
                            n = n ^ (uint)(1 << i);
                            n = n ^ (uint)(1 << i + neededShift);
                        }
                        else
                        {
                            n = n ^ (uint)(1 << i);
                            n = n ^ (uint)(1 << i + neededShift);
                        }
                    }
                }

                for (int i = q, j = p; i < (q + k) && p > (q + k); i++, j++)
                {

                    long helpBitI = (n & (1 << i));
                    byte bitAtIPosition = (helpBitI != 0) ? bitAtIPosition = 1 : bitAtIPosition = 0;

                    int helpBitIPlusNeededShift = (int)(n & (ulong)(1 << (i + neededShift)));
                    byte bitAtIPlusNeededShiftPosition = (helpBitIPlusNeededShift != 0) ? bitAtIPlusNeededShiftPosition = 1 : bitAtIPlusNeededShiftPosition = 0;

                    if (bitAtIPosition != bitAtIPlusNeededShiftPosition)
                    {
                        if (bitAtIPosition == 0)
                        {
                            n = n ^ (uint)(1 << i);
                            n = n ^ (uint)(1 << i + neededShift);
                        }
                        else
                        {
                            n = n ^ (uint)(1 << i);
                            n = n ^ (uint)(1 << i + neededShift);
                        }
                    }
                }
            }  
            Console.WriteLine(n);
        }

        static void Main()
        {
            OddOrEven01();
            MoonGravity02();
            DivideBySevenAndFive03();
            Rectangles04();
            ThirdDigit05();
            Console.WriteLine(CalcSum06());
            ReversedNum06();
            LastDigitFirst06();
            Console.WriteLine(SwapSecondAndThirdDigit06());
            PointInCircle07();
            PrimeCheck08();
            Trapezoids09();
            PointCircleRectangle10();
            ThirdBit11();
            NthBit12();
            ModifyBit13();
            BitExchange14();
            BitSwap15();
        }
    }
}
