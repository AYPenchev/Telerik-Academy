using System;
using System.Text;

namespace Data_Types_Variables
{
    class Data_Types_And_Variables
    {
        static void Main()
        {
            //Task1
            ushort firstNum = 52130;
            sbyte secondNum = -115;
            int thirdNum = 4825932;
            byte fourthNum = 97;
            short fifthNum = -10000;

            //Task2
            double firstDoubleNum = 34.567839023;
            Console.WriteLine(firstDoubleNum);
            float firstFloatNum = 12.345f;
            Console.WriteLine(firstFloatNum);
            double secondDoubleNum = 8923.1234857;
            Console.WriteLine(secondDoubleNum);
            double secondFloatNum = 3456.091;
            Console.WriteLine(secondFloatNum);

            //Task3
            int hexadecimalInt = 0xFE;
            Console.WriteLine(hexadecimalInt);

            //Task4
            char hexadecimalChar = (char)0x2A;
            Console.WriteLine(hexadecimalChar);

            //Task5
            bool isFemale = false;
            Console.WriteLine(isFemale);

            //Task6
            string hello = "Hello";
            string world = "World";
            object helloWorldObject = hello + " " + world;
            string helloWorld = (string)helloWorldObject;
            Console.WriteLine(helloWorld);

            //Task7
            Console.WriteLine("The \"use\" of quotations causes difficulties");

            //Task8
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine();
            Console.Write("   " + (char)169);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  " + (char)169 + " " + (char)169);
            Console.WriteLine();
            Console.WriteLine(" " + (char)169 + "   " + (char)169);
            Console.WriteLine();
            Console.WriteLine((char)169 + " " + (char)169 + " " + (char)169 + " " + (char)169);

            //Task8.2
            Console.WriteLine("Enter height: ");

            int height;

            do
            {
                height = int.Parse(Console.ReadLine());
            } while (height < 1);

            int temp;
            int emptySpaces = temp = height - 1;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    while (temp > 0)
                    {
                        Console.Write(" ");
                        temp--;
                    }
                    if (i > j)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                    else if (i == j)
                    {
                        Console.Write("*");
                    }

                }
                temp = --emptySpaces;
                Console.WriteLine();
            }

            //Task9
            int x = 5;
            int y = 10;
            Console.WriteLine("X and Y before swap: ");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("X and Y after swap: ");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            //Task10
            string firstName = "Joe";
            string lastName = "King";
            byte age = 100;
            char gender = 'm';
            long idNumber = 8306112507;
            string uniqueEmployeeNumber = "275600034227569999";
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            if (age >= 0 && age <= 100)
            {
                Console.WriteLine(age);
            }
            if (gender == 'm' || gender == 'f')
            {
                Console.WriteLine(gender);
            }
            Console.WriteLine(idNumber);
            Console.WriteLine(uniqueEmployeeNumber);

            //Task11
            string firstNameCardHolder;
            string surname;
            string familyName;
            int availableAmount;
            string bankName;
            string IBAN;
            byte CVC2;
            short secure3DCode;

            //Task12
            int? emptyInteger = null;
            double? emptyDouble = null;
            Console.WriteLine(emptyInteger);
            Console.WriteLine(emptyDouble);
            Console.WriteLine(emptyInteger + 5);
            Console.WriteLine(emptyDouble + null);

            //Task13
            double firstNumberToCompare = double.Parse(Console.ReadLine());
            double secondNumberToCompare = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double difference = Math.Abs(firstNumberToCompare - secondNumberToCompare);
            difference = Math.Round(difference, 6);
            if (difference < eps)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //Task14
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}