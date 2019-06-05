using System;

namespace StudentClass
{
    public class Student : ICloneable
    {
        public Student()
        {
            this.FirstName = null;
            this.MiddleName = null;
            this.LastName = null;
            this.SSN = null;
            this.PermanentAddress = null;
            this.PhoneNumber = null;
            this.Email = null;
            this.Course = default(int);
        }

        public Student(string firstName = null, string middleName = null, string lastName = null, string ssn = null, string permanentAddress = null,
                string phoneNumber = null, string email = null, int course = default(int))
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
        public int Course { get; private set; }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public override bool Equals(object obj)
        {
            var otherStudent = (Student) obj;
            return (this.SSN == otherStudent.SSN) && (this.PermanentAddress == otherStudent.PermanentAddress);
        }
    
        public override int GetHashCode()
        {
            return SSN.GetHashCode() ^ PermanentAddress.GetHashCode();
        }

        public object Clone()
        {
            var clonedStudent = new Student()
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                SSN = this.SSN,
                PermanentAddress = this.PermanentAddress,
                PhoneNumber = this.PhoneNumber,
                Email = this.Email,
                Course = this.Course
            };

            return clonedStudent;
        }

        public override string ToString()
        {
            return string.Format("First name:  {0} \nMiddle name:  {1}  \nLast name:  {2} \nSocial Security number:  {3} " +
                                 "\nPermanent Address: {4} \nPhone Number:  {5} \nEmail:  {6} \nCourse:  {7}"
                , this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.PhoneNumber, this.Email, this.Course);
        }
    }
}
