using System;

namespace Console_IO
{
    class Console_IO
    {
        private static float ReadOneFloatFromConsole()
        {
            float readNumber = float.Parse(Console.ReadLine());
            return readNumber;
        }
        private static float SumOf3Numbers01()
        {
            Console.WriteLine("Enter real number a: ");
            float a;
            while (true)
            {
                a = ReadOneFloatFromConsole();
                if (a >= -1000 && a <= 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number, please try again: ");
                }
            }

            Console.WriteLine("Enter real number b: ");
            float b;
            while (true)
            {
                b = ReadOneFloatFromConsole();
                if (b >= -1000 && b <= 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number, please try again: ");
                }
            }

            Console.WriteLine("Enter real number c: ");
            float c;
            while (true)
            {
                c = ReadOneFloatFromConsole();
                if (c >= -1000 && c <= 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number, please try again: ");
                }
            }
            return a + b + c;
        }

        private static void CompanyInfo02()
        {
            Console.WriteLine("Enter company name: ");
            string companyName = Console.ReadLine();

            Console.WriteLine("Enter company address: ");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter fax number: ");
            string faxNumber = Console.ReadLine();

            Console.WriteLine("Enter web site: ");
            string webSite = Console.ReadLine();

            Console.WriteLine("Enter manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.WriteLine("Enter manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.WriteLine("Enter manager age: ");
            short managerAge = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter manager number: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName + "\nAddress: " + companyAddress + "\nTel. " + phoneNumber);
            if (faxNumber.Equals(""))
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + faxNumber);
            }
            Console.WriteLine("Web site: " + webSite + "\nManager: " + managerFirstName + " " + managerLastName +
                              " (age: " + managerAge + ", tel. " + managerPhone + ")");
        }

        private static void Circle03()
        {
            Console.WriteLine("Enter real number radius r: ");
            float r;
            while (true)
            {
                r = ReadOneFloatFromConsole();
                if (r > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number, please try again: ");
                }
            }

            double area = Math.PI * Math.Pow(r, 2);
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine(String.Format("{0:0.00}", perimeter) + " " + String.Format("{0:0.00}", area));
        }
    
        private static void FormattingNumbers04()
        {
            Console.WriteLine("Enter a: ");
            int a;
            while (true)
            {
                a = int.Parse(Console.ReadLine());
                if(a >= 0 && a <= 500)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number, please try again: ");
                }
            }
            string aHex = a.ToString("X");
            string aBinary = Convert.ToString(a, 2);

            Console.WriteLine("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            int bAsInt = (int)b;
            int countB = bAsInt.ToString().Length + 3;
           

            Console.WriteLine("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            int cAsInt = (int)c;
            int countC = cAsInt.ToString().Length + 4;

            for (int i = 0; i < 10; i++)
            {
                if(aHex.Length > i)
                {
                    Console.Write(aHex[i]);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (aBinary.Length > i)
                {
                    Console.Write(aBinary[i]);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (9 - countB < i)
                {
                    Console.Write(String.Format("{0:0.00}", b));
                    break;
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < 11 - countC; i++)
            {
                if (i == 0)
                {
                    Console.Write(String.Format("{0:0.000}", c));
                }
                else
                {
                    Console.Write(" ");
                }
            }

        }

        private static void NumberComparer05()
        {
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? a : b);
        }

        private static void QuadraticEquation06()
        {
            Console.WriteLine("Enter a: ");
            double a = ReadOneFloatFromConsole();
            Console.WriteLine("Enter b: ");
            double b = ReadOneFloatFromConsole();
            Console.WriteLine("Enter c: ");
            double c = ReadOneFloatFromConsole();

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            double x1;
            double x2;
            if (discriminant < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if(discriminant == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine(String.Format("{0:0.00}", x1));
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine(x1 < x2 ? String.Format("{0:0.00}", x1) + "\n" + String.Format("{0:0.00}", x2)
                                          : String.Format("{0:0.00}", x2) + "\n" + String.Format("{0:0.00}", x1));
            }

        }

        private static int ReadIntWithConstraints()
        {
            int num;
            while (true)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= -1000 && num <= 1000)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("You entered wrong number!");
                }
            }
        }

        private static void SumOf5Numbers07()
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = ReadIntWithConstraints();
            Console.WriteLine("Enter second number: ");
            int secondNum = ReadIntWithConstraints();
            Console.WriteLine("Enter third number: ");
            int thirdNum = ReadIntWithConstraints();
            Console.WriteLine("Enter fourth number: ");
            int fourthNum = ReadIntWithConstraints();
            Console.WriteLine("Enter fifth number: ");
            int fifthNum = ReadIntWithConstraints();

            Console.WriteLine(firstNum + secondNum + thirdNum + fourthNum + fifthNum);
        }

        private static void NumbersFrom1ToN08()
        {
            int n;
            Console.Write("Enter n between 1 and 1000: ");
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n >= 1 && n < 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number!");
                }
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void SumOfNNumbers09()
        {
            Console.WriteLine("Enter n: ");
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if(n >= 1 && n <= 200)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number: ");
                }
            }
            double nNumbers, sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                nNumbers = double.Parse(Console.ReadLine());
                while (true)
                {
                    if (nNumbers >= -1000 && nNumbers <= 1000)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong number: ");
                    }
                }
                sum += nNumbers;
            }
            Console.WriteLine(sum);
        }

        private static void FibonacciNumbers10()
        {
            Console.WriteLine("Enter n: ");
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 200)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number: ");
                }
            }
            FibonacciSequence(0, 1, 1, n);
        }
        private static void FibonacciSequence(int a, int b, int counter, int number)
        {
            if (counter != number)
            {
                Console.Write(a + ", ");
            }
            else
            {
                Console.Write(a);
            }
            if (counter < number)
            {
                FibonacciSequence(b, a + b, counter + 1, number);
            }
        }

        private static void Interval11()
        {
            int n, m;
            Console.Write("Enter n: ");
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n >= 0 && n <= 2000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number!");
                }
            }

            Console.Write("Enter m: ");
            while (true)
            {
                m = int.Parse(Console.ReadLine());
                if (m >= n && m <= 2000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong number!");
                }
            }
            for (int i = n + 1; i <= m; i++)
            {
                if (i % 5 == 0)
                {
                    if (i <= (m - 5))
                    {
                        Console.Write(i + ", ");
                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
            }
            if (n == m)
            {
                Console.WriteLine(0);
            }

        }

        static void Main()
        {
            
            Console.WriteLine(SumOf3Numbers01());
            CompanyInfo02();
            Circle03();
            FormattingNumbers04();
            NumberComparer05();
            QuadraticEquation06();
            SumOf5Numbers07();
            NumbersFrom1ToN08();
            SumOfNNumbers09();
            FibonacciNumbers10();
            Interval11();


        }
    }
}
