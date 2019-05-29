namespace Task1
{
    using System;

    public class Teacher : Human
    {
        public Teacher() : base()
        {

        }

        public override int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value > 26)
                {
                    this.age = value;
                }
            }
        }

        public void Teach(Discipline discipline)
        {
            Console.WriteLine(discipline.Name);
        }
    }
}
