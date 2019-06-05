namespace Task2
{
    using System;

    class TestPersonClass
    {
        static void Main()
        {
            Person firstPerson = new Person("Ivan", 5);
            Person secondPerson = new Person("Peter");

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
