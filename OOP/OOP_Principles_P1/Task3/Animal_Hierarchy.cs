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

            List<Dog> dogs = new List<Dog>()
            {
                new Dog("rex", 5, Sex.Male),
                new Dog("gosho", 11, Sex.Male),
                new Dog("pesho", 15, Sex.Male)
            };

            double averageDogYears = dogs.Select(x => x.Age).Sum() / (double)dogs.Count;
            Console.WriteLine("{0:0.00}", averageDogYears);

            List<Frog> frogs = new List<Frog>()
            {
                new Frog("rado", 2, Sex.Male),
                new Frog("denislav", 3, Sex.Male),
                new Frog("ivan", 4, Sex.Female)
            };

            double averageFrogYears = frogs.Select(x => x.Age).Sum() / (double)dogs.Count;
            Console.WriteLine("{0:0.00}", averageFrogYears);

            List<Kitten> kittens = new List<Kitten>()
            {
                new Kitten("rado", 2),
                new Kitten("denislav", 5),
                new Kitten("ivan", 4)
            };

            double averageKittenYears = kittens.Select(x => x.Age).Sum() / (double)dogs.Count;
            Console.WriteLine("{0:0.00}", averageKittenYears);
        }
    }
}
