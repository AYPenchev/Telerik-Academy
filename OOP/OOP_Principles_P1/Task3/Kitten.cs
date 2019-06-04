namespace Task3
{
    using System;

    class Kitten : Cat
    {
        public Kitten() : base()
        {
            this.Sex = Sex.Female;
        }

        public Kitten(string name, int age) : base(name, age)
        {
            this.Sex = Sex.Female;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kitten");
        }

        public override Sex Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                if (value.CompareTo(Sex) != 0)
                {
                    throw new FormatException("You can't change its sex");
                }

                this.sex = Sex.Female;
            }
        }
    }
}
