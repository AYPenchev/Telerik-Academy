namespace Task3
{
    using System;

    public abstract class Cat : Animal
    {
        protected Sex sex;

        protected Cat() : base()
        {

        }
        protected Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        protected Cat(string name, int age, Sex sex) : base(name, age, sex)
        {

        }
    }
}
