namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Human
    {
        public Teacher() : base()
        {

        }

        public override List<Discipline> Disciplines { get; set; }
        public override string Name { get; private set; }
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
