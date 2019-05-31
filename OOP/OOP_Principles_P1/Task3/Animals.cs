namespace Task3
{
    using System;

    public abstract class Animal : ISound
    {
        protected Animal()
        {
            this.Name = string.Empty;
            this.Age = default(int);
            this.Sex = default(Sex);
        }

        protected Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public virtual Sex Sex { get; set; }

        public abstract void MakeSound();
    }
}


