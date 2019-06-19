namespace Task2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Exam> Exams { get; set; }

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName ?? throw new ArgumentNullException("Invalid first name");
            this.LastName = lastName ?? throw new ArgumentNullException("Invalid last name");
            this.Exams = exams;
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new ArgumentNullException("Exams can't be null");
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentNullException("Student has no exams");
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                try
                {
                    results.Add(this.Exams[i].Check());
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new ArgumentNullException("Missing exams");
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentNullException("Student has no exams");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
