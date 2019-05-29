namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Human
    {
        public Teacher() : base()
        {

        }

        public new List<Discipline> Disciplines { get; set; }
        public new string Name { get; set; }
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
