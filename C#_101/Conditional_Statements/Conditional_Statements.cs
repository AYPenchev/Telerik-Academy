using System;


namespace Conditional_Statements
{

    class Conditional_Statements
    {
        private static void ExchangeNumbers01()
        {
            Console.WriteLine("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            if (b < a)
            {
                Console.WriteLine(b + " " + a);
            }
            else
            {
                Console.WriteLine(a + " " + b);
            }

        }

        private static void BonusScore02()
        {
            Console.WriteLine("Enter score: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(n * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(n * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(n * 1000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }

        private static void PlayCard03()
        {
            Console.WriteLine("Enter card sign: ");
            string card = Console.ReadLine();
            switch (card)
            {
                case "2":
                    Console.WriteLine("yes " + card);
                    break;
                case "3":
                    Console.WriteLine("yes " + card);
                    break;
                case "4":
                    Console.WriteLine("yes " + card);
                    break;
                case "5":
                    Console.WriteLine("yes " + card);
                    break;
                case "6":
                    Console.WriteLine("yes " + card);
                    break;
                case "7":
                    Console.WriteLine("yes " + card);
                    break;
                case "8":
                    Console.WriteLine("yes " + card);
                    break;
                case "9":
                    Console.WriteLine("yes " + card);
                    break;
                case "10":
                    Console.WriteLine("yes " + card);
                    break;
                case "J":
                    Console.WriteLine("yes " + card);
                    break;
                case "Q":
                    Console.WriteLine("yes " + card);
                    break;
                case "K":
                    Console.WriteLine("yes " + card);
                    break;
                case "A":
                    Console.WriteLine("yes " + card);
                    break;
                default:
                    Console.WriteLine("no " + card);
                    break;
            }
        }

        private static void MultiplicationSign04()
        {
            Console.WriteLine("Enter first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            int howManyPositive = 0;
            if (firstNum > 0)
            {
                howManyPositive++;
            }
            if (secondNum > 0)
            {
                howManyPositive++;
            }
            if (thirdNum > 0)
            {
                howManyPositive++;
            }

            if (howManyPositive == 2 || howManyPositive == 0)
            {
                Console.WriteLine("-");
            }
            else if (howManyPositive == 1 || howManyPositive == 3)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine(0);
            }

        }

        private static double ReadDoubleWithConstraints()
        {
            double num;
            while (true)
            {
                num = double.Parse(Console.ReadLine());
                if (num >= -200 && num <= 200)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("You entered wrong number!");
                }
            }
        }

        private static void BiggestOf3Numbers05()
        {
            Console.Write("Enter first number: ");
            double firstNum = ReadDoubleWithConstraints();
            Console.Write("Enter second number: ");
            double secondNum = ReadDoubleWithConstraints();
            Console.Write("Enter third number: ");
            double thirdNum = ReadDoubleWithConstraints();
            if(firstNum > secondNum)
            {
                if(firstNum > thirdNum)
                {
                    Console.WriteLine(firstNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                }
            }
            else
            {
                if(secondNum > thirdNum)
                {
                    Console.WriteLine(secondNum);
                }
                else
                {
                    Console.WriteLine(thirdNum);
                }
            }
        }
        private static void BiggestOf5Numbers06()
        {
            Console.Write("Enter first number: ");
            double firstNum = ReadDoubleWithConstraints();
            Console.Write("Enter second number: ");
            double secondNum = ReadDoubleWithConstraints();
            Console.Write("Enter third number: ");
            double thirdNum = ReadDoubleWithConstraints();
            Console.Write("Enter fourth number: ");
            double fourthNum = ReadDoubleWithConstraints();
            Console.Write("Enter fifth number: ");
            double fifthNum = ReadDoubleWithConstraints();
            double maxNumber;
            if(firstNum > secondNum)
            {
                maxNumber = firstNum;
            }
            else
            {
                maxNumber = secondNum;
            }

            if(thirdNum > maxNumber)
            {
                maxNumber = thirdNum;
            }
            
            if(fourthNum > maxNumber)
            {
                maxNumber = fourthNum;
            }

            if(firstNum > maxNumber)
            {
                maxNumber = firstNum;
            }
            Console.WriteLine(maxNumber);
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
        private static void Sort3Numbers07()
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = ReadIntWithConstraints();
            Console.WriteLine("Enter second number: ");
            int secondNum = ReadIntWithConstraints();
            Console.WriteLine("Enter third number: ");
            int thirdNum = ReadIntWithConstraints();

            if(firstNum > secondNum)
            {
                if(firstNum > thirdNum)
                {
                    if(secondNum > thirdNum)
                    {
                        Console.WriteLine(firstNum + " " + secondNum + " " + thirdNum);
                    }
                    else
                    {
                        Console.WriteLine(firstNum + " " + thirdNum + " " + secondNum);
                    }
                }
                else
                {
                    Console.WriteLine(thirdNum + " " + firstNum + " " + secondNum);
                }
            }
            else
            {
                if(secondNum > thirdNum)
                {
                    if(thirdNum > firstNum)
                    {
                        Console.WriteLine(secondNum + " " + thirdNum + " " + firstNum);
                    }
                    else
                    {
                        Console.WriteLine(secondNum + " " + firstNum + " " + thirdNum);
                    }
                }
                else
                {
                    Console.WriteLine(thirdNum + " " + secondNum + " " + firstNum);
                }
            }
        }

        private static void DigitAsWord08()
        {
            Console.Write("Enter digit [0-9]: ");
            string digit = Console.ReadLine();
          
            switch (digit)
            {
                case "0":
                    Console.WriteLine("zero");
                    break;
                case "1": Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("not a digit");
                    break;
            }
        }

        private static void IntDoubleString09()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    int intNum;
                    while (true)
                    {
                        intNum = int.Parse(Console.ReadLine());
                        if (intNum >= -1000 && intNum <= 1000)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered wrong number. Try again! ");
                        }
                    }
                    intNum += 1;
                    Console.WriteLine(intNum);
                    break;

                case "real":
                    double doubleNum;
                    while (true)
                    {
                        doubleNum = double.Parse(Console.ReadLine());
                        if (doubleNum >= -1000 && doubleNum <= 1000)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered wrong number. Try again! ");
                        }
                    }
                    doubleNum += 1;
                    Console.WriteLine(String.Format("{0:0.00}", doubleNum));
                    break;

                case "text":
                    string stringText = Console.ReadLine();
                    Console.WriteLine(stringText + "*");
                    break;
                default:
                    break;
            }
        }

        static void Main()
        {
            ExchangeNumbers01();
            BonusScore02();
            PlayCard03();
            MultiplicationSign04();
            BiggestOf3Numbers05();
            BiggestOf5Numbers06();
            Sort3Numbers07();
            DigitAsWord08();
            IntDoubleString09();
        }
    }
}
