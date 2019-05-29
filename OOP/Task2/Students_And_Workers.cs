namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkers
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>(10)
            {
                new Student("Ivan", "Petrov", 4),
                new Student("George", "Petrov", null),
                new Student("Pesho", "Petrov", 2),
                new Student("Ivan", "Ivanov", 3),
                new Student("Ivan", "Konstantinov", 6),
                new Student("Viktor", "Petrov", 4),
                new Student("Ivan", "Dimitrov", 5),
                new Student("Kalin", "Petrov", null),
                new Student("Martin", "Petrov", 2),
                new Student("Ivan", "Nedev", 6)
            };

            listOfStudents = listOfStudents.OrderBy(x => x.Grade).ToList();

            foreach (Student student in listOfStudents)
            {
                Console.WriteLine(student.ToString());
            }

            List<Worker> listOfWorkers = new List<Worker>(10)
            {
                new Worker("Ivan", "Petrov", 150),
                new Worker("George", "Petrov", 200, 7),
                new Worker("Pesho", "Petrov", 250, 7, 6),
                new Worker("Ivan", "Ivanov", 300, 8, 7),
                new Worker("Ivan", "Konstantinov", 350, 16, 1),
                new Worker("Viktor", "Petrov", 400, 2, 7),
                new Worker("Ivan", "Dimitrov", 450, 3, 5),
                new Worker("Kalin", "Petrov", 500, 4, 6),
                new Worker("Martin", "Petrov", 550, 1, 7),
                new Worker("Ivan", "Nedev", 600, 6, 4)
            };

            listOfWorkers = listOfWorkers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            foreach (Worker worker in listOfWorkers)
            {
                Console.WriteLine(worker.ToString());
            }

            List<Human> mergedList = new List<Human>(listOfStudents.Count + listOfWorkers.Count);
            mergedList.AddRange(listOfStudents);
            mergedList.AddRange(listOfWorkers);

            mergedList = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (Human human in mergedList)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}
