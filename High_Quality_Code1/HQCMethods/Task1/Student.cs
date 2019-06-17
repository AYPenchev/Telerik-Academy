namespace Task1
{
    using System;
    using System.Globalization;

    public class Student
    {
        public Student()
        {
            this.FirstName = null;
            this.LastName = null;
            this.OtherInfo = null;
        }

        /// <param name="dateOfBirth">Enter birth date in the following format: "dd/mm/yyyy"</param>
        public Student(string firstName, string lastName, string dateOfBirth, string otherInfo = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public string DateOfBirth { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime thisStudentBirthDate = DateTime.Parse(this.DateOfBirth,
                                                           CultureInfo.CreateSpecificCulture("fr-FR"));
            DateTime otherStudentBirthDate = DateTime.Parse(otherStudent.DateOfBirth,
                                                            CultureInfo.CreateSpecificCulture("fr-FR"));
            return thisStudentBirthDate < otherStudentBirthDate;
        }
    }
}
