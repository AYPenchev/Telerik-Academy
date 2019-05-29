namespace Task3
{
    using System;

    public abstract class Animals : ISound
    {
        public Animals()
        {

        }

        protected enum sex
        {
            Male,
            Female
        }

        protected int Age { get; set; }
        protected string Name { get; set; }
        public abstract enum Sex { }

        public abstract void MakeSound();
    }
}
