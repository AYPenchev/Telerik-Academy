using System;
using System.Linq;

namespace Task1
{
    public class StatisticsPrinter
    {
        public void PrintStatistics(double[] elements, int count)
        {
            double maxElement = elements.Max();
            this.PrintMax(maxElement);

            double minElement = elements.Min();
            this.PrintMin(minElement);

            double averageOfAllElements = elements.Average();
            this.PrintAverage(averageOfAllElements);
        }

        private void PrintMax(double maxElement)
        {
            Console.WriteLine(maxElement);
        }

        private void PrintMin(double minElement)
        {
            Console.WriteLine(minElement);
        }

        private void PrintAverage(double averageOfAllElements)
        {
            Console.WriteLine(averageOfAllElements);
        }
    }
}
