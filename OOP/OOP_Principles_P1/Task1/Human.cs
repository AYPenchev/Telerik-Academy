namespace Task1
{
    using System;
    using System.Collections.Generic;

    public abstract class Human
    {
        protected string name;
        protected int age;
        protected List<Discipline> disciplines;

        protected Human()
        {
            this.Name = string.Empty;
            this.Age = default(int);
            this.Disciplines = default(List<Discipline>);
        }

        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public abstract List<Discipline> Disciplines { get;  set; }
    }
}
