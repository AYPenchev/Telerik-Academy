namespace StudentClass
{
    using System;

    public class RunStudentClass
    {
        static void Main()
        {
            Student firstStudent = new Student("Ivan", "Petrov", "Ivanov","123456789","Sofia",
                "0893457652", "ivan.petrov@gmail.com", 2);

            Student secondStudent = new Student();

            secondStudent = firstStudent.Clone() as Student;

        }
    }
}
