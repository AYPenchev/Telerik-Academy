namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;

    public class SimpleMathPerformance
    {
        public static void Performance<T>(object message)
        {
            var type = typeof(T);
            dynamic currentTypePerformance = Activator.CreateInstance(type);
            
            var stopWatchPerformance = new Stopwatch();
            stopWatchPerformance.Start();
            int itarationCount = 10000000;
            for (int i = 1; i < itarationCount; i++)
            {
                var holdI = new object[1] { i };
                type.GetMethod("Add").Invoke(currentTypePerformance, holdI);
                type.GetMethod("Substract").Invoke(currentTypePerformance, holdI);
                type.GetMethod("Increment").Invoke(currentTypePerformance, null);
                type.GetMethod("Multiply").Invoke(currentTypePerformance, holdI);
                type.GetMethod("Devide").Invoke(currentTypePerformance, holdI);
            }

            stopWatchPerformance.Stop();
            Console.WriteLine($"{message} {stopWatchPerformance.Elapsed}");
        }

        public static void Main()
        { 
            var performanceOfDifferentTypese = new List<Action<object>>
            {
                Performance<SimpleMathInteger>,
                Performance<SimpleMathInteger>,
                Performance<SimpleMathDouble>,
                Performance<SimpleMathLong>,
                Performance<SimpleMathFloat>
            };

            performanceOfDifferentTypese.ForEach(x =>
            {
                Thread currentTypeThread = new Thread(new ParameterizedThreadStart(x));
                currentTypeThread.Start("Performance: ");
            });
        }
    }
}
