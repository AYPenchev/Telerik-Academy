namespace Task3
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat() : base()
        {
            this.Sex = Sex.Male;
        }
        public Tomcat(string name, int age) : base(name, age)
        {
            this.Sex = Sex.Male;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Tomcat");
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
                this.sex = Sex.Male;
            }
        }
    }
}
