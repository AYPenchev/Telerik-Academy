namespace StudentClass
{
    using System;

    public class Student
    {
        Student()
        {
            this.FirstName = null;
            this.MiddleName = null;
            this.LastName = null;
            this.SSN = null;
            this.PermanentAddress = null;
            this.PhoneNumber = null;
            this.Email = null;
            this.Course = null;
        }

        Student(string firstName = null, string middleName = null, string lastName = null, string ssn = null, string permanentAddress = null,
                string phoneNumber = null, string email = null, string course = null)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        /// <summary>
        /// Social Security number in USA, like PIN - personal ID number
        /// </summary>
        public string SSN { get; private set; }
        public string PermanentAddress { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string Course { get; private set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
