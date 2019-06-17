namespace Task1
{
    using System;

    public class ControlFlow
    {
        public static void Main()
        {
            Potato potato = new Potato();

            // ... 
            if (potato != null)
            {
                if (potato.IsPeeled && potato.IsCut)
                {
                    Chef cookingChef = new Chef();
                    cookingChef.Cook();
                }
            }

            // Random calculations
            int x = default(int);
            int y = default(int);

            try
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            bool shouldVisitCell = true;
            const int MIN_X = 9;
            const int MAX_X = 12;
            const int MIN_Y = 10;
            const int MAX_Y = 15;

            bool isYBetweenYMaxAndYMin = MIN_Y <= y && y <= MAX_Y;
            bool isXBetweenXMaxAndYMin = MIN_X <= x && x <= MAX_X;
            if (isXBetweenXMaxAndYMin && isYBetweenYMaxAndYMin && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("Cell visited");
        }
    }
}
