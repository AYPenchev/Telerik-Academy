namespace Task3
{
    using System;

    public abstract class Animals : ISound
    {
        public Animals()
        {

        }

        protected int Age { get; set; }
        protected string Name { get; set; }
        public abstract Sex Sex { get; set; }

        public abstract void MakeSound();
    }

    public enum Sex
    {
        Male,
        Female
    }
}


