namespace UsingClassesAndObjects
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using Methods;

    class UsingClassesAndObjects
    {
        public static IEnumerable<DateTime> Model { get; private set; }

        public static void IsLeapYear01(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }

        public static void PrintTenRandomNumbers02()
        {
            Random randNum = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", randNum.Next(100, 200));
            }
        }

        public static void GetDayOfWeek03()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.DayOfWeek);
        }

        public static double GetTriangleArea04(double sideOfTriangle, double altitudeOfTriangle)
        {
            return (sideOfTriangle * altitudeOfTriangle) / 2;
        }

        public static double GetTriangleArea05(double sideA, double sideB, double sideC)
        {
            double semipermeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semipermeter * (semipermeter - sideA) * (semipermeter - sideB) * (semipermeter - sideC));
        }

        public static double GetTriangleArea06(double sideA, double sideB, double angleBetween)
        {
            double angleInRadians = angleBetween * Math.PI / 180;
            return (sideA * sideB * Math.Sin(angleInRadians)) / 2;
        }

        public static int GetWorkdays07(DateTime date)
        {
            int year = DateTime.Today.Year;
            DateTime[] holidays = { new DateTime(year, 1, 1), new DateTime(year, 3, 3), new DateTime(year, 4, 28), new DateTime(year, 5, 1),
                                    new DateTime(year, 5, 6), new DateTime(year, 5, 24), new DateTime(year, 9, 6), new DateTime(year, 9, 22),
                                    new DateTime(year, 12, 24), new DateTime(year, 12, 25), new DateTime(year, 12, 26)
                                  };

            DateTime startDate = DateTime.Today;

            TimeSpan rangeTimeSpan = date.Subtract(startDate);
            DateTime[] rangeTimeArray = new DateTime[rangeTimeSpan.Days];

            DateTime currentDate = startDate;
            for (int i = 0; i < rangeTimeSpan.Days; i++)
            {
                currentDate = currentDate.AddDays(1);
                rangeTimeArray[i] = currentDate;
            }

            int NumOfWorkDays = rangeTimeArray.Where(x => x >= startDate &&
                                                    x.DayOfWeek != DayOfWeek.Saturday &&
                                                    x.DayOfWeek != DayOfWeek.Sunday &&
                                                    !holidays.Contains(x)).Count();

            for (int i = 0; i < rangeTimeArray.Length; i++)
            {
                if ((rangeTimeArray[i].DayOfWeek == DayOfWeek.Saturday || rangeTimeArray[i].DayOfWeek == DayOfWeek.Sunday) &&
                    holidays.Contains(rangeTimeArray[i]))
                {
                    NumOfWorkDays--;
                }
            }
            return NumOfWorkDays;
        }

        public static void FillArray(ref int[] numbers)
        {
            numbers = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();
        }

        public static int SumIntegers08()
        {
            int[] sumArray = Array.Empty<int>();
            FillArray(ref sumArray);

            int sum = 0;
            foreach (var num in sumArray)
            {
                sum += num;
            }
            return sum;
        }

        public static string TrimInput(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }

        public static List<char> arithmeticOperations = new List<char>() { '+', '-', '*', '/' };
        public static List<char> brackets = new List<char>() { '(', ')' };
        public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };

        public static List<string> SeparateTokens(string input)
        {
            List<string> result = new List<string>();

            StringBuilder number = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '(') )
                {
                    number.Append('-');
                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;
                }
                else if (brackets.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (arithmeticOperations.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (input[i] == ',')
                {
                    result.Add(",");
                }
                else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add("ln");
                    i++;
                }
                else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
                {
                    result.Add("pow");
                    i += 2;
                }
                else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
                {
                    result.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expression");
                }
            }

            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }
            return result;
        }

        public static int Precedence(string arithmeticOperator)
        {
            if (arithmeticOperator == "+" || arithmeticOperator == "-")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static Queue<string> ConvertToReversePolishNotation(List<string> tokens)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < tokens.Count; i++)
            {
                var currentToken = tokens[i];
                double number;

                if (double.TryParse(currentToken, out number))
                {
                    queue.Enqueue(currentToken);
                }
                else if (functions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }
                else if (currentToken == ",")
                {
                    if(!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid brackets or function separator");
                    }

                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
                else if (arithmeticOperations.Contains(currentToken[0]))
                {
                    while (stack.Count != 0 && arithmeticOperations.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Push(currentToken);
                }
                else if (currentToken == "(")
                {
                    stack.Push(currentToken);
                }
                else if (currentToken == ")")
                {
                    if(!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid brackets position");
                    }

                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Pop();

                    if (stack.Count != 0 && functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }

            while (stack.Count != 0)
            {
                if (brackets.Contains(stack.Peek()[0]))
                {
                    throw new ArgumentException("Invalid brackets position");
                }

                queue.Enqueue(stack.Pop());
            }
            return queue;
        }

        public static void PutInvariantCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }
        public static double GetResultFromRPN(Queue<string> queue)
        {
            Stack<double> stack = new Stack<double>();

            while (queue.Count != 0)
            {
                string currentTocken = queue.Dequeue();

                double number;
                if (double.TryParse(currentTocken, out number))
                {
                    stack.Push(number);
                }
                else if (arithmeticOperations.Contains(currentTocken[0]) || functions.Contains(currentTocken))
                {
                    if(currentTocken == "+")
                    {
                        if(stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue + secondValue);
                    }
                    else if(currentTocken == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue - firstValue);
                    }
                    else if (currentTocken == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue * firstValue);
                    }
                    else if (currentTocken == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue / firstValue);
                    }
                    else if (currentTocken == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(Math.Pow(secondValue, firstValue));
                    }
                    else if (currentTocken == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double value = stack.Pop();

                        stack.Push(Math.Sqrt(value));
                    }
                    else if (currentTocken == "ln")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double value = stack.Pop();

                        stack.Push(Math.Log(value));
                    }
                }
            }
            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression");
            }
        }

        public static void ArithmeticalExpressions09()
        {
            string input = Console.ReadLine().Trim();
            while (input.ToLower() != "end")
            {
                try
                {
                    string trimmedInput = TrimInput(input); // Replace function can be used

                    var separatedTonkens = SeparateTokens(trimmedInput);

                    var reversePolishNotation = ConvertToReversePolishNotation(separatedTonkens);

                    var finalResult = GetResultFromRPN(reversePolishNotation);

                    Console.WriteLine(finalResult);
                }
                catch (ArgumentException exception)
                {

                    Console.WriteLine(exception.Message); ;
                }

                input = Console.ReadLine().Trim();
            }
        }

        static void Main()
        {
            /* Task 1
            int year = int.Parse(Console.ReadLine());
            IsLeapYear01(year);
            */
            /* Task 2 
            PrintTenRandomNumbers02();
            */
            /* Task 3
            GetDayOfWeek03();
            */
            /* Task 4
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double altitudeOfTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", GetTriangleArea04(sideOfTriangle, altitudeOfTriangle));
            */
            /* Task 5
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", GetTriangleArea05(sideA, sideB, sideC));
            */
            /* Task 6
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angleBetween = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", GetTriangleArea06(sideA, sideB, angleBetween));
            */
            /* Task 7
            Console.WriteLine("Enter due date in this format: dd/mm/yyyy");

            DateTime dueDate;
            if (DateTime.TryParse(Console.ReadLine(), out dueDate))
            {
                Console.WriteLine(GetWorkdays07(dueDate));
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
            }
            */

            /* Task 8 
            Console.WriteLine(SumIntegers08());
            */
            /* Task 9 
            PutInvariantCulture();
            ArithmeticalExpressions09();
            */
        }
    }
}
