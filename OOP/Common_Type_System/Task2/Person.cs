namespace Task2
{
    using System;

    public class Person
    {
        public Person()
        {
            this.Name = null;
            this.Age = null;
        }

        public Person(string name = null, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int? Age { get; private set; }

        public override string ToString()
        {
            try
            {
                if (this.Age == null)
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException e)
            {
                return string.Format("First name:  {0} \nAge is not defined! {1}", this.Name, e.Message);
            }

            return string.Format("First name:  {0} \nAge:  {1} ", this.Name, this.Age);
        }
    }
}
