namespace Task3
{
    using System;

    class Frog : Animal
    {
        public Frog() : base()
        {

        }

        public Frog(string name, int age, Sex sex) : base(name, age, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Frog");
        }
    }
}
