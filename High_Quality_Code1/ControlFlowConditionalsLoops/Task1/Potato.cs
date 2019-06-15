namespace Task1
{
    using System;

    public class Potato : Vegetable, IPeelable, ICuttable
    {
        public void Peel()
        {
            Console.WriteLine("Peeled potato");
            this.IsPeeled = true;
        }

        public void Cut()
        {
            Console.WriteLine("Cut potato");
            this.IsCut = true;
        }
    }
}
