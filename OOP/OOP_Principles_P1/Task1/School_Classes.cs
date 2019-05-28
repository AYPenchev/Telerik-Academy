namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class SchoolClasses
    {
        static void Main()
        {
            Discipline Math = new Discipline();
            Math.ExercisesNumber = 4;
            Math.LecturesNumber = 8;
            Math.Name = "Algebra";

            Discipline History = new Discipline();
            History.ExercisesNumber = 2;
            History.LecturesNumber = 12;
            History.Name = "Bulgarian history";

            List<Discipline> disciplines = new List<Discipline>();
            disciplines.Add(Math);
            disciplines.Add(History);

            Student firstStudent = new Student();
            firstStudent.Age = 10;
            firstStudent.Name = "Pesho";
            firstStudent.Disciplines = disciplines;

            Student secondStudent = new Student();
            firstStudent.Age = 15;
            firstStudent.Name = "Ivan";
            firstStudent.Disciplines = disciplines;

            Teacher firstTeacher = new Teacher();
            firstTeacher.Age = 29;
            firstTeacher.Name = "Evelina";
            firstTeacher.Disciplines = disciplines;

            List<Teacher> teachersAClass = new List<Teacher>();
            teachersAClass.Add(firstTeacher);

            List<Student> studentsClassA = new List<Student>();
            studentsClassA.Add(firstStudent);
            studentsClassA.Add(secondStudent);

            SchoolClass aClass = new SchoolClass();
            aClass.Students = studentsClassA;
            aClass.Teachers = teachersAClass;
            aClass.TextIdentifier = "Nice class";

            SchoolClass bClass = new SchoolClass();
            SchoolClass vClass = new SchoolClass();

            List<SchoolClass> schoolClasses = new List<SchoolClass>();
            schoolClasses.Add(aClass);
            schoolClasses.Add(bClass);
            schoolClasses.Add(vClass);

            School mgRuse = new School();

            mgRuse.SchoolClasses = schoolClasses;

        }
    }
}
