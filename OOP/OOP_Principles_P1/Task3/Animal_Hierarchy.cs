namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalHierarchy
    {
        static void Main()
        {
            Dog rex = new Dog("Rex", 3, Sex.Female);
            rex.MakeSound();

            Frog max = new Frog("Max", 4, Sex.Male);
            max.MakeSound();

            Kitten bob = new Kitten("Bob", 2);
            try
            {
                bob.Sex = Sex.Female;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(bob.Sex);

            bob.MakeSound();

            Tomcat tom = new Tomcat("Tom", 4);

            try
            {
                tom.Sex = Sex.Female;

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(tom.Sex);

            tom.MakeSound();

            List<Animal> animals = new List<Animal>()
            {
                new Kitten("rado", 2),
                new Frog("denislav", 3, Sex.Male),
                new Dog("pesho", 15, Sex.Male),
                new Tomcat("kiro", 7)
            };

            double averageAnimalsYears = animals.Select(x => x.Age).Sum() / (double)animals.Count;
            Console.WriteLine("{0:0.00}", averageAnimalsYears);
        }
    }
}
