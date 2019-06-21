using System.Diagnostics;

namespace Task2
{
    using System;
    using System.Threading;

    public class Program
    {
        public static void IntegerPerformance()
        {
            var integerPerformance = new SimpleMathInteger();
            var stopWatchIntegerPerformance = new Stopwatch();
            stopWatchIntegerPerformance.Start();
            for (int i = 1; i < 1000000000; i++)
            {
                integerPerformance.Add(i);
                integerPerformance.Substract(i);
                integerPerformance.Increment();
                integerPerformance.Multiply(i);
                integerPerformance.Devide(i);
            }

            stopWatchIntegerPerformance.Stop();
            Console.WriteLine("Integer performance: " + stopWatchIntegerPerformance.Elapsed);
        }

        public static void LongPerformance()
        {
            var longPerformance = new SimpleMathLong();
            var stopWatchLongPerformance = new Stopwatch();
            stopWatchLongPerformance.Start();
            for (int i = 1; i < 1000000000; i++)
            {
                longPerformance.Add(i);
                longPerformance.Substract(i);
                longPerformance.Increment();
                longPerformance.Multiply(i);
                longPerformance.Devide(i);
            }

            stopWatchLongPerformance.Stop();
            Console.WriteLine("Long performance: " + stopWatchLongPerformance.Elapsed);
        }

        public static void FloatPerformance()
        {
            var floatPerformance = new SimpleMathFloat();
            var stopWatchFloatPerformance = new Stopwatch();
            stopWatchFloatPerformance.Start();
            for (int i = 1; i < 1000000000; i++)
            {
                floatPerformance.Add(i);
                floatPerformance.Substract(i);
                floatPerformance.Increment();
                floatPerformance.Multiply(i);
                floatPerformance.Devide(i);
            }

            stopWatchFloatPerformance.Stop();
            Console.WriteLine("Float performance: " + stopWatchFloatPerformance.Elapsed);
        }

        public static void DoublePerformance()
        {
            var doublePerformance = new SimpleMathDouble();
            var stopWatchDoublePerformance = new Stopwatch();
            stopWatchDoublePerformance.Start();
            for (int i = 1; i < 1000000000; i++)
            {
                doublePerformance.Add(i);
                doublePerformance.Substract(i);
                doublePerformance.Increment();
                doublePerformance.Multiply(i);
                doublePerformance.Devide(i);
            }

            stopWatchDoublePerformance.Stop();
            Console.WriteLine("Double performance: " + stopWatchDoublePerformance.Elapsed);
        }

        public static void DecimalPerformance()
        {
            var decimalPerformance = new SimpleMathDecimal();
            var stopWatchDecimalPerformance = new Stopwatch();
            stopWatchDecimalPerformance.Start();
            for (int i = 1; i < 1000000000; i++)
            {
                decimalPerformance.Add(i);
                decimalPerformance.Substract(i);
                decimalPerformance.Increment();
                decimalPerformance.Multiply(i);
                decimalPerformance.Devide(i);
            }

            stopWatchDecimalPerformance.Stop();
            Console.WriteLine("Decimal performance: " + stopWatchDecimalPerformance.Elapsed);
        }

        public static void Main()
        {
            Thread threadInteger = new Thread(IntegerPerformance);
            threadInteger.Start();

            Thread threadLong = new Thread(LongPerformance);
            threadLong.Start();

            Thread threadFloat = new Thread(FloatPerformance);
            threadFloat.Start();

            Thread threadDouble = new Thread(DoublePerformance);
            threadDouble.Start();

            Thread threadDecimal = new Thread(DecimalPerformance);
            threadDecimal.Start();


        }
    }
}
