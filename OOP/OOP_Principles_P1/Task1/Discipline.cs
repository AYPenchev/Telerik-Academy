namespace Task1
{
    using System;

    public class Discipline
    {
        public string Name { get; set; }
        public int LecturesNumber { get; set; }
        public int ExercisesNumber { get; set; }

        public override string ToString()
        {
            string result = this.Name + " " + this.LecturesNumber + " " + this.ExercisesNumber;
            return result;
        }
    }
}
