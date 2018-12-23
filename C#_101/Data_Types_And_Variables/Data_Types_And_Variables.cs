using System;

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
        }
    }
}