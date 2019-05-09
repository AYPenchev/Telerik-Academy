namespace Task1
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                double sqrtNumber = Math.Sqrt(number);
                Console.WriteLine("{0:0.000}", sqrtNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
