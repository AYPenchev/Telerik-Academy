namespace Task2
{
    using System;

    public class Student : Human
    {
        public float? grade;

        public Student() : base()
        {
            this.Grade = null;
        }

        public Student(string firstName, string lastName, float? grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public float? Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if(value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade should be between 2 and 6!");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            string stringify = "First name: " + this.FirstName + "\nLast name: " + this.LastName + "\nGrade: " + this.Grade + "\n";
            return stringify;
        }
    }
}
