namespace Task1
{
    using System;

    class Carrot : Vegetable, IPeelable, ICuttable
    {
        public void Peel()
        {
            Console.WriteLine("Peeled carrot");
            this.IsPeeled = true;
        }

        public void Cut()
        {
            Console.WriteLine("Cut carrot");
            this.IsCut = true;
        }
    }
}
