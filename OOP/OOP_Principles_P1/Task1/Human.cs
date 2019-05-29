namespace Task1
{
    using System;
    using System.Collections.Generic;

    public abstract class Human
    {
        protected int age;

        protected Human()
        {
            this.Name = string.Empty;
            this.Age = default(int);
            this.Disciplines = default(List<Discipline>);
        }

        protected string Name { get; set; }
        public abstract int Age { get; set; }
        protected List<Discipline> Disciplines { get;  set; }
    }
}
