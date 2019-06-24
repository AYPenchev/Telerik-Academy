using System.Collections.Generic;
using System.Threading;

namespace Task3
{
    using System;
    using System.Diagnostics;

    public class AdvancedMathPerformance
    {
        public static void PerformanceFloat()
        {
            var floatPerformance = new AdvancedMathFloat();
            var stopWatchFloatPerformance = new Stopwatch();
            stopWatchFloatPerformance.Start();
            int itarationCount = 10000000;
            for (float i = 1; i < itarationCount; i++)
            {
                floatPerformance.Ln(i);
                floatPerformance.Sin(i);
                floatPerformance.SquareRoot(i);
            }

            stopWatchFloatPerformance.Stop();
            Console.WriteLine($"Performance float: {stopWatchFloatPerformance.Elapsed}");
        }

        public static void PerformanceDouble()
        {
            var doublePerformance = new AdvancedMathDouble();
            var stopWatchDoublePerformance = new Stopwatch();
            stopWatchDoublePerformance.Start();
            int itarationCount = 10000000;
            for (double i = 1; i < itarationCount; i++)
            {
                doublePerformance.Ln(i);
                doublePerformance.Sin(i);
                doublePerformance.SquareRoot(i);
            }

            stopWatchDoublePerformance.Stop();
            Console.WriteLine($"Performance double: {stopWatchDoublePerformance.Elapsed}");
        }
        public static void PerformanceDecimal()
        {
            var decimalPerformance = new AdvancedMathDecimal();
            var stopWatchDecimalPerformance = new Stopwatch();
            stopWatchDecimalPerformance.Start();
            int itarationCount = 10000;
            for (decimal i = 1; i < itarationCount; i++)
            {
                decimalPerformance.Ln(i);
                decimalPerformance.Sin(i);
                decimalPerformance.SquareRoot(i);
            }

            stopWatchDecimalPerformance.Stop();
            Console.WriteLine($"Performance decimal: {stopWatchDecimalPerformance.Elapsed} with 100 times iterations less!");
        }

        public static void Main()
        {
            Thread floatThread = new Thread(PerformanceFloat);
            floatThread.Start();

            Thread doubleThread = new Thread(PerformanceDouble);
            doubleThread.Start();

            Thread decimalThread = new Thread(PerformanceDecimal);
            decimalThread.Start();
        }
    }
}
