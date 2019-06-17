namespace Task1
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            double halfSum = (aSide + bSide + cSide) / 2;
            double area = Math.Sqrt(halfSum * (halfSum - aSide) * (halfSum - bSide) * (halfSum - cSide));
            return area;
        }

        public static string NumberLastDigit(int number)
        {
            byte lastDigit = (byte)(number % 10);
            switch (lastDigit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Invalid number!";
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("No parameters entered!");
            }

            int maxNumber = int.MinValue;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        public static void PrintAsNumber(double number, char format)
        {
            switch (format)
            {
                case 'f': Console.WriteLine("{0:f2}", number); break;
                case '%': Console.WriteLine("{0:p0}", number); break;
                case 'r': Console.WriteLine("{0,8}", number); break;
                default: Console.WriteLine("Invalid format!"); break;
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        }

        public static bool IsHorizontal(double y1, double y2)
        {
            return y1 == y2;
        }

        public static bool IsVertical(double x1, double x2)
        {
            return x1 == x2;
        }

        public static void Main()
        {
            try
            {
                Console.WriteLine(CalcTriangleArea(-1, 4, 5));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(NumberLastDigit(5));

            try
            {
                Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            PrintAsNumber(1.3, 'f');
            PrintAsNumber(0.75, '%');
            PrintAsNumber(2.30, 'r');

            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;
            bool horizontal = IsHorizontal(y1, y2);
            bool vertical = IsVertical(x1, x2);

            Console.WriteLine(CalcDistance(x1, y1, x2, y2));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "17/03/1992");
            peter.OtherInfo = "From Sofia";

            Student stella = new Student("Stella", "Markova", "03/11/1993");
            stella.OtherInfo = "From Vidin, gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
